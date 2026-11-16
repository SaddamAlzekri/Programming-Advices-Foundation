using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBMS_DataAccess
{
    public class clsReasonSessionData
    {
        static clsGenericDataAccessMethods GenericMethods = new clsGenericDataAccessMethods();

        public static DataTable GetAllReadingSession()
        {
            DataTable dtGetAllReadingSession = GenericMethods.ExecuteGetData("SP_GetAllReadingSession");

            return dtGetAllReadingSession;
        }

        public static int AddNewReadingSession(int MemberID, int BookID, DateTime StartTime, DateTime EndTime, string Status, string ReasonOfCancel)
        {
            SqlParameter[] ParameterList = new SqlParameter[6];

            ParameterList[0] = new SqlParameter("@MemberID", MemberID);
            ParameterList[1] = new SqlParameter("@BookID", BookID);
            ParameterList[2] = new SqlParameter("@StartTime", StartTime);
            ParameterList[3] = new SqlParameter("@EndTime", DBNull.Value);
            ParameterList[4] = new SqlParameter("@Status", Status);
            ParameterList[5] = new SqlParameter("@ReasonOfCancel", (string.IsNullOrEmpty(ReasonOfCancel)) ? (object)DBNull.Value : ReasonOfCancel);

            return GenericMethods.ExecuteInsert("SP_AddNewReadingSession", ParameterList);
        }

        public static bool CancelledOfReadingSession(int SessionID,DateTime EndTime, string Status, string ReasonOfCancel)
        {
            SqlParameter[] ParameterList = new SqlParameter[4];

            ParameterList[0] = new SqlParameter("@SessionID", SessionID);
            ParameterList[1] = new SqlParameter("@EndTime", (object)EndTime ?? DBNull.Value);
            ParameterList[2] = new SqlParameter("@Status", Status);
            ParameterList[3] = new SqlParameter("@ReasonOfCancel", (string.IsNullOrEmpty(ReasonOfCancel)) ? (object)DBNull.Value : ReasonOfCancel);

            return GenericMethods.ExecuteUpdate("SP_CancelledOfReadingSession", ParameterList);
        }

        public static bool CompletedOfReadingSession(int SessionID, DateTime EndTime, string Status)
        {
            SqlParameter[] ParameterList = new SqlParameter[3];

            ParameterList[0] = new SqlParameter("@SessionID", SessionID);
            ParameterList[1] = new SqlParameter("@EndTime", (object)EndTime ?? DBNull.Value);
            ParameterList[2] = new SqlParameter("@Status", Status);

            return GenericMethods.ExecuteUpdate("SP_CompletedOfReadingSession", ParameterList);
        }

        public static DataTable GetReasonSessionInfo(int SessionID)
        {

            SqlParameter[] ParameterList = new SqlParameter[1];

            ParameterList[0] = new SqlParameter("@SessionID", SessionID);
            DataTable dtGetReasonSessionInfo = GenericMethods.ExecuteGetData("SP_GetAllReadingSession", ParameterList);

            return dtGetReasonSessionInfo;
        }

        public static DataTable GetBooksInfo(int MemberID)
        {

            SqlParameter[] ParameterList = new SqlParameter[1];

            ParameterList[0] = new SqlParameter("@MemberID", MemberID);
            DataTable dtGetBooksInfo = GenericMethods.ExecuteGetData("SP_GetBooksInfo", ParameterList);

            return dtGetBooksInfo;
        }

        public static DataTable GetMemberInfo(int MemberShipID)
        {

            SqlParameter[] ParameterList = new SqlParameter[1];

            ParameterList[0] = new SqlParameter("@MemberShipID", MemberShipID);
            DataTable dtGetMemberInfo = GenericMethods.ExecuteGetData("SP_GetMemberInfo", ParameterList);

            return dtGetMemberInfo;
        }
    }
}