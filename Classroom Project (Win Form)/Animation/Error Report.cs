using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classroom_Project__Win_Form_.Animation
{
    public partial class Error_Report : Form
    {
        public Error_Report()
        {
            InitializeComponent();
        }

        void SendMail()
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.Timeout = 10000;
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Credentials = new NetworkCredential(Properties.Settings.Default.InnerEmail, Properties.Settings.Default.InnerPwEmail);

                MailMessage msg = new MailMessage();
                msg.Subject = "Errors Log Report";
                msg.From = new MailAddress(Properties.Settings.Default.InnerEmail);
                msg.To.Add("fernandoqry@gmail.com");
                msg.Attachments.Add(new Attachment(frmMain.FilePath + "\\errors.log"));
                client.Send(msg);
                msg.Dispose();
                File.Delete(frmMain.FilePath + "\\errors.log");
            }
            catch (Exception)
            {
                new msgBoxErrorAnimation("ការរាយការណ៏មិនបានសម្រេច ដោយសារកំហុសបច្ចេកទេស ឬប្រព័ន្ធអ៊ីនធើណេត។").ShowDialog();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            pictureBox2.Show();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            pictureBox1.Hide();
            backgroundWorker.RunWorkerAsync();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            SendMail();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Application.Exit();
        }
    }
}
