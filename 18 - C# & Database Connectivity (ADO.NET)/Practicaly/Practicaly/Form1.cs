using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicaly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if(P_MB.Width == 182)
            {
                P_MB.Width = 50;
                button1.RightToLeft = RightToLeft.Yes;
                lbl_FullName.Visible = false;
                lbl_TypeOfUser.Visible = false;
            }else
            {
                P_MB.Width = 182;
                button1.RightToLeft = RightToLeft.No;
                lbl_FullName.Visible = true;
                lbl_TypeOfUser.Visible = true;
            }
        }
        Form2 frm2 = new Form2(00);
        Form3 frm3 = new Form3();
        Form4 frm4 = new Form4();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void المبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P_Container.Controls.Clear();
            P_Container.Controls.Add(frm3.panel1);
        }

        private void المبيعاتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            P_Container.Controls.Clear();
            P_Container.Controls.Add(frm4.panel1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            P_Container.Controls.Clear();
            P_Container.Controls.Add(frm4.panel1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            P_Container.Controls.Clear();
            P_Container.Controls.Add(frm4.panel1);
        }
    }
}
