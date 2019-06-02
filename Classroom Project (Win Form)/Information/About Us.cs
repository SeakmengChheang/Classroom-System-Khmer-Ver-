using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classroom_Project__Win_Form_.Information
{
    public partial class About_Us : MetroFramework.Forms.MetroForm
    {
        public About_Us()
        {
            InitializeComponent();
        }

        private void linkDonation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!panelDonation.Visible)
                Transition.ShowSync(panelDonation);
            else
                Transition.HideSync(panelDonation);
        }

        private void picQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picYoutube_Click(object sender, EventArgs e) {
            Process.Start("https://www.youtube.com/channel/UCCViFHnPq_IQV5eQTbjVu1A");
        }

        private void linkPayPal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.paypal.me/cseakmeng/1");
        }

        private void picFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/dmvelocity");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
