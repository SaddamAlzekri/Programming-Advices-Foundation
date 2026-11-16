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
    public class clsSaleData
    {
        static clsGenericDataAccessMethods GenericMethods = new clsGenericDataAccessMethods();

        public static DataTable GetAllBookSale()
        {
            DataTable dtCategories = GenericMethods.ExecuteGetData("SP_GetBookSale");

            return dtCategories;
        }

        public static DataTable GetBooksAndBookItemsData()
        {
            DataTable dtCategories = GenericMethods.ExecuteGetData("SP_GetBooksData");

            return dtCategories;
        }

        public static int AddBookSale(DateTime SaleDate, decimal TotalAmount, int PersonID)
        {
            SqlParameter[] ParameterList = new SqlParameter[3];

            ParameterList[0] = new SqlParameter("@SaleDate", SaleDate);
            ParameterList[1] = new SqlParameter("@TotalAmount", TotalAmount);
            ParameterList[2] = new SqlParameter("@PersonID", PersonID);

            return GenericMethods.ExecuteInsert("SP_AddBookSale", ParameterList);
        }

        public static int AddSaleDetails(int SaleID, int BookID, int Quantity, decimal UnitPrice, decimal LineTotal)
        {
            SqlParameter[] ParameterList = new SqlParameter[5];

            ParameterList[0] = new SqlParameter("@SaleID", SaleID);
            ParameterList[1] = new SqlParameter("@BookID", BookID);
            ParameterList[2] = new SqlParameter("@Quantity", Quantity);
            ParameterList[3] = new SqlParameter("@UnitPrice", UnitPrice);
            ParameterList[4] = new SqlParameter("@LineTotal", LineTotal);

            return GenericMethods.ExecuteInsert("SP_AddSaleDetails", ParameterList);
        }

        public static DataTable GetDataForInvoiceHeader(int SaleID)
        {
            SqlParameter[] ParameterList = new SqlParameter[1];

            ParameterList[0] = new SqlParameter("@SaleID", SaleID);

            DataTable dtInvoiceHeader = GenericMethods.ExecuteGetData("SP_GetDataForInvoiceHeader", ParameterList);

            return dtInvoiceHeader;
        }

        public static DataTable GetDataForInvoiceDetails(int SaleID)
        {
            SqlParameter[] ParameterList = new SqlParameter[1];

            ParameterList[0] = new SqlParameter("@SaleID", SaleID);

            DataTable dtInvoiceDetails = GenericMethods.ExecuteGetData("SP_GetDataForInvoiceDetails", ParameterList);

            return dtInvoiceDetails;
        }

        public static bool DeleteInvoiceData(int SaleID)
        {
            SqlParameter[] ParameterList = new SqlParameter[1];

            ParameterList[0] = new SqlParameter("@SaleID", SaleID);

            return GenericMethods.ExecuteDelete("SP_DeleteInvoiceData", ParameterList);
        }

        public static DataTable GetSaleDetailsBySaleID(int SaleID)
        {
            SqlParameter[] ParameterList = new SqlParameter[1];

            ParameterList[0] = new SqlParameter("@SaleID", SaleID);

            DataTable dtGetSaleDetailsBySaleID = GenericMethods.ExecuteGetData("SP_GetSaleDetailsBySaleID", ParameterList);

            return dtGetSaleDetailsBySaleID;
        }

        public static bool DeleteSaleDetailsBySaleID(int SaleDetailID)
        {
            SqlParameter[] ParameterList = new SqlParameter[1];

            ParameterList[0] = new SqlParameter("@SaleDetailID", SaleDetailID);

            return GenericMethods.ExecuteDelete("SP_DeleteSaleDetailsBySaleID", ParameterList);
        }

        public static DataTable GetInvoiceHeader(int SaleID)
        {
            SqlParameter[] ParameterList = new SqlParameter[1];

            ParameterList[0] = new SqlParameter("@SaleID", SaleID);

            DataTable dtGetInvoiceHeader = GenericMethods.ExecuteGetData("SP_GetInvoiceHeader", ParameterList);

            return dtGetInvoiceHeader;
        }

        public static decimal GetTotalAmount(int SaleID)
        {
            decimal LastPersonID = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetTotalAmount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    
                    command.Parameters.AddWithValue("@SaleID", SaleID);
                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();
                        decimal ResultID = -1;
                        if (Result != null && decimal.TryParse(Result.ToString(), out ResultID))
                        {
                            LastPersonID = ResultID;
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
            return LastPersonID;
        }

        public static bool UpdateSaleDetails(int SaleDetailsID, int SaleID, int BookID, int Quantity, decimal UnitPrice, decimal LineTotal, int AvailableCopies)
        {
            SqlParameter[] ParameterList = new SqlParameter[7];

            ParameterList[0] = new SqlParameter("@SaleDetailsID", SaleDetailsID);
            ParameterList[1] = new SqlParameter("@SaleID", SaleID);
            ParameterList[2] = new SqlParameter("@BookID", BookID);
            ParameterList[3] = new SqlParameter("@Quantity", Quantity);
            ParameterList[4] = new SqlParameter("@UnitPrice", UnitPrice);
            ParameterList[5] = new SqlParameter("@LineTotal", LineTotal);
            ParameterList[6] = new SqlParameter("@AvailableCopies", AvailableCopies);

            return GenericMethods.ExecuteUpdate("SP_UpdateSaleDetails", ParameterList);

        }

        public static bool UpdateTotalAmount(int SaleID, decimal TotalAmount)
        {
            SqlParameter[] ParameterList = new SqlParameter[2];

            ParameterList[0] = new SqlParameter("@SaleID", SaleID);
            ParameterList[1] = new SqlParameter("@TotalAmount", TotalAmount);

            return GenericMethods.ExecuteUpdate("SP_UpdateTotalAmount", ParameterList);

        }

        public static bool CheckSaleValid(int bookId, int qty)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("sp_CheckSaleValid", connection))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BookID", bookId);
                    cmd.Parameters.AddWithValue("@RequestedQty", qty);

                    connection.Open();

                    result = Convert.ToInt32(cmd.ExecuteScalar());
                }catch (Exception ex)
                {
                    string sourceName = "Exception";
                    if (!EventLog.SourceExists(sourceName))
                    {
                        EventLog.CreateEventSource(sourceName, "Application");
                    }
                    EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Error);
                }
            }
                return result == 1;
        }

    }
}