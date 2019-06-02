using System;
using System.Reflection;
using System.Windows.Forms;

namespace Classroom_Project__Win_Form_
{
    public class DataGridView_DoubleBuffered
    {
        public static void DoubleBuffered(DataGridView dgrid, bool setting)
        {
            Type dgridType = dgrid.GetType();
            PropertyInfo pi = dgridType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgrid, setting, null);
        }
    }
}
