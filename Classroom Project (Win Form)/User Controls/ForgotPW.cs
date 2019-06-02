using System;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;

namespace Classroom_Project__Win_Form_.User_Controls
{
    public partial class ForgotPw : Form
    {
        public ForgotPw()
        {
            InitializeComponent();
        }

        void SendMail()
        {
            string password = Properties.Settings.Default.Password;
            Random r = new Random();
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                backgroundWorker.ReportProgress(r.Next(0, 10));
                Thread.Sleep(100);
                client.EnableSsl = true;
                backgroundWorker.ReportProgress(r.Next(10, 25));
                Thread.Sleep(100);
                client.Timeout = 5000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                backgroundWorker.ReportProgress(r.Next(25, 35));
                Thread.Sleep(100);
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("mld.non.profit@gmail.com", "nonprofit123");
                backgroundWorker.ReportProgress(r.Next(35, 50));
                Thread.Sleep(100);

                MailMessage msg = new MailMessage("mld.non.profit@gmail.com", txtEmail.Text);
                backgroundWorker.ReportProgress(r.Next(50, 65));
                Thread.Sleep(100);
                msg.Priority = MailPriority.High;
                msg.Subject = "ភ្លេចលេខសំងាត់";
                backgroundWorker.ReportProgress(r.Next(70, 80));
                Thread.Sleep(100);
                msg.Body = $"លេខសំងាត់របស់អ្នកគឺ ៖ {password}\nសូមអរគុណដែលបានប្រើប្រាស់កម្មវិធីរបស់យើងខ្ញុំ";
                backgroundWorker.ReportProgress(r.Next(80, 95));
                client.Send(msg);
                backgroundWorker.ReportProgress(100);
                Thread.Sleep(500);
                //MessageBox.Show("លេខសំងាត់ត្រូវបានផ្ញើចូល Email របស់អ្នករួចរាល់", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Animation.msgBoxTickAnimation("លេខសំងាត់ត្រូវបានផ្ញើចូល Email របស់អ្នករួចរាល់").ShowDialog();
            }
            catch (Exception)
            {
                //MessageBox.Show("ការផ្ញើមិនបានសម្រេច ដោយសារកំហុសបច្ចេកទេស ឬប្រព័ន្ធអ៊ីនធើណេត។", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                new Animation.msgBoxErrorAnimation("ការផ្ញើមិនបានសម្រេច ដោយសារកំហុសបច្ចេកទេស ឬប្រព័ន្ធអ៊ីនធើណេត។").ShowDialog();
            }
        }

        private void btnSendPW_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == Properties.Settings.Default.Username && txtEmail.Text == Properties.Settings.Default.Email)
            {
                metroProgressBar.Show();
                backgroundWorker.RunWorkerAsync();
            }
            else
            {
                //MessageBox.Show("ឈ្មោះអ្នកប្រើ និង Email គ្មាននៅក្នុងបណ្តាញ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                new Animation.msgBoxErrorAnimation("ឈ្មោះអ្នកប្រើ និង Email គ្មាននៅក្នុងបណ្តាញ").ShowDialog();
            }
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            SendMail();
        }

        private void backgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            metroProgressBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            metroProgressBar.Hide();
            if (metroProgressBar.Value == 100)
                this.Close();
        }
    }
}
