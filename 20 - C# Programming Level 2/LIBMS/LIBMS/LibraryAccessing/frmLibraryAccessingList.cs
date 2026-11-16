using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIBMS_Business;

namespace LIBMS.LibraryAccessing
{
    public partial class frmLibraryAccessingList : Form
    {
        clsLibraryAccessing _clsLibraryAccessing = new clsLibraryAccessing();
        public frmLibraryAccessingList()
        {
            InitializeComponent();
        }
        DataTable _dtGetAllLibraryAccessing = new DataTable();

        private void _RefreshPeoplList()
        {
            _dtGetAllLibraryAccessing = clsLibraryAccessing.GetAllLibraryAccessing();

            if (_dtGetAllLibraryAccessing != null && _dtGetAllLibraryAccessing.Rows.Count > 0)
            {
                dgvLibraryAccessing.DataSource = _dtGetAllLibraryAccessing;
                lblRecordsCount.Text = dgvLibraryAccessing.Rows.Count.ToString();
                dgvLibraryAccessing.AllowUserToAddRows = false;
            }

            cbFilterBy.SelectedIndex = 0;
        }

        private void frmLibraryAccessingList_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            _RefreshPeoplList();
        }

        private void tsmAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdateLibraryAccessing frm = new frmAddUpdateLibraryAccessing(frmAddUpdateLibraryAccessing.enMode.AddNew);
            frm.ShowDialog();
            _RefreshPeoplList();
        }
        
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
                    string FilterColumn = "";

            switch(cbFilterBy.Text)
            {
                case "Log ID":
                    FilterColumn = "LogID";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "Customer Name":
                    FilterColumn = "CustomerName";
                    break;

                case "Reason":
                    FilterColumn = "Reason";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Country Name":
                    FilterColumn = "CountryName";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if(txtFilterValue.Text.Trim() == "" || cbFilterBy.Text == "None")
            {
                _dtGetAllLibraryAccessing.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvLibraryAccessing.Rows.Count.ToString();
            }

            if (FilterColumn == "LogID" || FilterColumn == "PersonID" || FilterColumn == "Phone")
            {
                if(!string.IsNullOrEmpty(txtFilterValue.Text))
                {
                    _dtGetAllLibraryAccessing.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
                }
            }
            else
                _dtGetAllLibraryAccessing.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvLibraryAccessing.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "LogID" || cbFilterBy.Text == "PersonID" || cbFilterBy.Text == "Phone")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "None")
                txtFilterValue.ReadOnly = true;
            else
                txtFilterValue.ReadOnly = false;
        }

        private void dgvLibraryAccessing_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == DBNull.Value && e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                e.Value = "NULL";
                dgvLibraryAccessing.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(235, 182, 193);
            }
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            _clsLibraryAccessing._LogID = (int)dgvLibraryAccessing.CurrentRow.Cells[0].Value;
            _clsLibraryAccessing._OutTime = DateTime.Now;

            string cellValue = dgvLibraryAccessing.CurrentRow.Cells[4].FormattedValue.ToString();

            if (MessageBox.Show("Are you sure you out of library [" + dgvLibraryAccessing.CurrentRow.Cells[2].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (cellValue == "NULL" && _clsLibraryAccessing.UpdateLibraryAccesslog())
                {
                    MessageBox.Show("Done update");
                    _RefreshPeoplList();
                }
                else
                {
                    MessageBox.Show("This Customer [" + dgvLibraryAccessing.CurrentRow.Cells[2].Value + "] is out ready :-).");
                }
            }
        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            int LogID = (int)dgvLibraryAccessing.CurrentRow.Cells[0].Value;
            int PersonID = (int)dgvLibraryAccessing.CurrentRow.Cells[1].Value;
            frmAddUpdateLibraryAccessing frm = new frmAddUpdateLibraryAccessing(frmAddUpdateLibraryAccessing.enMode.ShowData, LogID, PersonID);
            frm.ShowDialog();
        }


    }
}
