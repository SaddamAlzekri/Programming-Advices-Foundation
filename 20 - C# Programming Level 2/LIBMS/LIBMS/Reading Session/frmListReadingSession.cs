using System;
using LIBMS.Reading_Session;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIBMS_Business;

namespace LIBMS.Reading_Session
{
    public partial class frmListReadingSession : Form
    {
        public frmListReadingSession()
        {
            InitializeComponent();
        }
        public DataTable _dtReadingSession = new DataTable();
        private void showMemberCardInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowBookInfo frm = new frmShowBookInfo((int)dgvReadingSession.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            int SessionID = (int)dgvReadingSession.CurrentRow.Cells[0].Value;
            int MemberID = (int)dgvReadingSession.CurrentRow.Cells[1].Value;

            frmCancelOfReadingSession frm = new frmCancelOfReadingSession(MemberID, SessionID);
            frm.ShowDialog();
            LoadData();
        }

        private void tsmAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdateReadingSession frm = new frmAddUpdateReadingSession();
            frm.ShowDialog();
            LoadData();
        }

        private void LoadData()
        {
            _dtReadingSession = clsReasonSession.GetAllReadingSession();

            dgvReadingSession.DataSource = _dtReadingSession;
            dgvReadingSession.AllowUserToAddRows = false;
            lblRecordsCount.Text = dgvReadingSession.Rows.Count.ToString();
            cbFilterBy.SelectedItem = "None";
            cbStatus.Visible = false;
        }
        private void frmListReadingSession_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvReadingSession_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == DBNull.Value && e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                e.Value = "NULL";
                dgvReadingSession.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(235, 182, 193);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            string Status = dgvReadingSession.CurrentRow.Cells[5].Value.ToString();
            if (MessageBox.Show("Are you sure you want to Completed Reading Session [" + dgvReadingSession.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK && Status != "Cancelled")
            {
                if (clsReasonSession.CompletedOfReadingSession((int)dgvReadingSession.CurrentRow.Cells[0].Value, DateTime.Now, "Complete"))
                {
                    MessageBox.Show("Reading Session Completed Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            else
                MessageBox.Show("Reading Session was not Completed because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "SessionID":
                    FilterColumn = "SessionID";
                    break;
                case "MemberID":
                    FilterColumn = "MemberID";
                    break;
                case "BookID":
                    FilterColumn = "BookID";
                    break;
                case "Status":
                    FilterColumn = "Status";
                    break;
                case "ReasonOfCancel":
                    FilterColumn = "ReasonOfCancel";
                    break;
                case "None":
                    FilterColumn = "None";
                    break;
            }

            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                //_dtReadingSession.DefaultView.RowFilter = "";
                lblRecordsCount.Text = _dtReadingSession.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "SessionID" || FilterColumn == "MemberID" || FilterColumn == "BookID")
            {
                if (!string.IsNullOrEmpty(txtFilterValue.Text))
                {
                    _dtReadingSession.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
                }
            }
            else
                _dtReadingSession.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = _dtReadingSession.Rows.Count.ToString();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "Status";
            string FilterValue = cbStatus.Text;
            


            switch (FilterValue)
            {
                case "Concelled":
                    FilterValue = "Concelled";
                    break;
                case "Complete":
                    FilterValue = "Complete";
                    break;
                case "Active":
                    FilterValue = "Active";
                    break;
            }

            _dtReadingSession.DefaultView.RowFilter = string.Format("[{0}] = '{1}'", FilterColumn, FilterValue);

            lblRecordsCount.Text = _dtReadingSession.Rows.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Status")
            {
                txtFilterValue.Visible = false;
                cbStatus.Visible = true;
            }else
            {
                txtFilterValue.Visible = true;
                cbStatus.Visible = false;
            }
        }

    }
}

