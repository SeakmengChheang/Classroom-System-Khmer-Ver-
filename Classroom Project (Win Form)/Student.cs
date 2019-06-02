using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom_Project__Win_Form_
{
    public class Student
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public string Sex;
        public string DOB;
        public string PhoneNumber;
        public float[] Score = new float[Properties.Settings.Default.NumOfScore];
        public float Total => Score.Sum();
        public int Present = 0;
        public int Absent = 0;
        public int Permission = 0;
    }
}
