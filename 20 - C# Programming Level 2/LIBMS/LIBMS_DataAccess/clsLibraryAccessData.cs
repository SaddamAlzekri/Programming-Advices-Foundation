using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBMS_DataAccess
{
    public class clsLibraryAccessData
    {
        static clsGenericDataAccessMethods GenericMethods = new clsGenericDataAccessMethods();

        public static DataTable GetAllLibraryAccessing()
        {
            DataTable dtGetAllLibraryAccessing = GenericMethods.ExecuteGetData("sp_GetAllLibraryAccessing");

            return dtGetAllLibraryAccessing;
        }

        public static int AddLibraryAccessing(int PersonID, DateTime AccessTime, DateTime? OutTime, string Reason)
        {
            SqlParameter[] ParameterList = new SqlParameter[4];

            ParameterList[0] = new SqlParameter("@PersonID", PersonID);
            ParameterList[1] = new SqlParameter("@AccessTime", AccessTime);
            ParameterList[2] = new SqlParameter("@OutTime", (OutTime == null) ? (object)DBNull.Value : OutTime);
            ParameterList[3] = new SqlParameter("@Reason", Reason);

            return GenericMethods.ExecuteInsert("sp_AddLibraryAccesslog", ParameterList);
        }

        public static bool UpdateLibraryAccesslog(int LogID, DateTime? OutTime)
        {
            SqlParameter[] ParameterList = new SqlParameter[2];

            ParameterList[0] = new SqlParameter("@LogID", LogID);
            ParameterList[1] = new SqlParameter("@OutTime", OutTime);
            
            return GenericMethods.ExecuteUpdate("sp_UpdateLibraryAccesslog", ParameterList);
        }

        public static bool GetLibraryAccesslogByLogID(int LogID, ref DateTime AccessTime, ref DateTime? OutTime, ref string Reason)
        {
            bool isFound = false;
            SqlParameter[] ParameterList = new SqlParameter[1];
            ParameterList[0] = new SqlParameter("@LogID", LogID);
            DataTable dtPersonDataByID = GenericMethods.ExecuteGetData("sp_GetLibraryAccesslogByLogID", ParameterList);


            if (dtPersonDataByID.Rows.Count > 0)
            {
                DataRow row = dtPersonDataByID.Rows[0];

                AccessTime = (DateTime)row["AccessTime"];
                OutTime = (DateTime)row["OutTime"];
                Reason = (string)row["Reason"];

                isFound = true;
            }
            else
            {
                isFound = false;
            }
            return isFound;
        }
        
        
    }
}
