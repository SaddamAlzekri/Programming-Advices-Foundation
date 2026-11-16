using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureboxH.W
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void rbBoy_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Boy;
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void rbGirl_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Girl;
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Book;
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void rbPen_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Pen;
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Boy")
                pictureBox2.Image = Properties.Resources.Boy;
            else if (comboBox1.Text == "Girl")
                pictureBox2.Image = Properties.Resources.Girl;
            else  if (comboBox1.Text == "Book")
                pictureBox2.Image = Properties.Resources.Book;
            else
                pictureBox2.Image = Properties.Resources.Pen;
        }
    }
}
