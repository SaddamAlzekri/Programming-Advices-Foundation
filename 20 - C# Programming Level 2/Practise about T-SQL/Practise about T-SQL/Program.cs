using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;

namespace Practise_about_T_SQL
{
    class Program
    {
        public static string connectionString = @"server = .; DataBase = C21_DB1; User Id = sa; PassWord = 123456;";

        public static bool UpdateEmplyeesByBonus()
        {
            int effortRow = 0;
            using(SqlConnection conection = new SqlConnection(connectionString))
            {
                string query = @"SELECT Name, Department, Salary, PerformanceRating, Bonus = 
CASE
    WHEN Department = 'Sales' THEN 
        CASE
            WHEN PerformanceRating > 90 THEN (Salary * 0.15)
            WHEN PerformanceRating BETWEEN 75 AND 90 THEN (Salary * 0.10)
            ELSE (Salary * 0.05)
        END
    WHEN Department = 'Sales'  THEN 
        CASE
            WHEN PerformanceRating > 90 THEN (Salary * 0.12)
            WHEN PerformanceRating BETWEEN 75 AND 90 THEN (Salary * 0.18)
            ELSE (Salary * 0.04)
        END
    ELSE
        CASE
            WHEN PerformanceRating > 90 THEN (Salary * 0.9)
            WHEN PerformanceRating BETWEEN 75 AND 90 THEN (Salary * 0.6)
            ELSE (Salary * 0.03)
        END
END
FROM Employees2;";
                using(SqlCommand command = new SqlCommand(query, conection))
                {
                    conection.Open();
                    effortRow = command.ExecuteNonQuery();
                }
            }
            return effortRow != 0;
        }

        public static DataTable GetAllEmployees()
        {
            DataTable _dtEmployees = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"Select *from Employees2;";

                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using(SqlDataReader Reader = command.ExecuteReader())
                    {
                        if(Reader.HasRows)
                        {
                            _dtEmployees.Load(Reader);
                        }
                    }
                }

            }
            return _dtEmployees;
        }

        public static bool UpdateingProgramming(DataTable _dt)
        {
           // bool isUpdate = false;
            int effortRow = 0;
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach(DataRow dt in _dt.Rows)
                {
                    string query = @"Update Employees2
                                   set Salary = @Salary
                                      where Name = @Name;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        string Name = dt["Name"].ToString();
                        int PerformanceRating = (int)dt["PerformanceRating"];
                        int Salary = (int)dt["Salary"];

                        if(PerformanceRating > 90) Salary = (int)(Salary * 1.15);
                        else if(PerformanceRating >= 75) Salary = (int)(Salary * 1.10);
                        else if(PerformanceRating >= 50) Salary = (int)(Salary * 1.05);

                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Salary", Salary);

                       // isUpdate &= command.ExecuteNonQuery() > 0;
                        effortRow = command.ExecuteNonQuery();
                    }
                }
                
            }
          //  return isUpdate;
            return effortRow > 0;
        }

        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            UpdateEmplyeesByBonus();
            sw.Stop();
            Console.WriteLine("The Time : " + sw.ElapsedMilliseconds + " ms");

            Stopwatch sw2 = Stopwatch.StartNew();
            DataTable dt = GetAllEmployees();
            UpdateingProgramming(dt);
            sw2.Stop();
            Console.WriteLine("The Time : " + sw2.ElapsedMilliseconds + " ms");


            Console.ReadKey();
        }

    }
}
