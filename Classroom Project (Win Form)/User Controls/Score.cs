using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using Classroom_Project__Win_Form_.Properties;

namespace Classroom_Project__Win_Form_.User_Controls
{
    public partial class Score : UserControl
    {
        public Score()
        {
            InitializeComponent();
            dgrid.DefaultCellStyle.NullValue = 0;
            dgrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgrid.ColumnHeadersDefaultCellStyle.Font = new Font("Khmer OS Muol Light", 14F);
            DataGridView_DoubleBuffered.DoubleBuffered(dgrid, true);
            dgrid.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(210, 231, 244);
          
        }

        void AddRowDependOnQuizColumns(int numOfQuizCol)
        {
            switch (numOfQuizCol)
            {
                case 1:
                    foreach (var student in frmMain.ListStudents)
                    {
                        //Image imageSex = student.Sex == "ប្រុស" ? Resources.Male : Resources.Female;

                        dgrid.Rows.Add(student.Id, $"{student.FirstName} {student.LastName}", student.Sex, student.Score[0], student.Total);
                    }
                    break;
                case 2:
                    foreach (var student in frmMain.ListStudents)
                    {
                        //Image imageSex = student.Sex == "ប្រុស" ? Resources.Male : Resources.Female;

                        dgrid.Rows.Add(student.Id, $"{student.FirstName} {student.LastName}", student.Sex, student.Score[0], student.Score[1], student.Total);
                    }
                    break;
                case 3:
                    foreach (var student in frmMain.ListStudents)
                    {
                        //Image imageSex = student.Sex == "ប្រុស" ? Resources.Male : Resources.Female;

                        dgrid.Rows.Add(student.Id, $"{student.FirstName} {student.LastName}", student.Sex, student.Score[0], student.Score[1], student.Score[2], student.Total);
                    }
                    break;
                case 4:
                    foreach (var student in frmMain.ListStudents)
                    {
                        //Image imageSex = student.Sex == "ប្រុស" ? Resources.Male : Resources.Female;

                        dgrid.Rows.Add(student.Id, $"{student.FirstName} {student.LastName}", student.Sex, student.Score[0], student.Score[1], student.Score[2], student.Score[3], student.Total);
                    }
                    break;
                case 5:
                    foreach (var student in frmMain.ListStudents)
                    {
                        //Image imageSex = student.Sex == "ប្រុស" ? Resources.Male : Resources.Female;

                        dgrid.Rows.Add(student.Id, $"{student.FirstName} {student.LastName}", student.Sex, student.Score[0], student.Score[1], student.Score[2], student.Score[3], student.Score[4], student.Total);
                    }
                    break;
                case 6:
                    foreach (var student in frmMain.ListStudents)
                    {
                        //Image imageSex = student.Sex == "ប្រុស" ? Resources.Male : Resources.Female;

                        dgrid.Rows.Add(student.Id, $"{student.FirstName} {student.LastName}", student.Sex, student.Score[0], student.Score[1], student.Score[2], student.Score[3], student.Score[4], student.Score[5], student.Total);
                    }
                    break;
                case 7:
                    foreach (var student in frmMain.ListStudents)
                    {
                        //Image imageSex = student.Sex == "ប្រុស" ? Resources.Male : Resources.Female;

                        dgrid.Rows.Add(student.Id, $"{student.FirstName} {student.LastName}", student.Sex, student.Score[0], student.Score[1], student.Score[2], student.Score[3], student.Score[4], student.Score[5], student.Score[6], student.Total);
                    }
                    break;
                case 8:
                    foreach (var student in frmMain.ListStudents)
                    {
                        //Image imageSex = student.Sex == "ប្រុស" ? Resources.Male : Resources.Female;

                        dgrid.Rows.Add(student.Id, $"{student.FirstName} {student.LastName}", student.Sex, student.Score[0], student.Score[1], student.Score[2], student.Score[3], student.Score[4], student.Score[5], student.Score[6], student.Score[7], student.Total);
                    }
                    break;
                case 9:
                    foreach (var student in frmMain.ListStudents)
                    {
                        //Image imageSex = student.Sex == "ប្រុស" ? Resources.Male : Resources.Female;

                        dgrid.Rows.Add(student.Id, $"{student.FirstName} {student.LastName}", student.Sex, student.Score[0], student.Score[1], student.Score[2], student.Score[3], student.Score[4], student.Score[5], student.Score[6], student.Score[7], student.Score[8], student.Total);
                    }
                    break;
            }
        }

