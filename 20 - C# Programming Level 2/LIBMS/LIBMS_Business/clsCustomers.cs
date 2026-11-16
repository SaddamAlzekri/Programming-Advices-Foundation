using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIBMS_DataAccess;
using System.Data;

namespace LIBMS_Business
{
    public class clsCustomers
    {
        public static DataTable GetAllCustomers()
        {
            return clsCustomersData.GetAllCustomers();
        }
        
    }
}
