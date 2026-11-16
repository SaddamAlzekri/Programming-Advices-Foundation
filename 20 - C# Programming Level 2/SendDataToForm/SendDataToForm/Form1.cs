using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendDataToForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int PersonID = -1;
            if (int.TryParse(textBox1.Text, out PersonID))
            {
                Form2 frm = new Form2(PersonID);
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Enter Number Please, this is " + textBox1.Text.ToString() + " Not Number");
        }
    }
}
