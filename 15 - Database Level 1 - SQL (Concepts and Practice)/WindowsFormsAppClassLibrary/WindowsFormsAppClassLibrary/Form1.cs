using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyfirstClassLibrary;

namespace WindowsFormsAppClassLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsMyMath clsMath = new clsMyMath();

           DialogResult result =  MessageBox.Show(clsMath.Sum(10, 20).ToString(), "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(DialogResult.OK == result)
            {
                MessageBox.Show("Hi, Its Okey");
            }
        }
    }
}
