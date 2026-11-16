using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable EmployeesDataTable = new DataTable();

            EmployeesDataTable.Columns.Add("ID", typeof(int));
            EmployeesDataTable.Columns.Add("Name", typeof(string));
            EmployeesDataTable.Columns.Add("Country", typeof(string));
            EmployeesDataTable.Columns.Add("Salary", typeof(double));
            EmployeesDataTable.Columns.Add("Date", typeof(DateTime));

            EmployeesDataTable.Rows.Add(1, "Saddam", "YEMEN", 7000, DateTime.Now);
            EmployeesDataTable.Rows.Add(2, "Saleh", "KSA  ", 4000, DateTime.Now);
            EmployeesDataTable.Rows.Add(3, "Samir", "Jordan", 3500, DateTime.Now);
            EmployeesDataTable.Rows.Add(4, "Samira", "Egypt", 1500, DateTime.Now);
            EmployeesDataTable.Rows.Add(5, "Salman", "Lebanon", 6000, DateTime.Now);

            int EmployeesCount = 0;
            double TotalSalaries = 0;
            double AverageSalaries = 0;
            double MinSalary = 0;
            double MaxSalary = 0;
            
            EmployeesCount = EmployeesDataTable.Rows.Count;
            TotalSalaries = Convert.ToDouble(EmployeesDataTable.Compute("SUM(Salary)", string.Empty));
            AverageSalaries = Convert.ToDouble(EmployeesDataTable.Compute("AVG(Salary)", string.Empty));
            MinSalary = Convert.ToDouble(EmployeesDataTable.Compute("MIN(Salary)", string.Empty));
            MaxSalary = Convert.ToDouble(EmployeesDataTable.Compute("MAX(Salary)", string.Empty));

            Console.WriteLine("\nEmployees List\n");

            foreach(DataRow recordRow in EmployeesDataTable.Rows)
            {
                Console.WriteLine("ID : {0} \t Name : {1} \t Country : {2} \t  Salary : {3} \t  Date : {4}",
                    recordRow["ID"], recordRow["Name"], recordRow["Country"], recordRow["Salary"], recordRow["Date"]);
            }

            Console.ReadKey();
        }
    }
}
