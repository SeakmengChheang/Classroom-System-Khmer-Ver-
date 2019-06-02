using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Classroom_Project__Win_Form_.Properties;

namespace Classroom_Project__Win_Form_.User_Controls
{
    public partial class TeacherInfomations : Form
    {
        public TeacherInfomations()
        {
            InitializeComponent();
        }

        private string fileName = "";
        private string imagePath = frmMain.FilePath + "\\Teacher Info\\";

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                picTeacher.Image.Dispose();
                picTeacher.Image = new Bitmap(openImage.FileName);
                fileName = openImage.SafeFileName;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("តើអ្នកពិតជាចង់រក្សាទុកមែនទេ?", "ព្រមាន", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;

            bool numOfScoreWasChanged = Settings.Default.NumOfScore != comboNumOfScore.SelectedIndex + 1;

            if (numOfScoreWasChanged && Settings.Default.TeacherName != "") {
                DialogResult dr1 = MessageBox.Show("ការផ្លាស់ប្តូរចំនួនមុខវិជ្ចានឹងធ្វើឲ្យទិន្នន័យពិន្ទុសិស្សទាំងអស់ត្រូវបាត់???", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr1 == DialogResult.No)
                    return;
            }

            //When pic remains the "attempt to change then same || change"
            if (fileName != "")
            {
                //Delete if OLD pic EXISTS and Copy NEW pic to avoid "change the same" problem below
                if (File.Exists(imagePath + Settings.Default.ImageTeacherName))
                    File.Delete(imagePath + Settings.Default.ImageTeacherName);
                if (!Directory.Exists(frmMain.FilePath + "\\Teacher Info"))
                    Directory.CreateDirectory(frmMain.FilePath + "\\Teacher Info");
                //

                File.Copy(openImage.FileName, imagePath + fileName, true);
                Settings.Default.ImageTeacherName = fileName;
            }

            Settings.Default.TeacherName = txtTeacherName.Text;
            Settings.Default.Class = txtClass.Text;
            Settings.Default.NumOfScore = comboNumOfScore.SelectedIndex + 1;

            //! if NumofScore was changed open to Set them again
            if (numOfScoreWasChanged)
            {
                var listStudents = frmMain.ListStudents;
                foreach (var student in listStudents)
                {
                    for (int i = 0; i < student.Score.Length; i++)
                        student.Score[i] = 0;
                }

                this.Hide();
                //Open to Set NEW Subject Names becoz there was a change on NumOfScore
                new SetNameSubjects().ShowDialog();
                this.Close();
            }
            //! if NOT save all and close the T.I Form
            else
            {
                new Animation.msgBoxTickAnimation("រក្សាទុកបានជោគជ័យ").ShowDialog();
                this.Close();
            }

        }

        private void TeacherInfo_Load(object sender, EventArgs e)
        {

            //Select Year Start in NOW becoz there is a new TEACHER
            if (Settings.Default.TeacherName != "")
            {
                txtTeacherName.Text = Settings.Default.TeacherName;
                txtClass.Text = Settings.Default.Class;
                comboNumOfScore.SelectedIndex = Settings.Default.NumOfScore - 1;

                if (File.Exists(imagePath + Settings.Default.ImageTeacherName))
                    picTeacher.Image = new Bitmap(imagePath + Settings.Default.ImageTeacherName);
                else
                    picTeacher.Image = Resources.Teacher;
            }
            //
        }

    }
}
