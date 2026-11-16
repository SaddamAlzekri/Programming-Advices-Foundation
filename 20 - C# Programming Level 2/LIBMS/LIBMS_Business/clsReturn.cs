using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIBMS_DataAccess;
using System.Data;

namespace LIBMS_Business
{
    public class clsReturn
    {
        public static int newReturnID = 1;
        
        public static DataTable GetAllBookReturn()
        {
            return clsReturnsDate.BookReturn();
        }

        public static DataTable GetBookDetails(int SaleDetailID)
        {
            return clsReturnsDate.GetBookDetails(SaleDetailID);
        }

        public static decimal GetTotalAmountBySaleID(int saleID)
        {
            return clsReturnsDate.GetTotalAmountBySaleID(saleID);

        }

        public static bool ProcessBookReturn(int saleID, DateTime returnDate, string reason, decimal refundAmount, DataTable detailsTable)
        {
            newReturnID = clsReturnsDate.ProcessBookReturn(saleID, returnDate, reason, refundAmount, detailsTable);

            return (newReturnID != -1);
        }

        public static DataTable GetDataForReturnInvoiceHeader(int ReturnID)
        {
            return clsReturnsDate.GetDataForReturnInvoiceHeader(ReturnID);
        }

        public static DataTable GetDataForReturnInvoiceDetails(int ReturnID)
        {
            return clsReturnsDate.GetDataForReturnInvoiceDetails(ReturnID);
        }

    }
}
