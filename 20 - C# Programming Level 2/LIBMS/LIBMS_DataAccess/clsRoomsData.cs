using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBMS_DataAccess
{
    public class clsRoomsData
    {
        static clsGenericDataAccessMethods GenericMethods = new clsGenericDataAccessMethods();

        public static DataTable GetRoomsData()
        {
            DataTable dtGetRoomsData = GenericMethods.ExecuteGetData("sp_GetRoomsData");

            return dtGetRoomsData;
        }

        public static int AddRoom(string RoomName, string RoomType, int capacity, decimal HourlyRate)
        {
            SqlParameter[] ParameterList = new SqlParameter[4];

            ParameterList[0] = new SqlParameter("@RoomName", RoomName);
            ParameterList[1] = new SqlParameter("@RoomType", RoomType);
            ParameterList[2] = new SqlParameter("@capacity", capacity);
            ParameterList[3] = new SqlParameter("@HourlyRate", HourlyRate);

            return GenericMethods.ExecuteInsert("sp_AddRoom", ParameterList);
        }

        public static bool UpdateRoom(int RoomID, string RoomName, string RoomType, int capacity, decimal HourlyRate)
        {
            SqlParameter[] ParameterList = new SqlParameter[5];

            ParameterList[0] = new SqlParameter("@RoomID", RoomID);
            ParameterList[1] = new SqlParameter("@RoomName", RoomName);
            ParameterList[2] = new SqlParameter("@RoomType", RoomType);
            ParameterList[3] = new SqlParameter("@capacity", capacity);
            ParameterList[4] = new SqlParameter("@HourlyRate", HourlyRate);

            return GenericMethods.ExecuteUpdate("sp_UpdateRoom", ParameterList);
        }


        public static bool GetRoomByRoomID(int RoomID, ref string RoomName, ref string RoomType, ref int capacity, ref decimal HourlyRate)
        {
            bool isFound = false;

            SqlParameter[] ParameterList = new SqlParameter[1];

            ParameterList[0] = new SqlParameter("@RoomID", RoomID);

            DataTable dtRoomsByRoomID = GenericMethods.ExecuteGetData("sp_GetRoomByRoomID", ParameterList);

            if (dtRoomsByRoomID.Rows.Count > 0)
            {
                DataRow row = dtRoomsByRoomID.Rows[0];


                RoomName = (string)row["RoomName"];
                RoomType = (string)row["RoomType"];
                capacity = (int)row["capacity"];
                HourlyRate = (decimal)row["HourlyRate"];
                isFound = true;
            }
            else
            {
                isFound = false;
            }
            return isFound;
        }

        public static bool DeleteRoom(int RoomID)
        {
            SqlParameter[] ParameterList = new SqlParameter[1];

            ParameterList[0] = new SqlParameter("@RoomID", RoomID);

            return GenericMethods.ExecuteDelete("sp_DeleteRoom", ParameterList);
        }


    }
}
