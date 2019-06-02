using System;
using System.Collections.Specialized;
using System.IO;
using System.Windows.Forms;

namespace Classroom_Project__Win_Form_.User_Controls
{
    public partial class SetNameSubjects : Form
    {
        public SetNameSubjects()
        {
            InitializeComponent();
        }

        int confirmClick = 0;
        string[] subjects = new string[Properties.Settings.Default.NumOfScore];

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //! Sometimes users press ENTER key by accidentally with NOTHING input
            //Solve above problem
            if(txtSubject.Text == "")
            {
                new Animation.msgBoxErrorAnimation("ឈ្មោះតារាងពិន្ទុទទេ សូមបញ្ចូលម្តងទៀត").ShowDialog();
                return;
            }
            else
            {
                subjects[confirmClick] = txtSubject.Text;
                confirmClick++;
                lblSubject.Text = $"តារាងពិន្ទុទី{confirmClick + 1} ៖";
                txtSubject.Clear();
            }

            if (confirmClick == Properties.Settings.Default.NumOfScore)
            {
                Properties.Settings.Default.Subjects = new StringCollection();
                Properties.Settings.Default.Subjects.AddRange(subjects);

                new Animation.msgBoxTickAnimation("ការបញ្ចូលទាំងអស់បានសម្រេច").ShowDialog();
                //Restart Application to ensure that EVERYTHING is updated
                Application.Restart();
            }

            
        }


    }
}
