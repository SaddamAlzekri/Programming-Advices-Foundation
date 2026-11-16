using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIBMS_DataAccess;
using System.Data;
using System.Windows.Forms;

namespace LIBMS_Business
{
    public class clsReservationRoom
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int ReservedID { get; set; }
        public int PersonID { get; set; }
        public int RoomID { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public clsReservationRoom()
        {
            ReservedID = -1;
            PersonID = -1;
            RoomID = -1;
            ReservationDate = DateTime.Now;
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
        }

        private clsReservationRoom(int PersonID, int RoomID, DateTime ReservationDate, DateTime StartDate, DateTime EndDate)
        {
            this.PersonID = PersonID;
            this.RoomID = RoomID;
            this.ReservationDate = ReservationDate;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
        }
        public static DataTable GetAllGetAllRoomReservation()
        {
            return clsReservationRoomData.GetAllGetAllRoomReservation();
        }

        public bool AddReservationRoom()
        {
            this.ReservedID = clsReservationRoomData.AddReservationRoom(this.PersonID, this.RoomID);

            return (this.ReservedID != -1);
        }

        public bool UpdateStartDate()
        {
            return clsReservationRoomData.UpdateStartDate(this.ReservedID);
        }

        public bool UpdateEndDate()
        {
            return clsReservationRoomData.UpdateEndTime(this.ReservedID);
        }
        public bool Updatecanceled()
        {
            return clsReservationRoomData.Updatecanceled(this.ReservedID);
        }



    }
}
