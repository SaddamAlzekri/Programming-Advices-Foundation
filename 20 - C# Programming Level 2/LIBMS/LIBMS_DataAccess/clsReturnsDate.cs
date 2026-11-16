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
    public class clsReturnsDate
    {
        static clsGenericDataAccessMethods GenericMethods = new clsGenericDataAccessMethods();

        public static DataTable BookReturn()
        {
            DataTable dtBookReturn = GenericMethods.ExecuteGetData("SP_BookReturn");

            return dtBookReturn;
        }

        public static DataTable GetBookDetails(int SaleDetailID)
        {
            SqlParameter[] ParameterList = new SqlParameter[1];

            ParameterList[0] = new SqlParameter("@SaleDetailID", SaleDetailID);

            DataTable dtBookReturn = GenericMethods.ExecuteGetData("SP_BookDetails", ParameterList);

            return dtBookReturn;
        }

        public static decimal GetTotalAmountBySaleID(int saleID)
        {
            decimal totalAmount = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetTotalAmountBySaleID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@SaleID", SqlDbType.Int).Value = saleID;

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            totalAmount = Convert.ToDecimal(result);
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

            return totalAmount;
        }

        public static int ProcessBookReturn(int saleID, DateTime returnDate, string reason, decimal refundAmount, DataTable detailsTable)
        {
            int lastValue = -1;
            SqlParameter[] parameters = new SqlParameter[]
        {
            new SqlParameter("@SaleID", saleID),
            new SqlParameter("@ReturnDate", returnDate),
            new SqlParameter("@Reason", reason),
            new SqlParameter("@RefundAmount", refundAmount),
            new SqlParameter("@ReturnDetailsList", detailsTable)
            {
                SqlDbType = SqlDbType.Structured,
                TypeName = "dbo.ReturnDetailsType"
            }
        };

            try
            {
                lastValue = GenericMethods.ExecuteStoredProcedure("dbo.sp_InsertBookReturn", parameters);
            }
            catch(Exception ex)
            {
                string sourceName = "Exception";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }

                EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Error);
            }
            return lastValue;
        }

        public static DataTable GetDataForReturnInvoiceHeader(int ReturnID)
        {
            SqlParameter[] ParameterList = new SqlParameter[1];

            ParameterList[0] = new SqlParameter("@ReturnID", ReturnID);

            DataTable dtInvoiceHeader = GenericMethods.ExecuteGetData("SP_GetDataForReturnInvoiceHeader", ParameterList);

            return dtInvoiceHeader;
        }

        public static DataTable GetDataForReturnInvoiceDetails(int ReturnID)
        {
            SqlParameter[] ParameterList = new SqlParameter[1];

            ParameterList[0] = new SqlParameter("@ReturnID", ReturnID);

            DataTable dtInvoiceDetails = GenericMethods.ExecuteGetData("SP_GetDataForReturnInvoiceDetails", ParameterList);

            return dtInvoiceDetails;
        }


    }
}
