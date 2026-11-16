using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIBMS_DataAccess;

namespace LIBMS_Business
{
    public class clsSale
    {
        public int SaleDetailID { get; set; }
        public int CustomerID { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int SaleID { get; set; }
        public int BookID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }
        public int AvailableCopies { get; set; }
        public int qnty { get; set; }

        public static DataTable GetAllBookSale()
        {
            return clsSaleData.GetAllBookSale();
        }
        public static DataTable GetBooksAndBookItemsData()
        {
            return clsSaleData.GetBooksAndBookItemsData();
        }

        public bool AddSaleDetails()
        {
            this.SaleDetailID = clsSaleData.AddSaleDetails(this.SaleID, this.BookID, this.Quantity, this.UnitPrice, this.LineTotal);

            return (this.SaleDetailID > 0);
        }

        public bool AddBookSale()
        {
            this.SaleID = clsSaleData.AddBookSale(this.SaleDate, this.TotalAmount, this.CustomerID);

            return (this.SaleID > 0);
        }

        public static DataTable GetDataForInvoiceHeader(int SaleID)
        {
            return clsSaleData.GetDataForInvoiceHeader(SaleID);
        }

        public static DataTable GetDataForInvoiceDetails(int SaleID)
        {
            return clsSaleData.GetDataForInvoiceDetails(SaleID);
        }

        public static bool DeleteInvoiceData(int SaleID)
        {
            return clsSaleData.DeleteInvoiceData(SaleID);
        }

        public static DataTable GetSaleDetailsBySaleID(int SaleID)
        {
            return clsSaleData.GetSaleDetailsBySaleID(SaleID);
        }

        public static bool DeleteSaleDetailsBySaleID(int SaleDetails)
        {
            return clsSaleData.DeleteSaleDetailsBySaleID(SaleDetails);
        }

        public static DataTable GetInvoiceHeader(int SaleID)
        {
            return clsSaleData.GetInvoiceHeader(SaleID);
        }

        public static decimal GetTotalAmount(int SaleID)
        {
            return clsSaleData.GetTotalAmount(SaleID);
        }

        public bool UpdateSaleDetails()
        {
            return clsSaleData.UpdateSaleDetails(this.SaleDetailID, this.SaleID, this.BookID, this.Quantity, this.UnitPrice, this.LineTotal, this.AvailableCopies);
        }
        public bool UpdateTotalAmount()
        {
            return clsSaleData.UpdateTotalAmount(this.SaleID, this.TotalAmount);
        }  
        public bool CheckSaleValid()
        {
            return clsSaleData.CheckSaleValid(this.BookID, this.AvailableCopies);
        }

        public static bool DeleteBookSaleWithStockRestoration(int SaleID)
        {
            return clsBookData.DeleteBookSaleWithStockRestoration(SaleID);
        }

    }

}
