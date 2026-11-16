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

namespace LIBMS.ReservationOfRooms
{
    public partial class frmReservationRoomList : Form
    {
        public frmReservationRoomList()
        {
            InitializeComponent();
        }
        DataTable _dtAllReservationRoom = new DataTable();
        clsReservationRoom _clsReservationRoom = new clsReservationRoom();
 
        private void tsmAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdateReservationRooms frm = new frmAddUpdateReservationRooms(frmAddUpdateReservationRooms.enMode.AddNew);
            frm.ShowDialog();
            _RefreshPeoplList();
        }

        private void _RefreshPeoplList()
        {
            _dtAllReservationRoom = clsReservationRoom.GetAllGetAllRoomReservation();

            if (_dtAllReservationRoom != null && _dtAllReservationRoom.Rows.Count > 0)
            {
                dgvReservationRoom.DataSource = _dtAllReservationRoom;
                lblRecordsCount.Text = dgvReservationRoom.Rows.Count.ToString();
                dgvReservationRoom.AllowUserToAddRows = false;
            }

            cbFilterBy.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
        }

        private void frmReservationRoomList_Load(object sender, EventArgs e)
        {
            _RefreshPeoplList();
        }
        

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Reservation ID":
                    FilterColumn = "ReservationID";
                    break;
                case "Room ID":
                    FilterColumn = "RoomID";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "Customer Name":
                    FilterColumn = "CustomerName";
                    break;

                case "Status":
                    FilterColumn = "Status";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilterValue.Text.Trim() == "" || cbFilterBy.Text == "None")
            {
                _dtAllReservationRoom.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvReservationRoom.Rows.Count.ToString();
            }

            if (FilterColumn == "ReservationID" || FilterColumn == "PersonID" || FilterColumn == "RoomID")
            {
                if (!string.IsNullOrEmpty(txtFilterValue.Text))
                {
                    _dtAllReservationRoom.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
                }
            }
            else
                _dtAllReservationRoom.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvReservationRoom.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Person ID" || cbFilterBy.Text == "Reservation ID" || cbFilterBy.Text == "Room ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "None")
            {
                txtFilterValue.ReadOnly = true;
            }
            else if(cbFilterBy.Text == "Status")
            {
                txtFilterValue.Visible = false;
            }else
            {
                txtFilterValue.Visible = true;
                txtFilterValue.ReadOnly = false;
            }
        }


        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (!string.IsNullOrEmpty(cbStatus.Text) && cbStatus.Text != "None")
                {
                    _dtAllReservationRoom.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", "Status", cbStatus.Text.Trim());
                }
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            if (dgvReservationRoom.CurrentRow.Cells[5].FormattedValue.ToString() == "NULL")
            {
                _clsReservationRoom.ReservedID = (int)dgvReservationRoom.CurrentRow.Cells[0].Value;

                _clsReservationRoom.UpdateStartDate();
                _RefreshPeoplList();
            }
            else
            {
                MessageBox.Show("This Room is busy", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void endDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvReservationRoom.CurrentRow.Cells[6].FormattedValue.ToString() == "NULL")
            {
                _clsReservationRoom.ReservedID = (int)dgvReservationRoom.CurrentRow.Cells[0].Value;

                _clsReservationRoom.UpdateEndDate();
                _RefreshPeoplList();
            }else
            {
                MessageBox.Show("This Room is Finished", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvReservationRoom_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == DBNull.Value && e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                e.Value = "NULL";
                dgvReservationRoom.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(235, 182, 193);
            }
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (dgvReservationRoom.CurrentRow.Cells[7].Value.ToString() != "Canceled" && dgvReservationRoom.CurrentRow.Cells[7].Value.ToString() != "Completed")
            {
                _clsReservationRoom.ReservedID = (int)dgvReservationRoom.CurrentRow.Cells[0].Value;

                _clsReservationRoom.Updatecanceled();
                _RefreshPeoplList();
            }
            else
            {
                MessageBox.Show("This Room is Canceled or Completed ready", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
