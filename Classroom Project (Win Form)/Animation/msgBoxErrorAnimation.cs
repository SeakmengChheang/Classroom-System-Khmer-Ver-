using System;
using System.Windows.Forms;

namespace Classroom_Project__Win_Form_.Animation
{
    public partial class msgBoxErrorAnimation : Form
    {
        public msgBoxErrorAnimation(string condition = "ប្រតិបត្តិការបរាជ័យ")
        {
            InitializeComponent();
            label1.Text = condition;
            
        }

        private int i = 0;
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (i % 2 == 0)
            {
                this.Left += 5;
                i++;
            }
            else
            {
                this.Left -= 5;
                i++;
            }

            if (i == 6)
                timer.Stop();
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void msgBoxErrorAnimation_Load(object sender, EventArgs e)
        {
            timer.Start();
            timerClose.Start();
        }

        private void msgBoxErrorAnimation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOk_Click(sender, e);
        }
    }
}
