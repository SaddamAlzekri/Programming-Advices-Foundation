
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBMS_DataAccess
{
    public class clsCountryData
    {
        static clsGenericDataAccessMethods GenericMethods = new clsGenericDataAccessMethods();
        public static bool GetCountryInfoByID(int CountryID, ref string CountryName)
        {
            bool IsFound = false;
            SqlParameter[] ParameterList = new SqlParameter[1];
            ParameterList[0] = new SqlParameter("@CountryID", CountryID);
            DataTable dtUserData = GenericMethods.ExecuteGetData("GetCountryInfoByID", ParameterList);

            if (dtUserData.Rows.Count > 0)
            {
                DataRow row = dtUserData.Rows[0];

                CountryName = (string)row["CountryName"];

                IsFound = true;
            }
            else
            {
                IsFound = true;
            }

            return IsFound;
        }

        public static bool GetCountryInfoByName(string CountryName, ref int ID)
        {
            bool IsFound = false;
            SqlParameter[] ParameterList = new SqlParameter[1];
            ParameterList[0] = new SqlParameter("@CountryName", CountryName);
            DataTable dtUserData = GenericMethods.ExecuteGetData("GetCountryInfoByName", ParameterList);

            if (dtUserData.Rows.Count > 0)
            {
                DataRow row = dtUserData.Rows[0];

                ID = (int)row["CountryID"];

                IsFound = true;
            }
            else
            {
                IsFound = true;
            }

            return IsFound;
        }

        public static DataTable GetAllCountries()
        {
            DataTable dtUserData = GenericMethods.ExecuteGetData("SP_GetAllCountries");

            return dtUserData;
        }

    }
}
