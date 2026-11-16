using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIBMS_DataAccess;
using System.Data;
using LIBMS_DataAccess;
using System.Windows.Forms;

namespace LIBMS_Business
{
    public class clsRoom
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int _RoomID { get; set; }
        public string _RoomName { get; set; }
        public string _RoomType { get; set; }
        public int _Capacity { get; set; }
        public decimal _HourlyRate { get; set; }

        public clsRoom()
        {
            this._RoomID = -1;
            this._RoomName = "";
            this._RoomType = "";
            this._Capacity = -1;
            this._HourlyRate = 1;

            Mode = enMode.AddNew;
        }

        private clsRoom(int RoomID, string RoomName, string RoomType, int Capacity, decimal HourlyRate)
        {
            this._RoomID = RoomID;
            this._RoomName = RoomName;
            this._RoomType = RoomType;
            this._Capacity = Capacity;
            this._HourlyRate = HourlyRate;

            Mode = enMode.Update;
        }

        public static DataTable GetRoomsData()
        {
            return clsRoomsData.GetRoomsData();
        }

        private bool AddRoom()
        {
            this._RoomID = clsRoomsData.AddRoom(this._RoomName, this._RoomType, this._Capacity, this._HourlyRate);

            return (this._RoomID != -1);
        }

        private bool Update()
        {
            return clsRoomsData.UpdateRoom( _RoomID ,this._RoomName, this._RoomType, this._Capacity, this._HourlyRate);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddRoom())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return Update();
            }
            return false;
        }

        public clsRoom GetRoomByRoomID(int RoomID)
        {
            int Capacity = 0;
            string RoomName = "", RoomType = "";
            decimal HourlyRate = 1;

            bool isFound = clsRoomsData.GetRoomByRoomID(RoomID, ref RoomName, ref RoomType, ref Capacity, ref HourlyRate);
            if(isFound)
            {
                return new clsRoom(RoomID, RoomName, RoomType, Capacity, HourlyRate);
            }else
            {
                return null;
            }
        }

        public static bool DeleteRoom(int RoomID)
        {
            return clsRoomsData.DeleteRoom(RoomID);
        }
    }
}
