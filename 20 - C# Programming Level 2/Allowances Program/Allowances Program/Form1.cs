using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllowanesProgram_Business;

namespace Allowances_Program
{
    public partial class Form1 : Form
    {
        clsAllowances _Allowances;
        DataTable _dtAllowances = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void allowancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIncrementEmployees frm = new frmIncrementEmployees(_dtAllowances);
            frm.ShowDialog();
            Form1_Load(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _dtAllowances = clsAllowances.GetAllAllowances();
            dgvEmployees1.DataSource = _dtAllowances;
            dgvEmployees1.AllowUserToAddRows = false;

            lblCountOfEmplyees.Text = (dgvEmployees1.Rows.Count).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
