using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class FrmDateTimePicker : Form
    {
        public FrmDateTimePicker()
        {
            InitializeComponent();
        }
        DateTime StartTime, EndTime;
        TimeSpan result;
        private void button1_Click(object sender, EventArgs e)
        {
        
            string str = dateTimePicker1.Value.ToLongDateString() + Environment.NewLine;
            str += dateTimePicker1.Value.ToLongTimeString() + Environment.NewLine;
            str += dateTimePicker1.Value.ToShortDateString() + Environment.NewLine;
            str += dateTimePicker1.Value.ToShortTimeString() + Environment.NewLine;

            label1.Text = str;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = dateTimePicker1.Value.ToString("dddd-dd-mm-yyyy") + Environment.NewLine;
            str += dateTimePicker1.Value.ToString("dd-mm-yyyy") + Environment.NewLine;
            str += dateTimePicker1.Value.ToString("dd-dddd-mm-yyyy") + Environment.NewLine;
            str += dateTimePicker1.Value.ToString("dddd-mm-yyyy") + Environment.NewLine;

            label2.Text = str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result = EndTime - StartTime ;
            int Days = result.Days;
            int Months = (result.Days / 30);
            int Years = (result.Days / 365);

            lblDays.Text = Convert.ToString(Days);
            lblMonths.Text = Convert.ToString(Months);
            lblYears.Text = Convert.ToString(Years);

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            StartTime = (DateTime)dateTimePicker2.Value.Date;
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            EndTime = (DateTime)dateTimePicker3.Value.Date;

        }

        private void FrmDateTimePicker_Load(object sender, EventArgs e)
        {

        }
    }
}
