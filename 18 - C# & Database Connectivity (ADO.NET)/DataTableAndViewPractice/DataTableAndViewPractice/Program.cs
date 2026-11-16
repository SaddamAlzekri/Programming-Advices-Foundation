using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTableAndViewPractice
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

            DataTable.Rows.Add(1, "Saddam Alzekri", "YEMEN", 5000, DateTime.Now);
            DataTable.Rows.Add(1, "Ali Alzekri", "YEMEN", 7000, DateTime.Now);
            DataTable.Rows.Add(1, "Samir Alzekri", "JORDON", 900, DateTime.Now);
            DataTable.Rows.Add(1, "Samira Alzekri", "EYGPT", 5000, DateTime.Now);
            DataTable.Rows.Add(1, "Saleh Alzekri", "JORDON", 5000, DateTime.Now);


            int TotalEmployees = DataTable.Rows.Count;

            double SumSalary = Convert.ToDouble(DataTable.Compute("SUM(Salary)", string.Empty));
            double AVGSalary = Convert.ToDouble(DataTable.Compute("AVG(Salary)", string.Empty));
            double MinSalary = Convert.ToDouble(DataTable.Compute("MIN(Salary)", string.Empty));
            double MaxSalary = Convert.ToDouble(DataTable.Compute("MAX(Salary)", string.Empty));

            Console.WriteLine("Employees List");

            foreach(DataRow rows in DataTable.Rows)
            {
                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}", rows["ID"], rows["Name"], rows["Country"], rows["Salary"], rows["Date"]);
            }

            Console.WriteLine("\n\n");

            Console.WriteLine("Total Employees : {0}", TotalEmployees);
            Console.WriteLine("Sum Salary : {0}", SumSalary);
            Console.WriteLine("AVG Salary : {0}", AVGSalary);
            Console.WriteLine("Min Salary : {0}", MinSalary);
            Console.WriteLine("Max Salary : {0}", MaxSalary);

            Console.ReadKey();
        }
    }
}
