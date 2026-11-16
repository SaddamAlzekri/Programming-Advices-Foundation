using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBMS_DataAccess
{
    public class clsCategoriesData
    {
        static clsGenericDataAccessMethods GenericMethods = new clsGenericDataAccessMethods();
        public static DataTable GetAllCatgories()
        {
            DataTable dtCategories = GenericMethods.ExecuteGetData("SP_GetAllCatgories");

            return dtCategories;
        }

        public static int AddNewCategory(string CategoryName, string Description)
        {
            SqlParameter[] ParameterList = new SqlParameter[2];

            ParameterList[0] = new SqlParameter("@CategoryName", CategoryName);
            ParameterList[1] = new SqlParameter("@Description", Description);

            return GenericMethods.ExecuteInsert("SP_AddCatgories", ParameterList);

        }

        public static bool UpdateCategory(int CategoryID, string CategoryName, string Description)
        {
            SqlParameter[] ParameterList = new SqlParameter[3];

            ParameterList[0] = new SqlParameter("@CategoryID", CategoryID);
            ParameterList[1] = new SqlParameter("@CategoryName", CategoryName);
            ParameterList[2] = new SqlParameter("@Description", Description);

            return GenericMethods.ExecuteUpdate("SP_UpdateCatgories", ParameterList);
        }

        public static bool DeleteCategory(int CategoryID)
        {
            SqlParameter[] ParameterList = new SqlParameter[1];

            ParameterList[0] = new SqlParameter("@CategoryID", CategoryID);

            return GenericMethods.ExecuteDelete("SP_DeleteCatgories", ParameterList);

        }

        public static bool GetCategoryInfoByCategoryID(int CategoryID, ref string CategoryName, ref string Description)
        {
            bool isFound = true;
            SqlParameter[] ParameterList = new SqlParameter[1];
            ParameterList[0] = new SqlParameter("@CateGoryID", CategoryID);
            DataTable dtPersonDataByID = GenericMethods.ExecuteGetData("SP_GetCategoryInfoByCategoryID", ParameterList);

            if (dtPersonDataByID.Rows.Count > 0)
            {
                DataRow row = dtPersonDataByID.Rows[0];

                CategoryName = (string)row["CategoryName"];

                Description = (string)row["Description"];
            }
            else
            {
                isFound = false;
            }
            return isFound;
        }

    }
}
