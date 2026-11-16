using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstControlLibrary
{
    public partial class SimpleCalculate: UserControl
    {
        public SimpleCalculate()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double Result = 0;
            if(int.TryParse(textBox1.Text,out int Num1) && int.TryParse(textBox2.Text, out int Num2))
            {
                Result += Num1 + Num2;
            }

            label3.Text = Result.ToString();
        }
    }
}
