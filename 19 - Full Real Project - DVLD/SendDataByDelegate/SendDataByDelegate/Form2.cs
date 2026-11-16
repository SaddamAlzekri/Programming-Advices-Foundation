using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendDataByDelegate
{
    public partial class Form2 : Form
    {
        public delegate void DataBackEventHandler(object sender, string Name);
        public event DataBackEventHandler DataBack;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;

            DataBack.Invoke(this, Name);

            this.Close();
        }
    }
}
