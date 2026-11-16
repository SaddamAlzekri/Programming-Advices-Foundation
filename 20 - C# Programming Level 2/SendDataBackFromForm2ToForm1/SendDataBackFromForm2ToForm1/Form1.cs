using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendDataBackFromForm2ToForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.DataBack += GetPersonIDFromForm2;
            frm.ShowDialog();
        }

        private void GetPersonIDFromForm2(object sender, int PeronID)
        {
            lblResult.Text = PeronID.ToString();
        }
    }
}
