using System;
using LIBMS.Package;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIBMS_Business;
using System.Data;

namespace LIBMS.Package
{
    public partial class frmListMembershipPackage : Form
    {
        public frmListMembershipPackage()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            DataTable _dtPackage = new DataTable();

            _dtPackage = clsPackage.GetAllPackage();

            dgvPackages.DataSource = _dtPackage;

            lblRecordsCount.Text = (dgvPackages.Rows.Count -1).ToString();
            dgvPackages.AllowUserToAddRows = false;
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmUpdateMembershipPackage frm = new frmUpdateMembershipPackage((int)dgvPackages.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListMembershipPackage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            frmUpdateMembershipPackage frm = new frmUpdateMembershipPackage((int)dgvPackages.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            LoadData();
        }

        private void dgvPackages_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == DBNull.Value && e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                e.Value = "NULL";
                dgvPackages.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(235, 182, 193);
            }
        }
    }
}
