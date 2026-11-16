using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBMS_DataAccess
{
    public class clsCustomersData
    {
        static clsGenericDataAccessMethods GenericMethods = new clsGenericDataAccessMethods();

        public static DataTable GetAllCustomers()
        {
            DataTable dtCategories = GenericMethods.ExecuteGetData("SP_GetAllCustomers");

            return dtCategories;
        }
    }
}
