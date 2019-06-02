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
    public partial class View_Update : MetroFramework.Forms.MetroForm
    {
        public View_Update()
        {
            InitializeComponent();
        }
        public static string updatedData;
        public static bool updatedSucceed;
        List<Student> listStudents = frmMain.ListStudents;
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

        private void View_Update_Load(object sender, EventArgs e)
        {
            AddDays();
            AddMonths();
            AddYears();

            //Display INFO from View
            int indexUpdate = View.IndexUpdate;
            txtID.Text = listStudents[indexUpdate].Id.ToString();
            txtFirstName.Text = listStudents[indexUpdate].FirstName;
            txtLastName.Text = listStudents[indexUpdate].LastName;
            comboSex.SelectedItem = listStudents[indexUpdate].Sex;
            string[] dob = listStudents[indexUpdate].DOB.Split('-');
            comboDay.SelectedIndex = int.Parse(dob[0]) - 1;
            comboMonth.SelectedIndex = int.Parse(dob[1]) - 1;
            comboYear.SelectedItem = int.Parse(dob[2]);
            txtPhoneNumber.Text = listStudents[indexUpdate].PhoneNumber;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("តើអ្នកពិតជាកែមែនទេ?", "បញ្ចាក់", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
                return;

            int indexUpdate = View.IndexUpdate;

            int idFromInput = int.Parse(txtID.Text);
            int findIndex = listStudents.FindIndex(x => x.Id == idFromInput);
            if (!(findIndex < 0 || findIndex == indexUpdate))
            {
                new Animation.msgBoxErrorAnimation("លេខសម្គាល់មានរួចហើយ \nសូមបញ្ចូលម្តងទៀត").Show();
                return;
            }

            listStudents[indexUpdate].Id = idFromInput;
            listStudents[indexUpdate].FirstName = txtFirstName.Text;
            listStudents[indexUpdate].LastName = txtLastName.Text;
            listStudents[indexUpdate].Sex = comboSex.SelectedItem.ToString();
            listStudents[indexUpdate].DOB = $"{comboDay.SelectedItem}-{comboMonth.SelectedItem}-{comboYear.SelectedItem}";
            listStudents[indexUpdate].PhoneNumber = txtPhoneNumber.Text;

            updatedSucceed = true;
            new Animation.msgBoxTickAnimation("ការកែប្រែបានជោគជ័យ :)").Show();
            this.Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
