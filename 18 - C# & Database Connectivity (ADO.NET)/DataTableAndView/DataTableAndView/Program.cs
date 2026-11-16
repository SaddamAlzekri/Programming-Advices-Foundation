using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTableAndView
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable EmployeesDataTable = new DataTable("EmployeesDataTable");

            EmployeesDataTable.Columns.Add("ID", typeof(int));
            EmployeesDataTable.Columns.Add("Name", typeof(string));
            EmployeesDataTable.Columns.Add("Country", typeof(string));
            EmployeesDataTable.Columns.Add("Salary", typeof(double));
            EmployeesDataTable.Columns.Add("Date", typeof(DateTime));

            EmployeesDataTable.Rows.Add(1, "Ali Al-zekri", "YEMEN", 3000, DateTime.Now);
            EmployeesDataTable.Rows.Add(2, "Asem Al-zekri", "YEMEN", 3000, DateTime.Now);
            EmployeesDataTable.Rows.Add(3, "Osama Al-zekri", "YEMEN", 3000, DateTime.Now);
            EmployeesDataTable.Rows.Add(4, "Ala Al-zekri", "YEMEN", 5000, DateTime.Now);
            EmployeesDataTable.Rows.Add(5, "Saddam Al-zekri", "YEMEN", 3000, DateTime.Now);

            Console.WriteLine("Employees DataTable\n\n");

            foreach(DataRow rows in EmployeesDataTable.Rows)
            {
                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}", rows["ID"], rows["Name"], rows["Country"], rows["Salary"], rows["Date"]);
            }


            DataTable DepartMent = new DataTable("DepartMent");

            DepartMent.Columns.Add("DepartMentID", typeof(int));
            DepartMent.Columns.Add("Name", typeof(string));

            DepartMent.Rows.Add(1, "Computer Science");
            DepartMent.Rows.Add(2, "Information Technology");

            Console.WriteLine("DepartMent\n\n");

            foreach (DataRow rows in DepartMent.Rows)
            {
                Console.WriteLine("{0} \t {1}", rows["DepartMentID"], rows["Name"]);
            }

            DataSet DataSet1 = new DataSet();
            DataSet1.Tables.Add(EmployeesDataTable);
            DataSet1.Tables.Add(DepartMent);

            Console.WriteLine("DepartMent\n\n");

            foreach (DataRow rows in DataSet1.Tables["EmployeesDataTable"].Rows)
            {
                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}", rows["ID"], rows["Name"], rows["Country"], rows["Salary"], rows["Date"]);
            }
            Console.WriteLine("\n\n");
            foreach (DataRow rows in DataSet1.Tables["DepartMent"].Rows)
            {
                Console.WriteLine("{0} \t {1}", rows["DepartMentID"], rows["Name"]);
            }
            Console.ReadKey();
        }
    }
}