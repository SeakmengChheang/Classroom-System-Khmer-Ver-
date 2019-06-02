using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classroom_Project__Win_Form_.User_Controls
{
    public partial class CreateNewUsername : Form
    {
        public CreateNewUsername()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //! Check Condition before proceed
            if (txtUserName.Text == "ឈ្មោះគណនី" || 
                txtPassword.Text == "លេខសំងាត់" || 
                txtEmail.Text == "Email" ||
                txtPassword.Text != txtPWAgain.Text ||
                txtEmail.Text != txtMailAgain.Text)
            {
                new Animation.msgBoxErrorAnimation("ទិន្នន័យមិនគ្រប់គ្រាន់ សូមបញ្ចូលទិន្នន័យឲ្យបានគ្រប់គ្រាន់").ShowDialog();
                return;
            }

            if (!txtEmail.Text.Contains('@') || !txtEmail.Text.Contains('.'))
            {
                new Animation.msgBoxErrorAnimation("Email Address មិនត្រឹមត្រូវ").ShowDialog();
                return;
            }
            //

            //!Set everything to default
            // Teacher INFO
            Properties.Settings.Default.NumOfScore = 0;
            Properties.Settings.Default.TeacherName = "";
            Properties.Settings.Default.Subjects[0] = "N/A";
            Properties.Settings.Default.Class = "";
            Properties.Settings.Default.RememberUserChecked = false;
            // Username INFO
            Properties.Settings.Default.Username = txtUserName.Text;
            Properties.Settings.Default.Password = txtPassword.Text;
            Properties.Settings.Default.Email = txtEmail.Text;
            Properties.Settings.Default.RememberUserChecked = false;

            if (File.Exists(frmMain.FilePath + "\\Database.txt"))
                File.Delete(frmMain.FilePath + "\\Database.txt");
            if (Directory.Exists(frmMain.FilePath + "\\Absence"))
                Directory.Delete(frmMain.FilePath + "\\Absence", true);

            this.Hide();
            new TeacherInfomations().ShowDialog();
            this.Close();
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if(txtUserName.Text == "ឈ្មោះគណនី")
            {
                txtUserName.Clear();
                txtUserName.ForeColor = Color.Black;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if(txtUserName.Text == "")
            {
                txtUserName.Text = "ឈ្មោះគណនី";
                txtUserName.ForeColor = Color.DarkGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if(txtPassword.Text == "លេខសំងាត់")
            {
                txtPassword.Clear();
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if(txtPassword.Text == "")
            {
                txtPassword.Text = "លេខសំងាត់";
                txtPassword.ForeColor = Color.DarkGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtPWAgain_Enter(object sender, EventArgs e)
        {
            if(txtPWAgain.Text == "លេខសំងាត់ម្តងទៀត")
            {
                txtPWAgain.Clear();
                txtPWAgain.ForeColor = Color.Black;
                txtPWAgain.UseSystemPasswordChar = true;
            }
        }

        private void txtPWAgain_Leave(object sender, EventArgs e)
        {
            if(txtPWAgain.Text == "")
            {
                txtPWAgain.Text = "លេខសំងាត់ម្តងទៀត";
                txtPWAgain.ForeColor = Color.DarkGray;
                txtPWAgain.UseSystemPasswordChar = false;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if(txtEmail.Text == "Email")
            {
                txtEmail.Clear();
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if(txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.DarkGray;
            }
        }

        private void txtMailAgain_Enter(object sender, EventArgs e)
        {
            if(txtMailAgain.Text == "Email ម្តងទៀត")
            {
                txtMailAgain.Clear();
                txtMailAgain.ForeColor = Color.Black;
            }
        }

        private void txtMailAgain_Leave(object sender, EventArgs e)
        {
            if(txtMailAgain.Text == "")
            {
                txtMailAgain.Text = "Email ម្តងទៀត";
                txtMailAgain.ForeColor = Color.DarkGray;
            }
        }
    }
}
