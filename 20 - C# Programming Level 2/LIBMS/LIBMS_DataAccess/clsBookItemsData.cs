using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LIBMS_DataAccess
{
    public class clsBookItemsData
    {
        static clsGenericDataAccessMethods GenericMethods = new clsGenericDataAccessMethods();
        public static DataTable GetAllBookItems()
        {
            DataTable dtCategories = GenericMethods.ExecuteGetData("SP_GETALLBOOKITEMS");

            return dtCategories;
        }

        public static DataTable GETBookItemsByBookID(int BookID)

        {
            SqlParameter[] ParameterList = new SqlParameter[1];

            ParameterList[0] = new SqlParameter("@BookID", BookID);

            DataTable dtBookItems = GenericMethods.ExecuteGetData("SP_GETBookItemsByBookID", ParameterList);

            return dtBookItems;
        }

        public static bool GetBookItems(int ItemID, ref string CopyStatus, ref string LocationRack, ref decimal Price)
        {
            bool isFound = false;
            SqlParameter[] ParameterList = new SqlParameter[1];

            ParameterList[0] = new SqlParameter("@ItemID", ItemID);

            DataTable dtBookItems = GenericMethods.ExecuteGetData("SP_GETBOOKITEMS", ParameterList);

            if(dtBookItems.Rows.Count > 0)
            {
                DataRow row = dtBookItems.Rows[0];

                CopyStatus = (string)row["CopyStatus"];
                LocationRack = row["LocationRack"] is DBNull ? "" :  (string)row["LocationRack"];
                Price = (decimal)row["Price"];

                isFound = true;
            }else
            {
                isFound = false;
            }

            return isFound;
        }
        public static int AddNewBookItems(int BookID, int NumberOfCopies, string CopyStatus,
            string LocationRack, decimal Price)
        {
            SqlParameter[] ParameterList = new SqlParameter[5];

            ParameterList[0] = new SqlParameter("@BookID", BookID);
            ParameterList[1] = new SqlParameter("@NumberOfCopies", NumberOfCopies);
            ParameterList[2] = new SqlParameter("@CopyStatus", CopyStatus);
            ParameterList[3] = new SqlParameter("@LocationRack", (string.IsNullOrEmpty(LocationRack)) ? (object)DBNull.Value : LocationRack);
            ParameterList[4] = new SqlParameter("@Price", Price);

            return GenericMethods.ExecuteInsert("SP_AddBookItems", ParameterList);
        }

        public static bool UpdateBookItems(int ItemID, string CopyStatus,
            string LocationRack, decimal Price)
        {
            SqlParameter[] ParameterList = new SqlParameter[4];

            ParameterList[0] = new SqlParameter("@ItemID", ItemID);
            ParameterList[1] = new SqlParameter("@CopyStatus", CopyStatus);
            ParameterList[2] = new SqlParameter("@LocationRack", (string.IsNullOrEmpty(LocationRack)) ? (object)DBNull.Value : LocationRack);
            ParameterList[3] = new SqlParameter("@Price", Price);

            return GenericMethods.ExecuteUpdate("SP_UpdateBookItems", ParameterList);
        }

    }
}