        void FromListToScoreGrid()
        {
            AddRowDependOnQuizColumns(Settings.Default.NumOfScore);
        }

        private void Score_Load(object sender, EventArgs e)
        {
            string[] subjects = new string[Settings.Default.NumOfScore];
            for (int i = 0; i < subjects.Length; i++)
            {
                subjects[i] = Settings.Default.Subjects[i];
            }

            int subLength = subjects.Length;
            DataGridViewTextBoxColumn[] colsScore = new DataGridViewTextBoxColumn[subLength + 1];
            DataGridViewTextBoxColumn gridCol;
            for (int i = 0; i < subLength; i++)
            {
                gridCol = new DataGridViewTextBoxColumn();
                gridCol.HeaderText = subjects[i];
                gridCol.Name = subjects[i];
                gridCol.Width = 100;
                gridCol.ReadOnly = true;
                //gridCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                colsScore[i] = gridCol;

                if(i == subLength - 1)
                {
                    gridCol = new DataGridViewTextBoxColumn();
                    gridCol.HeaderText = gridCol.Name = "Total";
                    gridCol.Width = 125;
                    gridCol.DefaultCellStyle.ForeColor = Color.Red;
                    //gridCol.DefaultCellStyle.BackColor = Color.DarkRed;
                    gridCol.ReadOnly = true;
                    //gridCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    colsScore[i + 1] = gridCol;
                }
            }

            // Add all columns to datagridview
            dgrid.Columns.AddRange(colsScore);
            FromListToScoreGrid();
        }

        private void btnSetScore_Click(object sender, EventArgs e)
        {
            //! 2nd click to save the data
            if(btnSetScore.Text == "រក្សាទុក")
            {
                DialogResult dr = MessageBox.Show("តើអ្នកចង់រក្សាទុកមែនទេ?", "បញ្ចាក់" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (dr == DialogResult.No)
                    return;

                for (int i = 0; i < frmMain.ListStudents.Count; i++)
                {
                    int quizLength = frmMain.ListStudents[i].Score.Length;

                    try
                    {
                        for (int j = 0; j < quizLength; j++)
                            frmMain.ListStudents[i].Score[j] = float.Parse(dgrid[3 + j, i].Value.ToString());

                        dgrid[3 + quizLength, i].Value = frmMain.ListStudents[i].Total;
                    }
                    catch (Exception)
                    {
                        new Animation.msgBoxErrorAnimation("សូមបញ្ចូលលេខឲ្យបានត្រឹមត្រូវ").ShowDialog();
                        return;
                    }
                    
                }

                btnSetScore.Text = "បញ្ចូលពិន្ទុ";
                for (int i = 3; i <= Settings.Default.NumOfScore + 3; i++)
                    dgrid.Columns[i].ReadOnly = true;

                //MessageBox.Show("ការរក្សាទុកបានសម្រេច", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Animation.msgBoxTickAnimation().ShowDialog();
                return;
            }
            
            //! 1st click to enable editing SCORE
            for (int i = 3; i < dgrid.ColumnCount; i++)
                dgrid.Columns[i].ReadOnly = false;

            btnSetScore.Text = "រក្សាទុក";
        }

        private void Score_Enter(object sender, EventArgs e)
        {
            if (frmMain.ListStudents.Count != dgrid.RowCount)
            {
                dgrid.Rows.Clear();
                FromListToScoreGrid();
            }

        }

        private void btnClearAllScores_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("តើអ្នកពិតជាចង់លប់មែនឬ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
                return;

            try
            {
                int x = 0;
                foreach (var student in frmMain.ListStudents)
                {
                    for (int i = 0; i < student.Score.Length; i++)
                    {
                        student.Score[i] = 0;
                        dgrid[i + 3, x].Value = 0;
                    }
                    x++;
                }

                new Animation.msgBoxTickAnimation().Show();
            }
            catch (Exception)
            {
                new Animation.msgBoxErrorAnimation().Show();
            }
        }
    }
}
