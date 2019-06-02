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
    public partial class View_Add : MetroFramework.Forms.MetroForm
    {
        public View_Add()
        {
            InitializeComponent();
        }
        public static string[] data;
        public static bool addSucceed;
        void clearAll()
        {
            txtID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNumber.Clear();

            comboSex.SelectedIndex = 0;
            comboDay.SelectedIndex = DateTime.Now.Day - 1;
            comboMonth.SelectedIndex = DateTime.Now.Month - 1;
            comboYear.SelectedIndex = 100;
        }
        bool duplicateID(int ID)
        {
            int index = frmMain.ListStudents.FindIndex(x => x.Id == ID);
            return index >= 0;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("តើអ្នកពិតជាចង់បន្ថែមឈ្មោះសិស្សមែនទេ?", "បញ្ចាក់", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
                return;

            if (txtID.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "")
            {
                new Animation.msgBoxErrorAnimation("អ្នកត្រូវប្រាកដថាប្រអប់ លេខ ត្រកូល និងឈ្មោះ មានទិន្នន័យ")
                    .ShowDialog();
                return;
            }

            if (duplicateID(int.Parse(txtID.Text)))
            {
                new Animation.msgBoxErrorAnimation("ID មានរួចហើយ").ShowDialog();
                txtID.Focus();
                txtID.SelectAll();
                return;
            }

            txtFirstName.Text = txtFirstName.Text.Trim();
            txtLastName.Text = txtLastName.Text.Trim();

            data = new string[6];
            data[0] = txtID.Text;
            data[1] = txtFirstName.Text;
            data[2] = txtLastName.Text;
            data[3] = comboSex.SelectedItem.ToString();
            data[4] = $"{comboDay.SelectedItem}-{comboMonth.SelectedItem}-{comboYear.SelectedItem}";
            data[5] = txtPhoneNumber.Text;

            addSucceed = true;
            new Animation.msgBoxTickAnimation("ការបន្ថែមបានជោគជ័យ :)").ShowDialog();
            this.Close();
        }
        void AddYears()
        {
            comboYear.Items.Clear();
            int presentYear = DateTime.Now.Year;
            int canSelect = presentYear - 100;
            for (int i = canSelect; i <= presentYear; i++)
                comboYear.Items.Add(i);
        }
        void AddMonths()
        {
            comboMonth.Items.Clear();
            for (int i = 1; i <= 12; i++)
                comboMonth.Items.Add(i.ToString("00"));
        }
        void AddDays()
        {
            comboDay.Items.Clear();
            for (int i = 1; i <= 31; i++)
                comboDay.Items.Add(i.ToString("00"));
        }
        private void View_Add_Load(object sender, EventArgs e)
        {
            AddDays();
            AddMonths();
            AddYears();

            comboSex.SelectedIndex = 0;
            comboDay.SelectedIndex = DateTime.Now.Day - 1;
            comboMonth.SelectedIndex = DateTime.Now.Month - 1;
            comboYear.SelectedIndex = 100;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtID.Text);
                errorId.Clear();
                btnConfirm.Enabled = true;
            }
            catch (Exception)
            {
                errorId.SetError(txtID, "លេខសម្គាល់អាចដាក់បានតែលេខប៉ុណ្ណោះ។\nEx: 19288");
                btnConfirm.Enabled = false;
            }
        }
    }
}
