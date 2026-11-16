using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Double Num1 = 0, Num2 = 0, Result = 0;
        char Operator = ' ';
        string strMessege = "", strNum1 = "", strNum2 = "";

        void GetNumbers(Double Num)
        {
            if (Operator == ' ')
            {
                Num1 = Num;
                textBox1.Text += Convert.ToString(Num1);
            }
            else
            {
                Num2 = Num;
                textBox1.Text += Convert.ToString(Num2);
                strNum2 += Convert.ToString(Num2);

            }
        }

        void Calculator(Double Num1, Double Num2, char Operator)
        {
            switch(Operator)
            {
                case '+':
                    Result = Num1 + Num2;
                    break;
                case '-':
                    Result = Num1 - Num2;
                    break;
                case '*':
                        Result = Num1 * Num2;
                    break;
                case '/':
                   if(Num2 != 0)
                    {
                        Result = Num1 / Num2;
                    }
                    else
                    {
                        strMessege = "Donot Devsion on " + Convert.ToString(Num2);
                    }
                    break;
            }
            if(Num2 != 0)
            {
                lblResult.Text = Convert.ToString(Result);
            }
            else
            {
                lblResult.Text = Convert.ToString(strMessege);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            GetNumbers(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            GetNumbers(2);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            strNum1 = textBox1.Text + " ";
            Operator = '+';
            textBox1.Text += Convert.ToString(" + ");

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            strNum1 = textBox1.Text + " ";
            Operator = '-';
            textBox1.Text += Convert.ToString(" - ");

        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            strNum1 = textBox1.Text + " ";
            Operator = '*';
            textBox1.Text += Convert.ToString(" * ");

        }

        private void btnDev_Click(object sender, EventArgs e)
        {
            strNum1 = textBox1.Text + " ";
            Operator = '/';
            textBox1.Text += Convert.ToString(" / ");

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(strNum1);
            Num2 = Convert.ToDouble(strNum2);
            Calculator(Num1, Num2, Operator);
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(".");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            GetNumbers(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            GetNumbers(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            GetNumbers(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            GetNumbers(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            GetNumbers(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            GetNumbers(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            GetNumbers(9);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            GetNumbers(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lblResult.Text = "";
        }
    }
}
