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
    public partial class TotalAbsence : UserControl
    {
        public TotalAbsence()
        {
            InitializeComponent();
            dgrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgrid.ColumnHeadersDefaultCellStyle.Font = new Font("Khmer OS Muol Light", 14F);
            DataGridView_DoubleBuffered.DoubleBuffered(dgrid, true);
        }
        void CheckAbsenceDirForExistStudents()
        {
            for (int i = 0; i < frmMain.ListStudents.Count; i++)
            {
                if (!Directory.Exists(frmMain.FilePath + $"\\Absence\\{frmMain.ListStudents[i].Id}"))
                    Directory.CreateDirectory(frmMain.FilePath + $"\\Absence\\{frmMain.ListStudents[i].Id}");
            }
        }
        void ListToGrid()
        {
            for (int i = 0; i < frmMain.ListStudents.Count; i++)
            {
                //Image imageSex = frmMain.ListStudents[i].Sex == "ប្រុស"
                //    ? Properties.Resources.Male
                //    : Properties.Resources.Female;

                dgrid.Rows.Add(frmMain.ListStudents[i].Id, $"{frmMain.ListStudents[i].FirstName} {frmMain.ListStudents[i].LastName}", 
                    frmMain.ListStudents[i].Sex, frmMain.ListStudents[i].PhoneNumber, $"{frmMain.ListStudents[i].Present} ដង", 
                    $"{frmMain.ListStudents[i].Absent} ដង", $"{frmMain.ListStudents[i].Permission} ដង");
            }
        }
        void ReadAbsenceRecord()
        {
            //Set All to 0 in order to not duplicate Increment
            for (int i = 0; i < frmMain.ListStudents.Count; i++)
            {
                frmMain.ListStudents[i].Present = 0;
                frmMain.ListStudents[i].Absent = 0;
                frmMain.ListStudents[i].Permission = 0;
            }

            //// ! THINK AGAIN
            //Absence ab = new Absence();
            //ab.IfDirectoryNotExistedCreateNew();

            string fileAbsencePath = frmMain.FilePath + $"\\Absence";
            for (int i = 0; i < frmMain.ListStudents.Count; i++)
            {
                string[] fileCountTxt = Directory.GetFiles(fileAbsencePath + $"\\{frmMain.ListStudents[i].Id}");
                for (int j = 0; j < fileCountTxt.Length; j++)
                {
                    string[] state = File.ReadAllLines($"{fileCountTxt[j]}");
                    for (int k = 0; k < 6; k++)
                    {
                        switch (state[k])
                        {
                            case "វត្តមាន":
                                frmMain.ListStudents[i].Present++;
                                break;
                            case "អវត្តមាន":
                                frmMain.ListStudents[i].Absent++;
                                break;
                            case "ច្បាប់":
                                frmMain.ListStudents[i].Permission++;
                                break;
                        }
                    }
                }
            }

        }
        void UpdateAbsenceTimes()
        {
            for (int i = 0; i < dgrid.RowCount; i++)
            {
                dgrid[4, i].Value = frmMain.ListStudents[i].Present + " ដង";
                dgrid[5, i].Value = frmMain.ListStudents[i].Absent + " ដង";
                dgrid[6, i].Value = frmMain.ListStudents[i].Permission + " ដង";
            }
        }

        private void TotalAbsence_Load(object sender, EventArgs e)
        {
            dgrid.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(210, 231, 244);

            CheckAbsenceDirForExistStudents();
            ReadAbsenceRecord();
            ListToGrid();
        }

        private void TotalAbsence_Enter(object sender, EventArgs e)
        {
            //If Absence Records were updated, Make Change to AbsenceTimes
            if (Absence.AbsenceUpdate)
            {
                ReadAbsenceRecord();
                UpdateAbsenceTimes();
                Absence.AbsenceUpdate = false;
            }

            //If there any DELETE or ADD to LIST => Update this GridView
            if (frmMain.ListStudents.Count != dgrid.RowCount)
            {
                dgrid.Rows.Clear();
                ListToGrid();
                ReadAbsenceRecord();
                UpdateAbsenceTimes();
            }
        }

        private void btnClearAllAbsences_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("តើអ្នកពិតជាចង់លប់មែនឬ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
                return;

            for (int i = 0; i < frmMain.ListStudents.Count; i++)
            {
                frmMain.ListStudents[i].Present = 0;
                frmMain.ListStudents[i].Absent = 0;
                frmMain.ListStudents[i].Permission = 0;
                if (Directory.Exists(frmMain.FilePath + $"\\Absence\\{frmMain.ListStudents[i].Id}"))
                    Directory.Delete(frmMain.FilePath + $"\\Absence\\{frmMain.ListStudents[i].Id}", true);
            }

            new Animation.msgBoxTickAnimation().Show();
        }
    }
}
