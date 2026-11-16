using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIBMS_DataAccess;

namespace LIBMS_Business
{
    public class clsBookItems
    {
        public enum enMode { AddNew = 1, Update = 2}
        public enMode Mode = enMode.AddNew;

        public int ItemID { set; get; }
        public int BookID { set; get; }
        public string SerialNumber { set; get; }
        public int NumberOfCopies { set; get; }
        public string CopyStatus { set; get; }
        public string LocationRack { set; get; }
        public decimal Price { set; get; }

        public clsBookItems()
        {
            this.ItemID = -1;
            this.BookID = -1;
            this.SerialNumber = "";
            this.NumberOfCopies = -1;
            this.CopyStatus = "";
            this.LocationRack = "";
            this.Price = 0;

            Mode = enMode.AddNew;
        }

        public clsBookItems(int ItemID,int NumberOfCopies, string CopyStatus, string LocationRack, decimal Price)
        {
            this.ItemID = ItemID;
            this.NumberOfCopies = NumberOfCopies;
            this.CopyStatus = CopyStatus;
            this.LocationRack = LocationRack;
            this.Price = Price;

            Mode = enMode.Update;
        }
        public clsBookItems(int ItemID, string CopyStatus, string LocationRack, decimal Price)
        {
            this.ItemID = ItemID;
            this.CopyStatus = CopyStatus;
            this.LocationRack = LocationRack;
            this.Price = Price;

            Mode = enMode.Update;
        }

        public static DataTable GetAllBookItems()
        {
            return clsBookItemsData.GetAllBookItems();
        }

        public static DataTable GETBookItemsByBookID(int BookID)
        {
            return clsBookItemsData.GETBookItemsByBookID(BookID);
        }

        public static clsBookItems GetBookItems(int ItemID)
        {
            int NumberOfCopies = 0;  decimal Price = 0;
            string CopyStatus = "", LocationRack = "";

            bool Found = clsBookItemsData.GetBookItems(ItemID, ref CopyStatus, ref LocationRack, ref Price);
            if(Found)
            {
                return new clsBookItems(ItemID,NumberOfCopies, CopyStatus, LocationRack, Price);
            }else
            {
                return null;
            }
        }

        private bool AddNewBookItems()
        {
            this.ItemID = clsBookItemsData.AddNewBookItems(BookID, NumberOfCopies, CopyStatus,
                LocationRack, Price);
            return (this.ItemID > 0);
        }

        private bool UpdateBookItems()
        {
            return clsBookItemsData.UpdateBookItems(ItemID, CopyStatus, LocationRack, Price);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewBookItems())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return UpdateBookItems();
            }
            return false;
        }

    }
}
