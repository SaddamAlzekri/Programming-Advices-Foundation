using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBMS_DataAccess
{
    public class clsReservationRoomData
    {
        static clsGenericDataAccessMethods GenericMethods = new clsGenericDataAccessMethods();

        public static DataTable GetAllGetAllRoomReservation()
        {
            DataTable dtCategories = GenericMethods.ExecuteGetData("sp_GetAllRoomReservation");

            return dtCategories;
        }

        public static int AddReservationRoom(int PersonID, int RoomID)
        {
            SqlParameter[] ParameterList = new SqlParameter[2];

            ParameterList[0] = new SqlParameter("@PersonID", PersonID);
            ParameterList[1] = new SqlParameter("@RoomID", RoomID);

            return GenericMethods.ExecuteInsert("sp_AddReservationRoom", ParameterList);
        }

        public static bool UpdateStartDate(int ReservationID)
        {
            SqlParameter[] ParameterList = new SqlParameter[1];

            ParameterList[0] = new SqlParameter("@ReservationID", ReservationID);

            return GenericMethods.ExecuteUpdate("sp_UpdateStartDate", ParameterList);
        }

        public static bool UpdateEndTime(int ReservationID)
        {
            SqlParameter[] ParameterList = new SqlParameter[1];

            ParameterList[0] = new SqlParameter("@ReservationID", ReservationID);

            return GenericMethods.ExecuteUpdate("sp_UpdateEndTime", ParameterList);
        }

        public static bool Updatecanceled(int ReservationID)
        {
            SqlParameter[] ParameterList = new SqlParameter[1];

            ParameterList[0] = new SqlParameter("@ReservationID", ReservationID);

            return GenericMethods.ExecuteUpdate("sp_UpdateCancel", ParameterList);
        }

    }
}
