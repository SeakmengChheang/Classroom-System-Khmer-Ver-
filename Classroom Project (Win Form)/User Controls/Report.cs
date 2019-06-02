using System;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace Classroom_Project__Win_Form_.User_Controls
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        void SendMail()
        {
            Random r = new Random();
            try
            {
                // Make thread sleep to make it looks more natural or logical
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                backgroundWorker.ReportProgress(r.Next(0, 10));
                Thread.Sleep(100);
                client.Timeout = 5000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                backgroundWorker.ReportProgress(r.Next(10, 21));
                Thread.Sleep(100);
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(Properties.Settings.Default.InnerEmail, Properties.Settings.Default.InnerPwEmail);
                backgroundWorker.ReportProgress(r.Next(21, 35));
                Thread.Sleep(100);

                MailMessage msg = new MailMessage();
                backgroundWorker.ReportProgress(r.Next(35, 51));
                Thread.Sleep(100);
                msg.To.Add("fernandoqry@gmail.com");
                backgroundWorker.ReportProgress(r.Next(51, 60));
                Thread.Sleep(100);
                msg.From = new MailAddress(Properties.Settings.Default.InnerEmail);
                msg.Subject = txtSubject.Text;
                backgroundWorker.ReportProgress(r.Next(60, 65));
                Thread.Sleep(100);
                msg.Body = txtBody.Text;
                backgroundWorker.ReportProgress(r.Next(65, 80));
                Thread.Sleep(100);
                backgroundWorker.ReportProgress(r.Next(80, 92));
                client.Send(msg);
                backgroundWorker.ReportProgress(100);
                Thread.Sleep(500);
                new Animation.msgBoxTickAnimation("ការរាយការណ៏បានសម្រេច\nសូមអរគុណដែលបានចូលរួមសហការ").ShowDialog();
            }
            catch (Exception)
            {
                new Animation.msgBoxErrorAnimation("ការរាយការណ៏មិនបានសម្រេច ដោយសារកំហុសបច្ចេកទេស ឬប្រព័ន្ធអ៊ីនធើណេត។")
                    .ShowDialog();
            }

        }
        private void btnSendMail_Click(object sender, EventArgs e)
        {
            metroProgressBar.Show();
            backgroundWorker.RunWorkerAsync();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            SendMail();
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            metroProgressBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroProgressBar.Hide();
            if (metroProgressBar.Value == 100)
                this.Close();
        }
    }
}
