using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;


namespace LIBMS_DataAccess
{
    public class clsMembersData
    {
        static clsGenericDataAccessMethods GenericMethods = new clsGenericDataAccessMethods();
        public static int AddNewMember(int PersonID, int PackageID, DateTime StartDate, DateTime EndDate, bool IsActive)
        {
            SqlParameter[] ParameterList = new SqlParameter[5];

            ParameterList[0] = new SqlParameter("@PersonID", PersonID);
            ParameterList[1] = new SqlParameter("@PackageID", PackageID);
            ParameterList[2] = new SqlParameter("@StartDate", StartDate);
            ParameterList[3] = new SqlParameter("@EndDate", EndDate);
            ParameterList[4] = new SqlParameter("@IsActive", IsActive);

            return GenericMethods.ExecuteInsert("SP_AddNewMember", ParameterList);

        }

        public static bool UpdateMember(int MemberShipID, int PersonID, int PackageID, DateTime StartDate, DateTime EndDate, bool IsActive)
        {
            SqlParameter[] ParameterList = new SqlParameter[6];

            ParameterList[0] = new SqlParameter("@MemberShipID", MemberShipID);
            ParameterList[1] = new SqlParameter("@PersonID", PersonID);
            ParameterList[2] = new SqlParameter("@PackageID", PackageID);
            ParameterList[3] = new SqlParameter("@StartDate", StartDate);
            ParameterList[4] = new SqlParameter("@EndDate", EndDate);
            ParameterList[5] = new SqlParameter("@IsActive", IsActive);

            return GenericMethods.ExecuteUpdate("SP_UpdateMember", ParameterList);
        }

        public static DataTable GetAllMembers()
        {
            DataTable dtPeopleData = GenericMethods.ExecuteGetData("SP_GetAllMembers");

            return dtPeopleData;
        }

        public static bool DeleteMember(int MemberShipID)
        {
            SqlParameter[] ParameterList = new SqlParameter[1];
            ParameterList[0] = new SqlParameter("@MemberShipID", MemberShipID);
            return GenericMethods.ExecuteDelete("SP_DeleteMember", ParameterList);
        }

        public static bool IsPersonIDExist(int PersonID)
        {
            SqlParameter[] ParameterList = new SqlParameter[1];
            ParameterList[0] = new SqlParameter("@PersonID", PersonID);

            return GenericMethods.IsRecordExists("SP_IsMemberExisByPersonIDID", ParameterList);
        }

        public static bool GetMemberInfoByMemberShipID(int MemberShipID, ref int PersonID, ref int PackageID, ref DateTime StartDate, ref DateTime EndDate, ref bool IsActive)
        {
            bool isFound = false;
            SqlParameter[] ParameterList = new SqlParameter[1];
            ParameterList[0] = new SqlParameter("@MemberShipID", MemberShipID);
            DataTable dtMemberDataByID = GenericMethods.ExecuteGetData("SP_GetMemberInfoByMemberShipID", ParameterList);

            if (dtMemberDataByID.Rows.Count > 0)
            {
                DataRow row = dtMemberDataByID.Rows[0];

                PersonID = (int)row["PersonID"];

                PackageID = (int)row["PackageID"];
                StartDate = Convert.ToDateTime(row["StartDate"]);
                EndDate = Convert.ToDateTime(row["EndDate"]);
                IsActive = Convert.ToBoolean(row["IsActive"]);

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
