using System;
using DVLD.Test;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business;

namespace DVLD.Test
{
    public partial class frmListTestTypes : Form
    {
        private DataTable _dtTestType;

        public frmListTestTypes()
        {
            InitializeComponent();
        }

        private void frmListTestTypes_Load(object sender, EventArgs e)
        {
            _dtTestType = clsTestType.GetAllTestTypes();
            dgvTestType.DataSource = _dtTestType;
            lblRecordsCount.Text = dgvTestType.Rows.Count.ToString();

            if(_dtTestType != null)
            {
                dgvTestType.Columns[0].HeaderText = "ID";
                dgvTestType.Columns[0].Width = 120;

                dgvTestType.Columns[1].HeaderText = "Title";
                dgvTestType.Columns[1].Width = 200;

                dgvTestType.Columns[2].HeaderText = "Description";
                dgvTestType.Columns[2].Width = 400;

                dgvTestType.Columns[3].HeaderText = "Fees";
                dgvTestType.Columns[3].Width = 100;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTestType frm = new frmEditTestType((clsTestType.enTestType)dgvTestType.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListTestTypes_Load(null, null);
        }

    }
}
