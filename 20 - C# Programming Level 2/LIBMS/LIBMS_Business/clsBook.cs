using System;
using LIBMS_DataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace LIBMS_Business
{
    public class clsBook
    {
        public enum enMode { AddNew = 0, Update = 1}
        private enMode Mode = enMode.AddNew;

        public int BookID { set; get; }
        public int BookItems { set; get; }
        public string CategoryName { set; get; }
        public string Description { set; get; }
        public string ISBN { set; get; }
        public string Title { set; get; }
        public int PublicationYear { set; get; }
        public int AvailableCopies { set; get; }
        public int CategoryID { set; get; }
        public string CoverPath { set; get; }
        public int PersonID { set; get; }
        public int AuthorID { set; get; }
        public string AuthorName { set; get; }
        public string SerialNumber { set; get; }
        public int NumberOfCopies { set; get; }
        public string CopyStatus { set; get; }
        public string LocationRack { set; get; }
        public decimal Price { set; get; }

        public clsBook()
        {
            this.BookID = -1;
            this.ISBN = "";
            this.Title = "";
            this.PublicationYear = -1;
            this.AvailableCopies = -1;
            this.CategoryID = -1;
            this.CategoryName = "";
            this.Description = "";
            this.CoverPath = "";
            this.PersonID = -1;
            this.AuthorName = "";

            Mode = enMode.AddNew;
        }

        private clsBook(int BookID, string ISBN, string Title, int PublicationYear, int AvailableCopies, int CategoryID, string CoverPath, int PersonID, string AuthorName, string CategoryName = "",  string Description = "")
        {
            this.BookID = BookID;
            this.ISBN = ISBN;
            this.Title = Title;
            this.PublicationYear = PublicationYear;
            this.AvailableCopies = AvailableCopies;
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;
            this.Description = Description;
            this.CoverPath = CoverPath;
            this.PersonID = PersonID;
            this.AuthorName = AuthorName;

            Mode = enMode.Update;
        }

        public static DataTable GetAllBooks()
        {
            return clsBookData.GetAllCatgories();
        }
        
        private bool AddNewBook()
        {
            this.BookID = clsBookData.AddNewBook(this.ISBN, this.Title, this.PublicationYear, this.AvailableCopies, this.CategoryID, 
                this.CoverPath, this.PersonID);
            return (this.BookID > 0);
        }

        //public bool AddNewBookItems()
        //{
        //    this.BookItems = clsBookData.AddNewBookItems(BookID, SerialNumber, NumberOfCopies, CopyStatus,
        //        LocationRack, Price);
        //    return (this.BookItems > 0);
        //}
        public int  GetLastSequanceOfBookItems(int BookID)
        {
            return clsBookData.GetLastSequanceOfBookItems(BookID);
        }

        private bool UpdateBook()
        {
            return clsBookData.UpdateBook(this.BookID, this.ISBN, this.Title, this.PublicationYear, this.AvailableCopies, this.CategoryID, this.CoverPath,this.PersonID, this.AuthorID);
        }
        
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(AddNewBook())
                    {
                        Mode = enMode.Update;
                        return true;
                    }else
                    {
                        return false;
                    }
                case enMode.Update:
                    return UpdateBook();
            }
            return false;
        }
       
        public static bool DeleteBook(int BookID, int AuthorID, int BookAuthors)
        {
            return clsBookData.DeleteBook(BookID, AuthorID, BookAuthors);
        }

        public static clsBook GetBookInfoByBookID(int BookID)
        {
            string ISBN = "", Title = "", CategoryName = "", Description = "", CoverPath = "", AuthorName = "";
            int AvailableCopies = -1, CategoryID = -1, PublicationYear = -1, PersonID = -1;

            bool isFound = clsBookData.GetBookInfoByBookID(BookID, ref ISBN, ref Title, ref PublicationYear, 
            ref AvailableCopies, ref CategoryID, ref CategoryName, ref Description, ref CoverPath, ref PersonID, ref AuthorName);
            
            if (isFound)
            {
                return new clsBook(BookID, ISBN, Title, PublicationYear, AvailableCopies, CategoryID, CoverPath, PersonID, AuthorName, CategoryName, Description);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllCategoryName()
        {
            return clsBookData.GetAllCategoryName();
        }

    }
}
