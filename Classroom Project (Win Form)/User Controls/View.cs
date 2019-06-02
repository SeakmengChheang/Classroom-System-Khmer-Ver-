using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Classroom_Project__Win_Form_.User_Controls
{
    public partial class View : UserControl
    {
        public View()
        {
            InitializeComponent();
            dgrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgrid.ColumnHeadersDefaultCellStyle.Font = new Font("Khmer OS Muol Light", 14F);
            DataGridView_DoubleBuffered.DoubleBuffered(dgrid, true);
        }

        Student objStudent;
        public static int IndexUpdate;
        void FromListToGrid()
        {
            foreach (var student in frmMain.ListStudents)
            {
                //Image imageSex;

                //if (student.Sex == "ប្រុស")
                //    imageSex = Properties.Resources.Male;
                //else
                //    imageSex = Properties.Resources.Female;

                dgrid.Rows.Add(student.Id, student.FirstName, student.LastName, student.Sex, student.DOB, student.PhoneNumber);
                
            }
        }
        void FromListToFile()
        {
            string filePath = frmMain.FilePath;
            File.Create(filePath + @"\Database.txt").Close();
            frmMain.ListStudents = frmMain.ListStudents.OrderBy(x => x.Id).ToList();

            foreach (var student in frmMain.ListStudents)
            {
                string allQuizWithLine = null;
                for (int i = 0; i < student.Score.Length; i++)
                    allQuizWithLine += student.Score[i] + "|";

                //! TOREMOVE last "|" with already has in string DATA
                allQuizWithLine = allQuizWithLine.Remove(allQuizWithLine.Length - 1);

                string data = $"{student.Id}|{student.FirstName}|{student.LastName}|{student.Sex}|{student.DOB}|{student.PhoneNumber}|{allQuizWithLine}" + Environment.NewLine;
                File.AppendAllText(filePath + @"\Database.txt", data);
            }
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAnother:
            new View_Add().ShowDialog();
            if (View_Add.addSucceed)
            {
                string[] dataFromAdd = View_Add.data;

                objStudent = new Student
                {
                    Id = int.Parse(dataFromAdd[0]),
                    FirstName = dataFromAdd[1],
                    LastName = dataFromAdd[2],
                    Sex = dataFromAdd[3],
                    DOB = dataFromAdd[4],
                    PhoneNumber = dataFromAdd[5]
                };

                frmMain.ListStudents.Add(objStudent);
                Directory.CreateDirectory(frmMain.FilePath + $"\\Absence\\{objStudent.Id}");

                View_Add.addSucceed = false;
                dgrid.Rows.Clear();
                FromListToGrid();

                //Reload to give user a better experience to add more students
                goto AddAnother;
            }

            dgrid.Sort(dgrid.Columns[0], ListSortDirection.Ascending);
            frmMain.ListStudents = frmMain.ListStudents.OrderBy(x => x.Id).ToList();

            //FromListToFile();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int rowUpdate = dgrid.CurrentCell.RowIndex;
                int idUpdate = int.Parse(dgrid[0, rowUpdate].Value.ToString());
                IndexUpdate = frmMain.ListStudents.FindIndex(x => x.Id == idUpdate);

                new View_Update().ShowDialog();
                if (View_Update.updatedSucceed)
                {
                    dgrid[0, rowUpdate].Value = frmMain.ListStudents[IndexUpdate].Id;
                    dgrid[1, rowUpdate].Value = frmMain.ListStudents[IndexUpdate].FirstName;
                    dgrid[2, rowUpdate].Value = frmMain.ListStudents[IndexUpdate].LastName;
                    //Image imageSex = frmMain.ListStudents[IndexUpdate].Sex == "ប្រុស" ? Properties.Resources.Male : Properties.Resources.Female;
                    dgrid[3, rowUpdate].Value = frmMain.ListStudents[IndexUpdate].Sex;
                    dgrid[4, rowUpdate].Value = frmMain.ListStudents[IndexUpdate].DOB;
                    dgrid[5, rowUpdate].Value = frmMain.ListStudents[IndexUpdate].PhoneNumber;

                    //FromListToFile();
                    View_Update.updatedSucceed = false;
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgrid.SelectedRows.Count == 0)
                return;

            DialogResult dialog = MessageBox.Show("តើអ្នកពិតជាចង់លុបមែនទេ?", "បញ្ចាក់", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
                return;

            try
            {
                for (int i = 0; i < dgrid.SelectedRows.Count; i++) {
                    int idStudent = (int)dgrid[0, dgrid.SelectedRows[i].Index].Value;

                    int indexStudent = frmMain.ListStudents.FindIndex(x => x.Id == idStudent);
                    frmMain.ListStudents.RemoveAt(indexStudent);

                    string absenceFolderThisId = frmMain.FilePath + $"\\Absence\\{idStudent}";
                    if (Directory.Exists(absenceFolderThisId))
                        Directory.Delete(absenceFolderThisId, true);
                }

                dgrid.Rows.Clear();
                FromListToGrid();

                //FromListToFile();
                new Animation.msgBoxTickAnimation("ការលុបជោគជ័យ :)").ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ការលុបបរាជ័យ :(\n{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void View_Load(object sender, EventArgs e)
        {
            dgrid.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(210, 231, 244);
        }

        private void View_Enter(object sender, EventArgs e)
        {
            if (frmMain.ListStudents.Count != dgrid.RowCount) {
                dgrid.Rows.Clear();
                FromListToGrid();
            }
        }

    }
}
