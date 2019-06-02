using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Classroom_Project__Win_Form_.User_Controls
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            
        }

        private void picReadMe_Click(object sender, EventArgs e)
        {
            Process.Start("Read Me.txt");
        }

        private void linkReadMe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picReadMe_Click(sender, e);
        }

        private void linkPrivacy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("Privacy and Policy.txt");
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("Privacy and Policy.txt");
        }

        private void linkLicence_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("Licence.txt");
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("Licence.txt");
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
