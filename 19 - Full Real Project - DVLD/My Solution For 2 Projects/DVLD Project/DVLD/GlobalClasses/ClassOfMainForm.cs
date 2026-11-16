using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.GlobalClasses
{
    class ClassOfMainForm
    {
        public static void Maximize(Form frm)
        {
            if (frm.WindowState == FormWindowState.Normal)
            {
                frm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                frm.WindowState = FormWindowState.Normal;
            }
        }

        public static void Minimize(Form frm)
        {
            if (frm.WindowState == FormWindowState.Maximized)
            {
                frm.WindowState = FormWindowState.Minimized;
            }
            else
            {
                frm.WindowState = FormWindowState.Minimized;
            }
        }

        public static void NowTime(Label lblTime)
        {
            DateTime time = DateTime.Now;

            lblTime.Text = time.ToString("hh : mm : ss tt");
        }

        public static void ControlOfpnlLetfList(Panel pnlLetfList, Button btnClose, Label lblTime, Label lblUserName, PictureBox pictureBox1, Label lblPersonalImage, Label label2, Label label4)
        {
            if (pnlLetfList.Width == 200)
            {
                btnClose.Location = new Point(3, 1);
                lblTime.Visible = false;
                lblUserName.Visible = false;
                pictureBox1.Visible = false;
                lblPersonalImage.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                pnlLetfList.Width = 50;
            }
            else
            {
                btnClose.Location = new Point(155, 3);
                lblTime.Visible = true;
                lblUserName.Visible = true;
                label2.Visible = true;
                lblPersonalImage.Visible = true;
                label4.Visible = true;
                pictureBox1.Visible = true;
                pnlLetfList.Width = 200;
            }
        }

    }
}
