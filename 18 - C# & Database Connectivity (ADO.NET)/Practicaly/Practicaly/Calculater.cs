using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicaly
{
    public partial class Calculater : UserControl
    {
        public Calculater()
        {
            InitializeComponent();
        }

        public string Result
        {
            get { return lblResult.Text != "" ? lblResult.Text : lblResult.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResult.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();
        }


    }
}
