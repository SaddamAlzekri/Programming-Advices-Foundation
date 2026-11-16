using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIBMS_DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace LIBMS_Business
{
    public class clsCategories
    {
        public enum enMode { AddNew = 0, Update}
        public enMode Mode = enMode.AddNew;

        public int CategoryID { set; get; }
        public string CategoryName { set; get; }
        public string Description { set; get; } 

        public clsCategories()
        {
            this.CategoryID = -1;
            this.CategoryName = "";
            this.Description = "";

            Mode = enMode.AddNew;
        }
        private clsCategories(int CategoryID, string CategoryName, string Description)
        {
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;
            this.Description = Description;

            Mode = enMode.Update;
        }

        public static DataTable GetAllCatgories()
        {
            return clsCategoriesData.GetAllCatgories();
        }

        private bool AddNewCategory()
        {
            this.CategoryID = clsCategoriesData.AddNewCategory(this.CategoryName, this.Description);
            return (this.CategoryID != -1);

        }

        private bool UpdateCategories()
        {
            return clsCategoriesData.UpdateCategory(this.CategoryID, this.CategoryName, this.Description);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewCategory())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return UpdateCategories();
            }
            return false;
        }

        public static clsCategories GetCategoryInfoByCategoryID(int CategoryID)
        {
            string CategoryName = "", Description = "";

            bool isFound = clsCategoriesData.GetCategoryInfoByCategoryID(CategoryID, ref CategoryName, ref Description);

            if(isFound)
            {
                return new clsCategories(CategoryID, CategoryName, Description);
            }else
            {
                return null;
            }
        }

        public static bool DeleteCategory(int CategoryID)
        {
            return clsCategoriesData.DeleteCategory(CategoryID);
        }

    }
}
