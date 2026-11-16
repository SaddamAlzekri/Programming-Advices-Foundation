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
    public partial class FrmMaskedBox : Form
    {
        public FrmMaskedBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.MaskFull)
                MessageBox.Show("MAskedTextBox is Full", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            else
                MessageBox.Show("MAskedTextBox is not Full", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }
    }
}
