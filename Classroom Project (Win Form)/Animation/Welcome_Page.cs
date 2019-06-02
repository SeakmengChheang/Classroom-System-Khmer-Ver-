using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classroom_Project__Win_Form_.Animation
{
    public partial class Welcome_Page : Form
    {
        public Welcome_Page()
        {
            InitializeComponent();
        }

        private bool roundOne, roundTwo, roundThree, roundFour, finalRound;

        private void Welcome_Page_Load(object sender, EventArgs e)
        {
            timer1.Start();
            roundOne = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (roundOne)
            {
                Transition.ShowSync(label1);
                timer1.Stop();
                timerPause1s.Start(); 
            }

        }

        private void timerPause1s_Tick(object sender, EventArgs e)
        {
            if (roundOne)
            {
                Transition.HideSync(label1);
                ColorTransition.HideSync(panel1);
                timer2.Start();
                timerPause1s.Stop();
            }
            else if (roundTwo)
            {
                Transition.HideSync(label2);
                ColorTransition.HideSync(panel1);
                timer2.Start();
                timerPause1s.Stop();
            }
            else if (roundThree)
            {
                Transition.HideSync(label3);
                ColorTransition.HideSync(panel1);
                timer2.Start();
                timerPause1s.Stop();
            }
            else if (roundFour)
            {
                Transition.HideSync(label4);
                ColorTransition.HideSync(panel1);
                timer2.Start();
                timerPause1s.Stop();
            }
            else if (finalRound)
            {
                timerPause1s.Stop();
                this.Close();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (roundOne)
            {
                panel1.BackColor = Color.Blue;
                ColorTransition.ShowSync(panel1);
                Transition.ShowSync(label2);
                timer2.Stop();
                timerPause1s.Start();
                roundOne = false;
                roundTwo = true;
            }
            else if (roundTwo)
            {
                panel1.BackColor = Color.Red;
                ColorTransition.ShowSync(panel1);
                Transition.ShowSync(label3);
                timer2.Stop();
                timerPause1s.Start();
                roundTwo = false;
                roundThree = true;
            }
            else if (roundThree)
            {
                panel1.BackColor = Color.Gold;
                ColorTransition.ShowSync(panel1);
                Transition.ShowSync(label4);
                timer2.Stop();
                timerPause1s.Start();
                roundThree = false;
                roundFour = true;
            }
            else if (roundFour)
            {
                panel1.BackColor = Color.Green;
                ColorTransition.ShowSync(panel1);
                Transition.ShowSync(label5);
                timer2.Stop();
                timerPause1s.Start();
                roundFour = false;
                finalRound = true;
            }

        }

        
    }
}
