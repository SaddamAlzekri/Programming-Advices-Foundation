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
namespace LIBMS.RoomsReservation
{
    public partial class frmRoomList : Form
    {
        public frmRoomList()
        {
            InitializeComponent();
        }
        public DataTable _dtGetRoomData = new DataTable();
        private void _RefreshPeoplList()
        {
            _dtGetRoomData = clsRoom.GetRoomsData();

            if (_dtGetRoomData != null && _dtGetRoomData.Rows.Count > 0)
            {
                dgvRooms.DataSource = _dtGetRoomData;
                lblRecordsCount.Text = dgvRooms.Rows.Count.ToString();
                dgvRooms.AllowUserToAddRows = false;
            }

            cbFilterBy.SelectedIndex = 0;
        }

        private void frmRoomList_Load(object sender, EventArgs e)
        {
            _RefreshPeoplList();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
             string FilterColumn = "";

            switch(cbFilterBy.Text)
            {
                case "Room ID":
                    FilterColumn = "RoomID";
                    break;

                case "Room Name":
                    FilterColumn = "RoomName";
                    break;

                case "Room Type":
                    FilterColumn = "RoomType";
                    break;

                case "Capacity":
                    FilterColumn = "Capacity";
                    break;

                case "Hourly Rate":
                    FilterColumn = "HourlyRate";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if(txtFilterValue.Text.Trim() == "" || cbFilterBy.Text == "None")
            {
                _dtGetRoomData.DefaultView.RowFilter = "";
                lblRecordsCount.Text = _dtGetRoomData.Rows.Count.ToString();
            }

            if (FilterColumn == "RoomID" || FilterColumn == "Capacity" || FilterColumn == "HourlyRate")
            {
                if(!string.IsNullOrEmpty(txtFilterValue.Text))
                {
                    _dtGetRoomData.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
                }
            }
            else
                _dtGetRoomData.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvRooms.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Room ID" || cbFilterBy.Text == "Capacity" || cbFilterBy.Text == "Hourly Rate")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedIndex == 0)
            {
                txtFilterValue.ReadOnly = true;
                txtFilterValue.Text = "";
            }
            else
            {
                txtFilterValue.ReadOnly = false;
                txtFilterValue.Text = "";
            }
        }

        private void tsmAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdateRooms frm = new frmAddUpdateRooms();
            frm.ShowDialog();
            _RefreshPeoplList();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            frmAddUpdateRooms frm = new frmAddUpdateRooms((int)dgvRooms.CurrentRow.Cells[0].Value , frmAddUpdateRooms.enMode.Update);
            frm.ShowDialog();
            _RefreshPeoplList();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Room[" + dgvRooms.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                //Perform Delele and refresh
                if (clsRoom.DeleteRoom((int)dgvRooms.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Room Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeoplList();
                }
                else
                    MessageBox.Show("Room was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            frmAddUpdateRooms frm = new frmAddUpdateRooms((int)dgvRooms.CurrentRow.Cells[0].Value, frmAddUpdateRooms.enMode.Show);
            frm.ShowDialog();
                 
        }
    }
}
