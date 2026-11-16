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
    public partial class frmAddUpdateRooms : Form
    {
        public enum enMode {AddNew = 0, Update = 1, Show = 2}
        public enMode Mode = enMode.AddNew;

        public int RoomID { get; set; }
        clsRoom _clsRoom = new clsRoom();
        
        public frmAddUpdateRooms()
        {
            InitializeComponent();
        }

        public frmAddUpdateRooms(int RoomID, enMode frmMode)
        {
            InitializeComponent();
            this.RoomID = RoomID;
            Mode = frmMode;
        }


        private bool ValidateInputs()
{
    if (string.IsNullOrWhiteSpace(txtRoomName.Text))
    {
        MessageBox.Show("Please enter the room name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtRoomName.Focus();
        return false;
    }

    if (cbRoomType.SelectedIndex == -1)
    {
        MessageBox.Show("Please choose a room type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        cbRoomType.Focus();
        return false;
    }

    if (nUPCapacity.Value <= 0)
    {
        MessageBox.Show("Please enter a room capacity greater than 0.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        nUPCapacity.Focus();
        return false;
    }

    if (string.IsNullOrWhiteSpace(txtHourlyRate.Text))
    {
        MessageBox.Show("Please enter the hourly rate.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtHourlyRate.Focus();
        return false;
    }
    
    decimal hourlyRate = 0;
    if (!decimal.TryParse(txtHourlyRate.Text, out hourlyRate))
    {
        MessageBox.Show("Please enter a valid number for the hourly rate.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtHourlyRate.Focus();
        return false;
    }

    return true;
}

        private void LoadData()
        {
            lblTitle.Text = "Update Room";
           _clsRoom = _clsRoom.GetRoomByRoomID(RoomID);
           lblRoomID.Text = RoomID.ToString();
            txtRoomName.Text = _clsRoom._RoomName;
            cbRoomType.Text = _clsRoom._RoomType;
            nUPCapacity.Value = _clsRoom._Capacity;
            txtHourlyRate.Text = _clsRoom._HourlyRate.ToString();

        }

        private void ShowData()
        {
            lblTitle.Text = "Room Info Show";
            button1.Enabled = false;
            txtRoomName.ReadOnly = true;
            txtHourlyRate.ReadOnly = true;
            cbRoomType.Enabled = false;
            nUPCapacity.Enabled = false;

            _clsRoom = _clsRoom.GetRoomByRoomID(RoomID);
            lblRoomID.Text = RoomID.ToString();
            txtRoomName.Text = _clsRoom._RoomName;
            cbRoomType.Text = _clsRoom._RoomType;
            nUPCapacity.Value = _clsRoom._Capacity;
            txtHourlyRate.Text = _clsRoom._HourlyRate.ToString();

        }
        private void frmAddUpdateRooms_Load(object sender, EventArgs e)
        {
            if(Mode == enMode.Update)
            {
                LoadData();
            }else if(Mode == enMode.Show)
            {
                ShowData();
            }
        }

        private void txtHourlyRate_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            if (Mode == enMode.Update)
            {
                _clsRoom._RoomID = RoomID;
            }

            _clsRoom._RoomName = txtRoomName.Text;
            _clsRoom._RoomType = cbRoomType.Text;
            _clsRoom._Capacity = int.Parse(nUPCapacity.Value.ToString());
            _clsRoom._HourlyRate = decimal.Parse(txtHourlyRate.Text);

            if (_clsRoom.Save())
            {
                if(Mode == enMode.AddNew)
                {
                    lblRoomID.Text = _clsRoom._RoomID.ToString();
                    MessageBox.Show("Insert Successfully", "Added Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("Update Successfully", "Update Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

    }
}
