using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Statement_With_Group_by
{
    class Program
    {
        public static string ConnectionString = @"server = .; DataBase = C21_DB1; User Id = sa; PassWord = 123456;";
        public static DataTable GetAllEmployees()
        {
            DataTable _dtGetAllEmployees = new DataTable();

            using(SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = @"SELECT Name, Department, Salary, PerformanceRating,
                                 CASE
                                     WHEN PerformanceRating >= 90 THEN 'High'
                                     WHEN PerformanceRating > 75 THEN 'Meduim'
                                     ELSE 'Low'
                                 END AS Appreciation FROM Employees2;";

                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            _dtGetAllEmployees.Load(reader);
                        }
                    }
                }
            }
            return _dtGetAllEmployees;
        }

        public static void StyleMethode()
        {
            Console.Write("\n");
            for (int i = 0; i <= 70; i++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("*");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        public static void PrintListEmployees(DataTable _dtEmployees)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("{0, -15}{1, -15}{2, -10}{3, -20}{4, -10}", "\nName", "Department", "Salary", "PerformanceRating", "Appreciation\n");
            Console.BackgroundColor = ConsoleColor.Black;                
            foreach(DataRow row in _dtEmployees.Rows)
            {
                string Name = row["Name"].ToString();
                string Department = row["Department"].ToString();
                string Salary = row["Salary"].ToString();
                string PerformanceRating = row["PerformanceRating"].ToString();
                string Appreciation = row["Appreciation"].ToString();
                Console.WriteLine("{0, -15}{1, -15}{2, -10}{3, -20}{4, -10}", Name, Department, Salary, PerformanceRating, Appreciation);
            }

            StyleMethode();
            Console.Write("\n");
        }

        public static DataTable GetEmployeesByCSharpLanguage()
        {
            DataTable _dtGetAllEmployees = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = @"SELECT 'High' AS PerformanceCategory, COUNT(*) AS NumberOfEmployees, AVG(Salary) AS AverageSalary
FROM Employees2
WHERE PerformanceRating >= 80

UNION ALL

SELECT 'Medium' AS PerformanceCategory, COUNT(*) AS NumberOfEmployees, AVG(Salary) AS AverageSalary
FROM Employees2
WHERE PerformanceRating >= 60 AND PerformanceRating < 80

UNION ALL

SELECT 'Low' AS PerformanceCategory, COUNT(*) AS NumberOfEmployees, AVG(Salary) AS AverageSalary
FROM Employees2
WHERE PerformanceRating < 60;


                                    ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            _dtGetAllEmployees.Load(reader);
                        }
                    }
                }
            }
            return _dtGetAllEmployees;
        }

        public static DataTable GetEmployeesByTSQLLanguage()
        {
            DataTable _dtGetAllEmployees = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = @"SELECT Appreciation, COUNT(*) AS NumberOFEmplyees, AVG(Salary) AS AverageSalary
                                     FROM (
                                     SELECT Name, Salary,
                                     CASE 
                                         WHEN PerformanceRating >= 90 THEN 'High'
                                         WHEN PerformanceRating > 75 THEN 'Meduim'
                                         ELSE 'Low'
                                     END AS Appreciation FROM Employees2
                                     ) AS PerformanceTable
                                     group by Appreciation;
                                    ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            _dtGetAllEmployees.Load(reader);
                        }
                    }
                }
            }
            return _dtGetAllEmployees;
        }

        
        static void Main(string[] args)
        {
            DataTable dt = new DataTable();
            dt = GetAllEmployees();
            PrintListEmployees(dt);

            DataTable dt2 = new DataTable();
            Stopwatch sw1 = Stopwatch.StartNew();
            dt2 = GetEmployeesByCSharpLanguage();
            sw1.Stop();
            Console.Write("{0, 35}", "C# Language\n");
            Console.WriteLine("The Time : " + sw1.ElapsedMilliseconds + " ms");
            StyleMethode();

            DataTable dt3 = new DataTable();
            Stopwatch sw2 = Stopwatch.StartNew();
            dt3 = GetEmployeesByTSQLLanguage();
            sw2.Stop();
            Console.WriteLine();
            Console.Write("{0, 35}", "T-SQL Language\n");
            Console.WriteLine("The Time : " + sw2.ElapsedMilliseconds + " ms");

            Console.ReadKey();
        }

    }
}
