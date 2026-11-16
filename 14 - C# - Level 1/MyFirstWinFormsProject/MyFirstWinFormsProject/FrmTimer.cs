using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class FrmTimer : Form
    {
        public FrmTimer()
        {
            InitializeComponent();
        }
        private int Second = 0, Minute = 0, Houre = 0;
        private string Timer = "";

        string getTime(string strTimer)
        {
            strTimer = Houre.ToString() + " :   ";
            strTimer += Minute.ToString() + " :   ";
            strTimer += Second.ToString();

            return strTimer;
        }

        void Clock(string str)
        {
            Second++;

            str = getTime(str);

            if (Second == 60)
            {
                Second = 0;
                Minute++;

               str = getTime(str);
            }
            if (Minute == 60)
            {
                Minute = 0;
                Houre++;

               str = getTime(str);
            }
            if (Houre == 13)
            {
                Houre = 1;
                Minute = 0;
                Second = 0;

                str = getTime(str);
            }
            lblTimer.Text = str;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Clock(Timer);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
