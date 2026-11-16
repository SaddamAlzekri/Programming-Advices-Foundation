using System;
using System.Diagnostics;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBMS_DataAccess
{
    public class clsUserData
    {
        static clsGenericDataAccessMethods GenericMethods = new clsGenericDataAccessMethods();
        
        public static bool GetUserInfoByUserID(int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool IsActive, ref int Permission)
        {
            bool IsFound = false;
            SqlParameter[] ParameterList = new SqlParameter[1];
            ParameterList[0] = new SqlParameter("@UserID", UserID);
            DataTable dtUserData = GenericMethods.ExecuteGetData("SP_GetUserInfoByUserID", ParameterList);

            if( dtUserData.Rows.Count > 0)
            {
                DataRow row = dtUserData.Rows[0];

                PersonID = (int)row["PersonID"];
                UserName = (string)row["UserName"];
                Password = (string)row["Password"];
                IsActive = (bool)row["IsActive"];
                Permission = (int)row["Permission"];

                IsFound = true;
            }
            else
            {
                IsFound = true;
            }
            return IsFound;
        }

        public static bool GetUserInfoByPersonID(int PersonID, ref int UserID, ref string UserName, ref string Password, ref bool IsActive, ref int Permission)
        {
            bool IsFound = false;
            SqlParameter[] ParameterList = new SqlParameter[1];
            ParameterList[0] = new SqlParameter("@PersonID", PersonID);
            DataTable dtUserData = GenericMethods.ExecuteGetData("SP_GetUserInfoByPersonID", ParameterList);

            if (dtUserData.Rows.Count > 0)
            {
                DataRow row = dtUserData.Rows[0];

                UserID = (int)row["UserID"];
                UserName = (string)row["UserName"];
                Password = (string)row["Password"];
                IsActive = (bool)row["IsActive"];
                Permission = (int)row["Permission"];

                IsFound = true;
            }
            else
            {
                IsFound = true;
            }
            return IsFound;
        }

        public static bool GetUserInfoByUsernameAndPassword(string UserName, string Password, ref int UserID, ref int PersonID, ref bool IsActive, ref int Permission)
        {
            bool IsFound = false;
            SqlParameter[] ParameterList = new SqlParameter[2];
            ParameterList[0] = new SqlParameter("@UserName", UserName);
            ParameterList[1] = new SqlParameter("@Password", Password);
            DataTable dtUserData = GenericMethods.ExecuteGetData("SP_GetUserInfoByUsernameAndPassword", ParameterList);

            if (dtUserData.Rows.Count > 0)
            {
                DataRow row = dtUserData.Rows[0];

                UserID = (int)row["UserID"];
                PersonID = (int)row["PersonID"];
                IsActive = (bool)row["IsActive"];
                Permission = (int)row["Permission"];

                IsFound = true;
            }
            else
            {
                IsFound = true;
            }
            return IsFound;
        }

        public static int AddNewUser(int PersonID, string UserName, string Password, bool IsActive, int Permission)
        {
            SqlParameter[] ParameterList = new SqlParameter[5];

            ParameterList[0] = new SqlParameter("@PersonID", PersonID);
            ParameterList[1] = new SqlParameter("@UserName", UserName);
            ParameterList[2] = new SqlParameter("@Password", Password);
            ParameterList[3] = new SqlParameter("@IsActive", IsActive);
            ParameterList[4] = new SqlParameter("@Permission", Permission);

            return GenericMethods.ExecuteInsert("SP_AddNewUser", ParameterList);
        }

        public static bool UpdateUser(int UserID, int PersonID, string UserName, string Password, bool IsActive, int Permission)
        {
            SqlParameter[] ParameterList = new SqlParameter[6];

            ParameterList[0] = new SqlParameter("@UserID", UserID);
            ParameterList[1] = new SqlParameter("@PersonID", PersonID);
            ParameterList[2] = new SqlParameter("@UserName", UserName);
            ParameterList[3] = new SqlParameter("@Password", Password);
            ParameterList[4] = new SqlParameter("@IsActive", IsActive);
            ParameterList[5] = new SqlParameter("@Permission", Permission);

            return GenericMethods.ExecuteUpdate("SP_UpdateUser", ParameterList);
        }
        
        public static DataTable GetAllUsers()
        {
            DataTable dtUserData = GenericMethods.ExecuteGetData("SP_GetAllUsers");

            return dtUserData;
        }

        public static bool DeleteUser(int UserID)
        {
            SqlParameter[] ParameterList = new SqlParameter[1];
            ParameterList[0] = new SqlParameter("@UserID", UserID);
            return GenericMethods.ExecuteDelete("SP_DeleteUser", ParameterList);
        }

        public static bool IsUserExist(int UserID)
        {
            SqlParameter[] ParameterList = new SqlParameter[1];
            ParameterList[0] = new SqlParameter("@UserID", UserID);

            return GenericMethods.IsRecordExists("SP_IsUserExistByUserID", ParameterList);
        }

        public static bool IsUserExist(string UserName)
        {
            SqlParameter[] ParameterList = new SqlParameter[1];
            ParameterList[0] = new SqlParameter("@UserName", UserName);

            return GenericMethods.IsRecordExists("SP_IsUserExistByUserName", ParameterList);
        }

        public static bool IsUserExistForPersonID(int PersonID)
        {
            SqlParameter[] ParameterList = new SqlParameter[1];
            ParameterList[0] = new SqlParameter("@PersonID", PersonID);

            return GenericMethods.IsRecordExists("SP_IsUserExistByPersonID", ParameterList);
        }
        
        public static bool ChanngePassword(int UserID, string NewPassword)
        {
            SqlParameter[] ParameterList = new SqlParameter[2];

            ParameterList[0] = new SqlParameter("@UserID", UserID);
            ParameterList[1] = new SqlParameter("@Password", NewPassword);

            return GenericMethods.ExecuteUpdate("SP_ChanngePassword", ParameterList);
        }

    }
}
