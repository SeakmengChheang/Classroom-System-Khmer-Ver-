using System;
using System.Windows.Forms;

namespace Classroom_Project__Win_Form_.Animation
{
    public partial class msgBoxTickAnimation : Form
    {
        public msgBoxTickAnimation(string labelMsg = "ប្រតិបត្តិការសម្រេច")
        {
            InitializeComponent();
            label1.Text = labelMsg;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void msgBoxTickAnimation_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer1.Start();
            timerClose.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.5)
                label1.Show();

            if (this.Opacity > 0.7)
                btnOk.Show();

            if (this.Opacity < 1)
                this.Opacity += 0.02;
            else
                timer1.Stop();

        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            timerClose.Stop();
            this.Close();
        }

        private void msgBoxTickAnimation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOk_Click(sender, e);
        }
    }
}
