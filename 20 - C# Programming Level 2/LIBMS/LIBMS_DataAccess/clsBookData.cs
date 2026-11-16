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
    public class clsBookData
    {
        static clsGenericDataAccessMethods GenericMethods = new clsGenericDataAccessMethods();
        
        public static DataTable GetAllCatgories()
        {
            DataTable dtCategories = GenericMethods.ExecuteGetData("SP_GetAllbOOKS");

            return dtCategories;
        }
        public static int AddNewBook(string ISBN, string Title, int PublicationYear, int AvailableCopies, int CategoryID, 
            string CoverPath, int PersonID)
        {
            SqlParameter[] ParameterList = new SqlParameter[7];

            ParameterList[0] = new SqlParameter("@ISBN", ISBN);
            ParameterList[1] = new SqlParameter("@Title", Title);
            ParameterList[2] = new SqlParameter("@PublicationYear", PublicationYear);
            ParameterList[3] = new SqlParameter("@AvailableCopies", AvailableCopies);
            ParameterList[4] = new SqlParameter("@CateGoryID", CategoryID);
            ParameterList[5] = new SqlParameter("@CoverPath", (string.IsNullOrEmpty(CoverPath)) ? (object)DBNull.Value : CoverPath);
            ParameterList[6] = new SqlParameter("@PersonID", PersonID);

            return GenericMethods.ExecuteInsert("SP_AddBooks", ParameterList);

        }
        public static int GetLastSequanceOfBookItems(int BookID)
        {
            int lastSequance = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetLastSequanceOfBookItems", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BookID", BookID);
                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();
                        int vTtryParse = 0;
                        if(result != null && int.TryParse(result.ToString(), out vTtryParse))
                        {
                            lastSequance = vTtryParse;
                        }
                    }
                    catch (Exception ex)
                    {
                        string sourceName = "Exception";
                        if (!EventLog.SourceExists(sourceName))
                        {
                            EventLog.CreateEventSource(sourceName, "Application");
                        }

                        EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Error);
                    }
                }
            }
            return lastSequance;
        }

        //public static int AddNewBookItems(int BookID, string SerialNumber, int NumberOfCopies, string CopyStatus,
        //    string LocationRack , decimal Price) 
        //{
        //    SqlParameter[] ParameterList = new SqlParameter[6];

        //    ParameterList[0] = new SqlParameter("@BookID", BookID);
        //    ParameterList[1] = new SqlParameter("@SerialNumber", SerialNumber);
        //    ParameterList[2] = new SqlParameter("@NumberOfCopies", NumberOfCopies);
        //    ParameterList[3] = new SqlParameter("@CopyStatus", CopyStatus);
        //    ParameterList[4] = new SqlParameter("@LocationRack", (string.IsNullOrEmpty(LocationRack)) ? (object)DBNull.Value : LocationRack);
        //    ParameterList[5] = new SqlParameter("@Price", Price);

        //    return GenericMethods.ExecuteInsert("SP_AddBookItems", ParameterList);
        //}
        public static bool UpdateBook(int BookID, string ISBN, string Title, int PublicationYear, int AvailableCopies, int CategoryID, string CoverPath,int PersonID, int AuthorID)
        {
            SqlParameter[] ParameterList = new SqlParameter[9];

            ParameterList[0] = new SqlParameter("@BookID", BookID);
            ParameterList[1] = new SqlParameter("@ISBN", ISBN);
            ParameterList[2] = new SqlParameter("@Title", Title);
            ParameterList[3] = new SqlParameter("@PublicationYear", PublicationYear);
            ParameterList[4] = new SqlParameter("@AvailableCopies", AvailableCopies);
            ParameterList[5] = new SqlParameter("@CateGoryID", CategoryID);
            ParameterList[6] = new SqlParameter("@CoverPath", (string.IsNullOrEmpty(CoverPath)) ? (object)DBNull.Value : CoverPath);
            ParameterList[7] = new SqlParameter("@PersonID", PersonID);
            ParameterList[8] = new SqlParameter("@AuthorID", AuthorID);

            return GenericMethods.ExecuteUpdate("SP_UpdateBooks", ParameterList);

        }

        public static bool DeleteBook(int BookID, int AuthorID, int BookAuthors)
        {
            SqlParameter[] ParameterList = new SqlParameter[3];

            ParameterList[0] = new SqlParameter("@BookID", BookID);
            ParameterList[1] = new SqlParameter("@AuthorID", AuthorID);
            ParameterList[2] = new SqlParameter("@BookAuthors", BookAuthors);

            return GenericMethods.ExecuteDelete("SP_DeleteBook", ParameterList);
        }
        public static bool GetBookInfoByBookID(int BookID, ref string ISBN, ref string Title, ref int PublicationYear,
            ref int AvailableCopies, ref int CategoryID, ref string CategoryName, ref string Description, ref string CoverPath, ref int PersonID, ref string AuthorName)
        {
            bool isFound = false;
            SqlParameter[] ParameterList = new SqlParameter[1];
            ParameterList[0] = new SqlParameter("@BookAuthorID", BookID);
            DataTable dtPersonDataByID = GenericMethods.ExecuteGetData("SP_GetBookInfoByBookID", ParameterList);
            

            if (dtPersonDataByID.Rows.Count > 0)
            {
                DataRow row = dtPersonDataByID.Rows[0];

                ISBN = (string)row["ISBN"];

                Title = (string)row["Title"];
                PublicationYear = (int)row["PublicationYear"];
                AvailableCopies = (int)row["AvailableCopies"];

                CategoryID = (int)row["CategoryID"];
                CategoryName = (string)row["CateGoryName"];
                Description = (string)row["Description"];
                CoverPath = (string)row["CoverPath"];
                PersonID = (int)row["PersonID"];
                AuthorName = (string)row["AuthorName"];

                isFound = true;
            }
            else
            {
                isFound = false;
            }
            return isFound;
        }
        
        
        public static DataTable GetAllCategoryName()
        {
            DataTable dtCategoriesName = GenericMethods.ExecuteGetData("SP_GetAllCategoryName");

            return dtCategoriesName;
        }

        public static bool DeleteBookSaleWithStockRestoration(int SaleID)
        {
            SqlParameter[] ParameterList = new SqlParameter[1];

            ParameterList[0] = new SqlParameter("@SaleID", SaleID);

            return GenericMethods.ExecuteDelete("SP_DeleteBookSaleWithStockRestoration", ParameterList);
        }

    }
}
