using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Classroom_Project__Win_Form_.User_Controls
{
    public partial class Absence : UserControl
    {
        public Absence()
        {
            InitializeComponent();

            dgrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgrid.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(210, 231, 244);
            dgrid.ColumnHeadersDefaultCellStyle.Font = new Font("Khmer OS Muol Light", 14F);
            DataGridView_DoubleBuffered.DoubleBuffered(dgrid, true);
            
        }

        string dayStart;
        string dayEnd;
        string absentTxt;
        int dayToMinus;
        DateTime datetimeNow = DateTime.Now;
        public static bool AbsenceUpdate;

        void ClearCheckBoxColumns()
        {
            for (int i = 0; i < dgrid.RowCount; i++)
                for (int j = 3; j < 9; j++)
                    dgrid.Rows[i].Cells[j].Value = null;
        }

        void FromListToAbsentGrid()
        {
            foreach (var student in frmMain.ListStudents)
            {
                //Image imageSex;
                //if (student.Sex == "ប្រុស")
                //    imageSex = Properties.Resources.Male;
                //else
                //    imageSex = Properties.Resources.Female;

                dgrid.Rows.Add(student.Id, $"{student.FirstName} {student.LastName}", student.Sex);
            }
        }
        string SetDayMonthColumnHeader(int addDay)
        {
            var dayStart = dateStart.Value.AddDays(addDay);
            return dayStart.Day.ToString("00-") + dayStart.Month.ToString("00");
        }
        string ConvertDateFormat(DateTime now, int dayToAdd = 0)
        {
            now = now.AddDays(dayToAdd - dayToMinus);

            return now.Day.ToString("00-") + now.Month.ToString("00-") + now.Year.ToString("0000");
        }

        void DateStartEndUpdate()
        {
            string today = datetimeNow.DayOfWeek.ToString();
            dayToMinus = 0;
            switch (today)
            {
                case "Monday":
                    break;
                case "Tuesday":
                    dayToMinus = 1;
                    break;
                case "Wednesday":
                    dayToMinus = 2;
                    break;
                case "Thursday":
                    dayToMinus = 3;
                    break;
                case "Friday":
                    dayToMinus = 4;
                    break;
                case "Saturday":
                    dayToMinus = 5;
                    break;
                case "Sunday":
                    dayToMinus = 6;
                    break;
            }
            dateStart.Value = datetimeNow.AddDays(-dayToMinus);
            dateEnd.Value = dateStart.Value.AddDays(+5);
            dayStart = dateStart.Text.Remove(0, 4);
            dayEnd = dateEnd.Text.Remove(0, 4);

            //Change Header Column Name according to the dateStart & End
            dgrid.Columns[3].HeaderText = "Mon\n" + SetDayMonthColumnHeader(0);
            dgrid.Columns[4].HeaderText = "Tue\n" + SetDayMonthColumnHeader(1);
            dgrid.Columns[5].HeaderText = "Wed\n" + SetDayMonthColumnHeader(2);
            dgrid.Columns[6].HeaderText = "Thu\n" + SetDayMonthColumnHeader(3);
            dgrid.Columns[7].HeaderText = "Fri\n" + SetDayMonthColumnHeader(4);
            dgrid.Columns[8].HeaderText = "Sat\n" + SetDayMonthColumnHeader(5);
        }

        /// <summary>
        /// Store in Folder
        /// Like 1(id)
        /// then StartDate - EndDate in 6 days
        /// 01-09-2018 - 06-09-2018.txt
        /// then 6 states of this student ID
        /// </summary>
        void ReadAbsenceFromFile()
        {
            absentTxt = ConvertDateFormat(datetimeNow) + " - " + ConvertDateFormat(datetimeNow, 5) + ".txt";

            int x = 0;
            foreach (var student in frmMain.ListStudents)
            {
                string filePath = frmMain.FilePath + $"\\Absence\\{student.Id}\\{absentTxt}";

                if (File.Exists(filePath))
                {
                    string[] state = File.ReadAllLines(filePath);
                    for (int i = 0; i < 6; i++)
                    {
                        dgrid[i + 3, x].Value = state[i];
                    }
                }
                x++;
            }

        }

        /// <summary>
        /// See ReadAbsenceFromFile
        /// </summary>
        void AbsentGridToFile()
        {
            absentTxt = ConvertDateFormat(datetimeNow) + " - " + ConvertDateFormat(datetimeNow, 5) + ".txt";

            int x = 0;
            foreach (var student in frmMain.ListStudents)
            {
                string filePath = frmMain.FilePath + $"\\Absence\\{student.Id}\\{absentTxt}";
                string[] state = new string[6];
                for (int i = 0; i < 6; i++)
                {
                    if(dgrid[i+3,x].Value == null)
                    {
                        state[i] = "គ្មាន";
                        continue;
                    }

                    state[i] = dgrid[i + 3, x].Value.ToString();
                }
                File.WriteAllLines(filePath, state);
                x++;
            }

        }
        private void Absent_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(frmMain.FilePath + @"\Absence"))
                Directory.CreateDirectory(frmMain.FilePath + @"\Absence");

            FromListToAbsentGrid();
            DateStartEndUpdate();
            ClearCheckBoxColumns();
            ReadAbsenceFromFile();
        }

        private void Absent_Enter(object sender, EventArgs e)
        {
            //listStudents = frmMain.ListStudents;
            if (frmMain.ListStudents.Count < dgrid.RowCount)
            {
                //Just clear all rows if students == 0
                if (frmMain.ListStudents.Count == 0)
                {
                    dgrid.Rows.Clear();
                    return;
                }

                int i = 0;
                while(frmMain.ListStudents.Count != dgrid.RowCount)
                {
                    int gridStudentId = int.Parse(dgrid[0, i].Value.ToString());
                    if (frmMain.ListStudents[i].Id != gridStudentId)
                        dgrid.Rows.RemoveAt(i);

                    i++;
                    //If i already outbound the INDEX let's break
                    if (i == frmMain.ListStudents.Count)
                        break;
                }
            }

            else if (frmMain.ListStudents.Count > dgrid.RowCount)
            {
                dgrid.Rows.Clear();
                FromListToAbsentGrid();
                ClearCheckBoxColumns();
                ReadAbsenceFromFile();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("តើអ្នកពិតជាចង់រក្សាទុកមែនឬ?", "បញ្ចាក់", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
                return;

            dgrid.Sort(dgrid.Columns[0], ListSortDirection.Ascending);

            AbsentGridToFile();
            AbsenceUpdate = true;
            new Animation.msgBoxTickAnimation().Show();
        }

        private void picPlusWeek_Click(object sender, EventArgs e)
        {
            datetimeNow = datetimeNow.AddDays(+7);
            DateStartEndUpdate();
            ClearCheckBoxColumns();
            ReadAbsenceFromFile();
        }

        private void picMinusWeek_Click(object sender, EventArgs e)
        {
            datetimeNow = datetimeNow.AddDays(-7);
            DateStartEndUpdate();
            ClearCheckBoxColumns();
            ReadAbsenceFromFile();
        }

        #region ContextMenuStrip on ColumnHeaders
        private int colRightClickedIndex;

        private void fullColumnHolidayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colRightClickedIndex >= 3)
            {
                for (int i = 0; i < dgrid.RowCount; i++)
                    dgrid[colRightClickedIndex, i].Value = "ថ្ងៃឈប់";
            }
        }

        private void dgrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
                colRightClickedIndex = e.ColumnIndex;
            }
        }
        #endregion

    }
}
