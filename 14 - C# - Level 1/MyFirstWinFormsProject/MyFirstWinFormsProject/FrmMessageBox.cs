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
    public partial class FrmMessageBox : Form
    {
        public FrmMessageBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you Sure");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you Sure", "Confirme");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Sure", "Confirme",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("Yes Okey");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure", "Confirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                MessageBox.Show("Yes Okey");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure", "Confirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("Yes Okey");
            }
        }
    }
}
