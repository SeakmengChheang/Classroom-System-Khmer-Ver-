using System.Windows.Forms;

namespace Classroom_Project__Win_Form_.Animation
{
    public partial class Splash_Screen : Form
    {

        public Splash_Screen()
        {
            InitializeComponent();
        }

        internal void RequestToClose(bool Prompt)
        {
            CloseThis();
        }

        void CloseThis()
        {
            this.Hide();
        }
    }
}
