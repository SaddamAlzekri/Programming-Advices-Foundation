using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIBMS.RoomsReservation;
using LIBMS_Business;

namespace LIBMS.ReservationOfRooms
{
    public partial class frmAddUpdateReservationRooms : Form
    {
        public enum enMode { AddNew = 0, Update = 1}
        public enMode Mode = enMode.AddNew;

        clsReservationRoom _clsReservationRoom = new clsReservationRoom();
        public frmAddUpdateReservationRooms(enMode frmMode)
        {
            InitializeComponent();
            Mode = frmMode;
        }

        private void IntializefrmAddNew()
        {
            btnSave.Location = new Point(757, 472);
            btnClose.Location = new Point(21, 472);
            this.Size = new Size(892, 559);

            lblReservationRoom.Visible = false;
            lblStartDate.Visible = false;
            lblEndDate.Visible = false;
            pictureBox3.Visible = false;
            pictureBox5.Visible = false;

            dtpEndStart.Visible = false;
            dtpReservationDate.Visible = false;
            dtStartDate.Visible = false;
        }

        private void IntializefrmUpdate()
        {

        }

        private void frmAddUpdateReservationRooms_Load(object sender, EventArgs e)
        {
            if(Mode == enMode.AddNew)
            {
                IntializefrmAddNew();
            }else if(Mode == enMode.Update)
            {
                IntializefrmUpdate();
            }
            
        }
        private void Frm_DataBackFromBookItems(object sender, int RoomID)
        {
            lblRoomID.Text = RoomID.ToString();
        }

        private void lblChoosRoomID_Click(object sender, EventArgs e)
        {
            frmRoomLData frm = new frmRoomLData();
            frm.DataBack += Frm_DataBackFromBookItems;
            frm.ShowDialog();
        }

        private bool validation()
        {
            if (ctrlPersonCardWithFilter1.ctrlPersonCard1.lblPersonID.Text != "[????]" && lblRoomID.Text != "[????]")
                return true;

            return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validation())
            {
                MessageBox.Show("Enter the Person and Room Information!!!", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                

            if(Mode == enMode.AddNew)
            {
                _clsReservationRoom.PersonID = int.Parse(ctrlPersonCardWithFilter1.ctrlPersonCard1.lblPersonID.Text);
                _clsReservationRoom.RoomID = int.Parse(lblRoomID.Text);

                if(_clsReservationRoom.AddReservationRoom())
                {
                    lblReservedID.Text = _clsReservationRoom.ReservedID.ToString();

                    MessageBox.Show("Insert Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            }
           

        }
    }
}
