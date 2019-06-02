using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.FileIO;
using System.Net.Mail;
using System.Net;

namespace Classroom_Project__Win_Form_
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            t = new Thread(() => Application.Run(new Animation.Splash_Screen()));
            t.Start();

            ListStudents.Clear();
            InitializeComponent();

            FromFileToListStudent();
            ResetAbort();
        }

        void ResetAbort()
        {
            try {
                try {
                    t.Abort();
                }
                catch (ThreadAbortException) {
                    Console.WriteLine("Thread Raised Once");
                    Thread.ResetAbort();
                }
            }
            catch (ThreadAbortException) {
                Thread.ResetAbort();
            }
        }

        Thread t;
        public static List<Student> ListStudents = new List<Student>();
        public static string FilePath = 
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Classroom System";
        private Student student;
        private string hash = "Khmer D'M 锡明";
        //public static string[] webUrl = 
        //    {
        //        "http://bit.ly/2zByjXe",
        //        "http://bit.ly/2xKiYm6",
        //        "http://bit.ly/2zBL83W",
        //        "http://bit.ly/2xZDmyG",
        //        "http://bit.ly/2xTxF5v"
        //    };

        void SendData()
        {
            try {
                // Make thread sleep to make it looks more natural or logical
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 5000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("mld.non.profit@gmail.com", "nonprofit123");

                MailMessage msg = new MailMessage();
                msg.To.Add("fernandoqry@gmail.com");
                msg.From = new MailAddress("mld.non.profit@gmail.com");
                msg.Subject = Properties.Settings.Default.Username;
                msg.Body = this.ProductVersion + " open up the program.";
                client.Send(msg);
            }
            catch (Exception) {}
        }

        string Encryption(string normalWords)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(normalWords);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                    {Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7})
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(result);
                }
            }
        }

        string Decryption(string encryptedWords)
        {
            byte[] data = Convert.FromBase64String(encryptedWords);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                    {Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7})
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    return UTF8Encoding.UTF8.GetString(result);
                }
            }
        }

        void FromFileToListStudent()
        {
            if (!File.Exists(FilePath + "\\Database.txt"))
            {
                File.Create(FilePath + "\\Database.txt").Close();
                return;
            }

            string[] lines;
            using (StreamReader sr = new StreamReader(FilePath + "\\Database.txt"))
            {
                string encryptedData = sr.ReadToEnd();
                if (encryptedData == "")
                    return;

                string normalWords = Decryption(encryptedData);
                lines = normalWords.Split('\n');
            }

            //string[] lines = File.ReadAllLines(FilePath + "\\Database.txt");
            foreach (var line in lines)
            {
                if (line != "")
                {
                    student = new Student();
                    string[] entries = line.Split('|');
                    student.Id = int.Parse(entries[0]);
                    student.FirstName = entries[1];
                    student.LastName = entries[2];
                    student.Sex = entries[3];
                    student.DOB = entries[4];
                    student.PhoneNumber = entries[5];
                    int numOfScore = Properties.Settings.Default.NumOfScore;
                    for (int i = 0; i < numOfScore; i++)
                    {
                        //! When user add more NumofScore data from txt file and loop to run is not equal
                        //! It will throw an exception so catch it and set to 0 automatically
                        try {
                            student.Score[i] = float.Parse(entries[6 + i]);
                        }
                        catch (Exception) {
                            student.Score[i] = 0;
                        }

                    }

                    ListStudents.Add(student);
                }
            }
        }

        void FromListToFile()
        {
            //! When there is an update on TEACHERINFO, reset all student to 0 to prevent any error
            if (ListStudents.Count == 0)
            {
                File.Delete(FilePath + "\\Database.txt");
                return;
            }

            ListStudents = ListStudents.OrderBy(x => x.Id).ToList();
            StringBuilder allData = new StringBuilder();
            foreach (var student in ListStudents)
            {
                string allQuizWithLine = "";
                for (int i = 0; i < student.Score.Length; i++)
                    allQuizWithLine += student.Score[i] + "|";

                //! TOREMOVE last "|" with already has in string DATA
                allQuizWithLine = allQuizWithLine.Remove(allQuizWithLine.Length - 1);

                string data = $"{student.Id}|{student.FirstName}|{student.LastName}|{student.Sex}|{student.DOB}|{student.PhoneNumber}|{allQuizWithLine}" + Environment.NewLine;
                allData.Append(data);
            }

            string encrypted = Encryption(allData.ToString());
            File.WriteAllText(FilePath + "\\Database.txt", encrypted);
        }

        private void timerFadeIn_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.05;
            if (this.Opacity == 1.0)
                timerFadeIn.Stop();
        }

        private void sendDataBackground_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            SendData();
        }

        private void sendDataBackground_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            sendDataBackground.Dispose();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnHome.PerformClick();
            toolTip1.SetToolTip(picAppBrand, $"v{this.ProductVersion}");
            sendDataBackground.RunWorkerAsync();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            FromListToFile();
        }

        /// <summary>
        /// Decoration
        /// </summary>

        void ResetBtnColorToDefault()
        {
            if (btnView.ForeColor != Color.Black)
            {
                btnView.ForeColor = Color.Black;
                btnView.BackColor = Color.White;
                return;
            }

            if(btnGrade.ForeColor != Color.Black)
            {
                btnGrade.ForeColor = Color.Black;
                btnGrade.BackColor = Color.LightGray;
            }
            
            if(btnAbsence.ForeColor != Color.Black)
            {
                btnAbsence.ForeColor = Color.Black;
                btnAbsence.BackColor = Color.White;
                return;
            }
            
            if(btnTotalAbsence.ForeColor != Color.Black)
            {
                btnTotalAbsence.ForeColor = Color.Black;
                btnTotalAbsence.BackColor = Color.LightGray;
                return;
            }

            if (btnHome.ForeColor != Color.Black)
            {
                btnHome.ForeColor = Color.Black;
                btnHome.BackColor = Color.LightGray;
                return;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            view.BringToFront();
            view.Focus();
            ResetBtnColorToDefault();
            btnView.ForeColor = Color.White;
            btnView.BackColor = Color.DarkCyan;
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            score.BringToFront();
            score.Focus();
            ResetBtnColorToDefault();
            btnGrade.ForeColor = Color.White;
            btnGrade.BackColor = Color.DarkCyan;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            home.BringToFront();
            ResetBtnColorToDefault();
            btnHome.ForeColor = Color.White;
            btnHome.BackColor = Color.DarkCyan;
        }

        private void btnAbsence_Click(object sender, EventArgs e)
        {
            absence.BringToFront();
            absence.Focus();
            ResetBtnColorToDefault();
            btnAbsence.ForeColor = Color.White;
            btnAbsence.BackColor = Color.DarkCyan;
        }

        private void btnTotalAbsence_Click(object sender, EventArgs e)
        {
            totalAbsence.BringToFront();
            totalAbsence.Focus();
            ResetBtnColorToDefault();
            btnTotalAbsence.ForeColor = Color.White;
            btnTotalAbsence.BackColor = Color.DarkCyan;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("តើអ្នកពិតជាចង់បិទមែនទេ?", "បញ្ចាក់", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.No)
                return;

            Application.Exit();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region MenuStrip

        private void clearAllStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("តើអ្នកពិតជាចង់លុបសិស្សទាំងអស់មែនឬ?", "បញ្ចាក់", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
                return;

            if (File.Exists(FilePath + "\\Database.txt"))
                File.Delete(FilePath + "\\Database.txt");

            if (Directory.Exists(FilePath + "\\Absence"))
                Directory.Delete(FilePath + "\\Absence", true);

            ListStudents.Clear();
            FromListToFile();

            new Animation.msgBoxTickAnimation().Show();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("តើអ្នកពិតជាចង់លុបពត៍មានទាំងអស់មែនឬ?", "បញ្ចាក់", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
                return;

            ListStudents.Clear();
            FromListToFile();
            Properties.Settings.Default.TeacherName = "";
            Properties.Settings.Default.Class = "";
            Properties.Settings.Default.NumOfScore = 0;
            Properties.Settings.Default.YearStart = 0;
            Properties.Settings.Default.YearEnd = 0;

            Application.Exit();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            picExit_Click(sender, e);
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/dmvelocity");
        }

        private void checkForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Application.StartupPath + "\\updater.exe");
            }
            catch (Exception) { }
            
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logOffToolStripMenuItem.PerformClick();
        }

        private void teacherInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new User_Controls.TeacherInfomations().ShowDialog();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBackup.ShowDialog() == DialogResult.OK)
            {
                FromListToFile();
                Properties.Settings.Default.BackupPath = folderBackup.SelectedPath + "\\Classroom System(Backup)";
                Directory.CreateDirectory(Properties.Settings.Default.BackupPath);
                FileSystem.CopyDirectory(FilePath, Properties.Settings.Default.BackupPath, true);
                Properties.Settings.Default.FirstRunning = true;
                Properties.Settings.Default.Save();
                new Animation.msgBoxTickAnimation("ការ Backup បានសម្រេច").ShowDialog();
            }
        }

        private void aboutAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Information.About_Software().ShowDialog();
        }

        private void creatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Information.About_Us().ShowDialog();
        }

        private void usageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/dmvelocity");
        }

        private void payPalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.paypal.me/cseakmeng/1");
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void shareMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("http://bit.ly/2Ik2dSE");
            label1.Show();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Hide();
            timer1.Stop();
        }

        #endregion

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                switch (e.KeyCode) {
                    case Keys.D1:
                        btnHome.PerformClick();
                        break;
                    case Keys.D2:
                        btnView.PerformClick();
                        break;
                    case Keys.D3:
                        btnGrade.PerformClick();
                        break;
                    case Keys.D4:
                        btnAbsence.PerformClick();
                        break;
                    case Keys.D5:
                        btnTotalAbsence.PerformClick();
                        break;
                    case Keys.A:
                        view.btnAdd.PerformClick();
                        break;
                    case Keys.U:
                        view.btnUpdate.PerformClick();
                        break;
                    case Keys.D:
                        view.btnDelete.PerformClick();
                        break;
                    case Keys.S when btnAbsence.ForeColor == Color.White:
                        absence.btnSave.PerformClick();
                        break;
                    case Keys.S when btnGrade.ForeColor == Color.White:
                        score.btnSetScore.PerformClick();
                        break;

                }
            }
            else if (e.Modifiers == Keys.Alt) {
                if (e.KeyCode == Keys.F4)
                    picExit_Click(sender, e);
            }


        }

        private void bunifuGradientPanel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }    

    }

}
