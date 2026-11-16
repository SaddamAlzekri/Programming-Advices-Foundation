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
    public partial class frmRoomLData : Form
    {
        public delegate void DataBackEventHandler(object sender, int RoomID);
        public event DataBackEventHandler DataBack;

        DataTable _dtGetRoomData = new DataTable();

        public frmRoomLData()
        {
            InitializeComponent();
        }

        private void LoadRoomData()
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

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
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

            if (txtFilterValue.Text.Trim() == "" || cbFilterBy.Text == "None")
            {
                _dtGetRoomData.DefaultView.RowFilter = "";
                lblRecordsCount.Text = _dtGetRoomData.Rows.Count.ToString();
            }

            if (FilterColumn == "RoomID" || FilterColumn == "Capacity" || FilterColumn == "HourlyRate")
            {
                if (!string.IsNullOrEmpty(txtFilterValue.Text))
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

        private void frmRoomLData_Load(object sender, EventArgs e)
        {
            LoadRoomData();
        }

        private void btnChose_Click(object sender, EventArgs e)
        {
            int RoomID = (int)dgvRooms.CurrentRow.Cells[0].Value;

            if (DataBack != null)
            {
                DataBack.Invoke(this, RoomID);
            }
            this.Close();
        }
    }
}
