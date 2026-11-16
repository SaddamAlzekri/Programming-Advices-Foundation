using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data;

namespace LIBMS_DataAccess
{
    public class clsPackageData
    {
        static clsGenericDataAccessMethods GenericMethods = new clsGenericDataAccessMethods();

        public static DataTable GetAllPackage()
        {
            DataTable dtPeopleData = GenericMethods.ExecuteGetData("SP_GetAllPackage");

            return dtPeopleData;
        }
        public static bool UpdatePackageInfo(int PackageID, string PackageName, string Description, decimal PackagePrice, int DurationMonths)
        {
            SqlParameter[] ParameterList = new SqlParameter[5];

            ParameterList[0] = new SqlParameter("@PackageID", PackageID);
            ParameterList[1] = new SqlParameter("@PackageName", PackageName);
            ParameterList[2] = new SqlParameter("@Description", Description);
            ParameterList[3] = new SqlParameter("@PackagePrice", PackagePrice);
            ParameterList[4] = new SqlParameter("@DurationMonths", DurationMonths);

            return GenericMethods.ExecuteUpdate("SP_UpdatePackageInfo", ParameterList);
        }
        public static bool GetPackageInfoByPackageID(int PackageID, ref string PackageName, ref string Description, ref decimal PackagePrice, ref int DurationMonths)
        { 
            bool isFound = false;
            SqlParameter[] ParameterList = new SqlParameter[1];
            ParameterList[0] = new SqlParameter("@PackageID", PackageID);
            DataTable dtPersonDataByID = GenericMethods.ExecuteGetData("SP_GetPackageInfoByPackageID", ParameterList);

            if (dtPersonDataByID.Rows.Count > 0)
            {
                DataRow row = dtPersonDataByID.Rows[0];

                PackageName = (string)row["PackageName"];
                Description = (string)row["Description"];
                PackagePrice = (decimal)row["PackagePrice"];
                DurationMonths = (int)row["DurationMonths"];
                isFound = true;
            }else
            {
                isFound = false;
            }
            return isFound;
        }

        public static DataTable GetMemberCardInfoByMemberShipID(int MemberShipID)
        {
            SqlParameter[] ParameterList = new SqlParameter[1];
            ParameterList[0] = new SqlParameter("@TargetID", MemberShipID);
            DataTable dtMemberCardInfo = GenericMethods.ExecuteGetData("SP_GetMemberCardInfo", ParameterList);

            return dtMemberCardInfo;
        }

    }
}
