using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTableAndViewPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable DataTable = new DataTable();

            DataTable.Columns.Add("ID", typeof(int));
            DataTable.Columns.Add("Name", typeof(string));
            DataTable.Columns.Add("Country", typeof(string));
            DataTable.Columns.Add("Salary", typeof(double));
            DataTable.Columns.Add("Date", typeof(DateTime));

            DataColumn[] PrimaryKeyColumn = new DataColumn[1];
            PrimaryKeyColumn[0] = DataTable.Columns["ID"];
            DataTable.PrimaryKey = PrimaryKeyColumn;

            DataTable.Rows.Add(1, "Saddam Alzekri", "YEMEN", 5000, DateTime.Now);
            DataTable.Rows.Add(2, "Ali Alzekri", "YEMEN", 7000, DateTime.Now);
            DataTable.Rows.Add(3, "Samir Alzekri", "JORDON", 900, DateTime.Now);
            DataTable.Rows.Add(4, "Samira Alzekri", "EYGPT", 5000, DateTime.Now);
            DataTable.Rows.Add(5, "Saleh Alzekri", "JORDON", 5000, DateTime.Now);


            Console.WriteLine("Employees List");

            foreach (DataRow rows in DataTable.Rows)
            {
                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}", rows["ID"], rows["Name"], rows["Country"], rows["Salary"], rows["Date"]);
            }

            Console.WriteLine("\n\n");

            DataRow[] DataRows;

            DataRows = DataTable.Select("Country = 'YEMEN'");

            foreach (DataRow rows in DataRows)
            {
                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}", rows["ID"], rows["Name"], rows["Country"], rows["Salary"], rows["Date"]);
            }

            double MinSlalary = Convert.ToDouble(DataTable.Compute("MIN(Salary)", "Country = 'YEMEN'"));
            double MaxSlalary = Convert.ToDouble(DataTable.Compute("MIN(Salary)", "Country = 'JORDON'"));

            Console.WriteLine("\n\n");

            Console.WriteLine("Min Slalary : " + MinSlalary);
            Console.WriteLine("Max Slalary : " + MaxSlalary);

            DataTable.DefaultView.Sort = "Name ASC";
            DataTable = DataTable.DefaultView.ToTable();

            Console.WriteLine("\n\n");

            foreach (DataRow rows in DataTable.Rows)
            {
                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}", rows["ID"], rows["Name"], rows["Country"], rows["Salary"], rows["Date"]);
            }

            DataRows = DataTable.Select("ID = 5");

            foreach (DataRow rows in DataRows)
            {
                rows.Delete();
            }


            Console.WriteLine("\n\n");

            foreach (DataRow rows in DataTable.Rows)
            {
                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}", rows["ID"], rows["Name"], rows["Country"], rows["Salary"], rows["Date"]);
            }

            Console.WriteLine("\n\n");

            DataRows = DataTable.Select("ID = 1");

            foreach (DataRow rows in DataRows)
            {
                rows["Name"] = "Ala Alzekri";
            }

            Console.WriteLine("\n\n");

            foreach (DataRow rows in DataTable.Rows)
            {
                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}", rows["ID"], rows["Name"], rows["Country"], rows["Salary"], rows["Date"]);
            }

            DataTable.Clear();

            Console.WriteLine("\n-0-0-0\n");

            foreach (DataRow rows in DataTable.Rows)
            {
                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}", rows["ID"], rows["Name"], rows["Country"], rows["Salary"], rows["Date"]);
            }
            Console.ReadKey();
        }
    }
}
