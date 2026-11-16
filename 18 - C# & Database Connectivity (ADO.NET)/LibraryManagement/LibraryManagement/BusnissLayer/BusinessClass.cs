using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using LibraryManagement.DataAccessLayer;
using System.Threading.Tasks;

namespace LibraryManagement.BusnissLayer
{
    class BusinessClass
    {
        public static operationOnBooks operationOnBook = new operationOnBooks();
        public static DataTable GetAllCategories()
        {
            operationOnBook.Order();
            return operationOnBook.GetAllCategories();
        }

        public  bool AddNewContact(string CategoryName)
        {
            int ID;

            ID = operationOnBook.AddNewContact(CategoryName);

            return (ID != -1);
        }

        public bool UpdateContact(int ID, string CategoryName)
        {
            return operationOnBook.UpdateContact(ID, CategoryName);
        }

        public static bool DeleteContact(int ID)
        {
            return operationOnBook.DeleteContact(ID);
        }

        public static DataTable SearchCategories(string Category_Name)
        {
            return operationOnBook.SearchCategories(Category_Name);
        }
    }
}
