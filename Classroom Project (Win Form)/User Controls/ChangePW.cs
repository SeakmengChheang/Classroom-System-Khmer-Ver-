using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classroom_Project__Win_Form_.User_Controls
{
    public partial class ChangePW : Form
    {
        public ChangePW()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("តើអ្នកពិតជាចង់ផ្លាស់ប្តូរមែនទេ?", "បញ្ចាក់",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;

            if(txtUserName.Text == Properties.Settings.Default.Username && txtPassword.Text == Properties.Settings.Default.Password)
            {
                Properties.Settings.Default.Password = txtNewPW.Text;
                Properties.Settings.Default.Save();
                new Animation.msgBoxTickAnimation("ការផ្លាស់ប្តូរបានសម្រេច").ShowDialog();
                this.Close();
            }
        }

        private void txtNewPWAg_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPW.Text != txtNewPWAg.Text)
            {
                txtNewPWAg.ForeColor = Color.Red;
                errorPW.SetError(txtNewPWAg, "លេខសំងាត់មិនដូចគ្នា");
                btnChange.Enabled = false;
            }
            else
            {
                txtNewPWAg.ForeColor = Color.Black;
                errorPW.Clear();
                btnChange.Enabled = true;
            }
        }
    }
}
