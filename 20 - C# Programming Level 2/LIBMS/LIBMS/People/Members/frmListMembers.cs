using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIBMS_Business;

namespace LIBMS.People.Members
{
    public partial class frmListMembers : Form
    {
        DataTable dtMembers = clsMembers.GetAllMembers();

        public frmListMembers()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            DataTable dtMember = clsMembers.GetAllMembers();

            dtMembers = dtMember.DefaultView.ToTable(false, "MemberShipID", "PersonID",
                                           "PackageID", "FullName", "PackageName", "Description",
                                           "PackagePrice", "DurationMonths",
                                           "StartDate", "EndDate","IsActive");
            if(dtMembers != null && dtMembers.Rows.Count > 0)
            {
                dgvMembers.DataSource = dtMembers;
                lblRecordsCount.Text = (dgvMembers.Rows.Count - 1).ToString();
                dgvMembers.AllowUserToAddRows = false;

                dgvMembers.Columns[0].HeaderText = "MemberShipID";
                dgvMembers.Columns[0].Width = 55;

                dgvMembers.Columns[1].HeaderText = "PersonID";
                dgvMembers.Columns[1].Width = 50;

                dgvMembers.Columns[2].HeaderText = "PackageID";
                dgvMembers.Columns[2].Width = 55;

                dgvMembers.Columns[3].HeaderText = "FullName";
                dgvMembers.Columns[3].Width = 120;

                dgvMembers.Columns[4].HeaderText = "PackageName";
                dgvMembers.Columns[4].Width = 70;

                dgvMembers.Columns[5].HeaderText = "Description";
                dgvMembers.Columns[5].Width = 60;

                dgvMembers.Columns[6].HeaderText = "PackagePrice";
                dgvMembers.Columns[6].Width = 60;

                dgvMembers.Columns[7].HeaderText = "DurationMonths";
                dgvMembers.Columns[7].Width = 65;

                dgvMembers.Columns[8].HeaderText = "StartDate";
                dgvMembers.Columns[8].Width = 80;

                dgvMembers.Columns[9].HeaderText = "EndDate";
                dgvMembers.Columns[9].Width = 80;

                dgvMembers.Columns[10].HeaderText = "IsActive";
                dgvMembers.Columns[10].Width = 80;
            }
            cbFilterBy.SelectedIndex = 0;
        }


        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            frmAddUpdateMembers frm = new frmAddUpdateMembers((int)dgvMembers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void frmListMembers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }
        
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "MemberShip ID":
                    FilterColumn = "MemberShipID";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "Package ID":
                    FilterColumn = "PackageID";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Package Name":
                    FilterColumn = "PackageName";
                    break;

                case "Package Price":
                    FilterColumn = "PackagePrice";
                    break;

                case "Duration Months":
                    FilterColumn = "DurationMonths";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilterValue.Text.Trim() == "" || cbFilterBy.Text == "None")
            {
                dtMembers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvMembers.Rows.Count.ToString();
            }

            if (FilterColumn == "MemberShipID" || FilterColumn == "PersonID" || FilterColumn == "PackageID" || FilterColumn == "PackagePrice" || FilterColumn == "DurationMonths")
            {
                if (!string.IsNullOrEmpty(txtFilterValue.Text))
                {
                    dtMembers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
                }
            }
            else
                dtMembers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvMembers.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "MemberShip ID" || cbFilterBy.Text == "Person ID" || cbFilterBy.Text == "Package ID" || cbFilterBy.Text == "Package Price" || cbFilterBy.Text == "Duration Months")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdateMembers frm = new frmAddUpdateMembers();
            frm.ShowDialog();
            LoadData();

        }

        private void showMemberCardInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmShowMemberCard frm = new frmShowMemberCard((int)dgvMembers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + dgvMembers.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                //Perform Delele and refresh
                if (clsMembers.DeleteMember((int)dgvMembers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }

                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            frmAddUpdateMembers frm = new frmAddUpdateMembers((int)dgvMembers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            LoadData();
        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowPersonInfo((int)dgvMembers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            LoadData();
        }

        private void tsmAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdateMembers frm = new frmAddUpdateMembers();
            frm.ShowDialog();
            LoadData();
        }

        private void dgvMembers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == DBNull.Value && e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                e.Value = "NULL";
                dgvMembers.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(235, 182, 193);
            }
        }

    }
}
