using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Stores_Management.DAL
{
    class SqlConnection
    {
        public static string SqlConnection = @"Server = .; Database = StoresManagement; User id = sa; Password = 123456;";
    }
}
