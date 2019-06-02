using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classroom_Project__Win_Form_.Properties;

namespace Classroom_Project__Win_Form_
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
            new Animation.Logo_Splash().ShowDialog();

            if (!File.Exists(filePath))
                Directory.CreateDirectory(filePath);
            if (File.Exists(filePath + "\\Info.txt")) {
                TranslateInfoProcess();
                if (Settings.Default.RememberUserChecked)
                {
                    txtUserName.Text = Settings.Default.Username;
                    checkRememberUserName.CheckState = CheckState.Checked;
                    txtPassword.Select();
                }
            } else {
                File.Create(filePath + "\\Info.txt").Close();
                this.Hide();
                new Animation.Welcome_Page().ShowDialog();
                Settings.Default.FirstRunning = false;
                this.Show();
                new User_Controls.CreateNewUsername().ShowDialog();
            }
            
        }

        private string filePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Classroom System";
        private string hash = "Khmer D'M Info 锡明";

        void TranslateInfoProcess()
        {
            string data = File.ReadAllText(filePath + "\\Info.txt");

            if (data != "")
            {
                string result = Decryption(data);
                string[] splitResult = result.Split('\n');

                //! Username=... so we just need the right data
                string[] wantedData = new string[splitResult.Length];
                for (int i = 0; i < wantedData.Length; i++)
                {
                    string[] temp = splitResult[i].Split('=');
                    wantedData[i] = temp[1];
                }

                Settings.Default.Username            = wantedData[0];
                Settings.Default.Password            = wantedData[1];
                Settings.Default.Email               = wantedData[2];
                Settings.Default.RememberUserChecked = bool.Parse(wantedData[3]);
                Settings.Default.FirstRunning        = bool.Parse(wantedData[4]);
                Settings.Default.BackupPath          = wantedData[5];
                Settings.Default.TeacherName         = wantedData[6];
                Settings.Default.ImageTeacherName    = wantedData[7];
                Settings.Default.Class               = wantedData[8];
                Settings.Default.NumOfScore          = int.Parse(wantedData[9]);
                string[] nameSubjects                = wantedData[10].Split('|');
                Settings.Default.Subjects.Clear();
                Settings.Default.Subjects.AddRange(nameSubjects);
            }

        }

        void WriteInfoIntoFile()
        {
            StringBuilder data = new StringBuilder();
            data.Append("Username="         + Settings.Default.Username            + "\n");
            data.Append("Password="         + Settings.Default.Password            + "\n");
            data.Append("Email="            + Settings.Default.Email               + "\n");
            data.Append("RememberUsername=" + Settings.Default.RememberUserChecked + "\n");
            data.Append("FirstRunning="     + Settings.Default.FirstRunning        + "\n");
            data.Append("BackupPath="       + Settings.Default.BackupPath          + "\n");
            data.Append("TeacherName="      + Settings.Default.TeacherName         + "\n");
            data.Append("ImageTeacherName=" + Settings.Default.ImageTeacherName    + "\n");
            data.Append("Class="            + Settings.Default.Class               + "\n");
            data.Append("NumOfScore="       + Settings.Default.NumOfScore          + "\n");

            StringBuilder subjectsName = new StringBuilder();
            for (int i = 0; i < Settings.Default.Subjects.Count; i++)
                subjectsName.Append(Settings.Default.Subjects[i] + "|");
            subjectsName.Remove(subjectsName.Length - 1, 1);

            data.Append("SubjectsName=" + subjectsName);

            string result = Encryption(data.ToString());

            File.WriteAllText(filePath + "\\Info.txt", result);
        }

        string Encryption(string normalWord)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(normalWord);
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

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == Settings.Default.Username && txtPassword.Text == Settings.Default.Password)
            {
                this.Hide();
                new frmMain().ShowDialog();

                txtPassword.Text = "";
                if (Settings.Default.RememberUserChecked) {
                    txtUserName.Text = Settings.Default.Username;
                    txtPassword.Select();
                }
                else {
                    txtUserName.Text = "";
                    txtUserName.Select();
                }

                if(!this.IsDisposed)
                    this.Show();
            }
            else if(txtUserName.Text == Settings.Default.Username)
                MessageBox.Show("ការបញ្ចូលលេខសំងាត់ខុស\nសូមផ្ទៀងផ្ទាត់ម្តងទៀត", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("គ្មានអ្នកប្រើប្រាស់នេះទេ\nសូមផ្ទៀងផ្ទាត់ម្តងទៀត", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void checkShowPW_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPW.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '\u25CF'; //'●'
        }

        private void linkForgotPw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new User_Controls.ForgotPw().ShowDialog();
        }

        private void linkCreateNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new User_Controls.CreateNewUsername().ShowDialog();
        }

        private void linkChangePw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new User_Controls.ChangePW().ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            if (!Directory.Exists(filePath + "\\Absence"))
                Directory.CreateDirectory(filePath + "\\Absence");
            if (!Directory.Exists(filePath + "\\Teacher Info"))
                Directory.CreateDirectory(filePath + "\\Teacher Info");
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteInfoIntoFile();
        }

        private void btnSignIn_MouseEnter(object sender, EventArgs e)
        {
            btnSignIn.ForeColor = Color.White;
            btnSignIn.BackColor = Color.DarkGray;
        }

        private void btnSignIn_MouseLeave(object sender, EventArgs e)
        {
            btnSignIn.ForeColor = Color.MediumBlue;
            btnSignIn.BackColor = Color.Transparent;
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;
            pictureBox1.Width += 5;
            pictureBox1.Height += 5;
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
            pictureBox1.Width -= 5;
            pictureBox1.Height -= 5;
        }

        private void panel2_Enter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
            pictureBox2.Width += 5;
            pictureBox2.Height += 5;
        }

        private void panel2_Leave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Blue;
            pictureBox2.Width -= 5;
            pictureBox2.Height -= 5;
        }

        private void picQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkRememberUserName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRememberUserName.Checked)
                Settings.Default.RememberUserChecked = true;
            else
                Settings.Default.RememberUserChecked = false;
        }
    }
}
