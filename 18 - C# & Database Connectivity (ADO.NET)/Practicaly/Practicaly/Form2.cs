using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicaly
{
    public partial class Form2 : Form
    {
        public Form2(int _Result)
        {
            InitializeComponent();

            lblResult.Text = _Result.ToString();
        }

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, string UserName, string Password);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}

