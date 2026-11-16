using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AllowanesProgram_Business
{
    public class clsAllowancesData
    {
        public static DataTable GetAllAllowances()
        {
            DataTable _dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT *FROM Employees2;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                _dt.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string sourceName = "Exception";
                        if (!EventLog.SourceExists(sourceName))
                        {
                            EventLog.CreateEventSource(sourceName, "Application");
                        }

                        EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Error);
                    }
                }
            }
            return _dt;
        }

        public static bool UpdateAllowances()
        {
            int effortRow = 0;
            using (SqlConnection conection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"update Employees2 set Salary = 
CASE
    WHEN Department = 'Sales' THEN 
        CASE
            WHEN PerformanceRating > 90 THEN (Salary * 1.15)
            WHEN PerformanceRating BETWEEN 75 AND 90 THEN (Salary * 1.10)
            ELSE (Salary * 1.05)
        END
    WHEN Department = 'Sales'  THEN 
        CASE
            WHEN PerformanceRating > 90 THEN (Salary * 1.12)
            WHEN PerformanceRating BETWEEN 75 AND 90 THEN (Salary * 1.18)
            ELSE (Salary * 1.04)
        END
    ELSE
        CASE
            WHEN PerformanceRating > 90 THEN (Salary * 1.9)
            WHEN PerformanceRating BETWEEN 75 AND 90 THEN (Salary * 1.6)
            ELSE (Salary * 1.03)
        END
END";
                using (SqlCommand command = new SqlCommand(query, conection))
                {
                    conection.Open();
                    effortRow = command.ExecuteNonQuery();
                }
            }
            return effortRow != 0;
        }


        public static bool UpdateAllowancesByProgramming(DataTable _dt)
        {
            int effortRow = 0;
            using (SqlConnection conection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                conection.Open();
                foreach(DataRow row in _dt.Rows)
                {
                    string query = @"Update Employees2
                                     Set Salary = Salary * 1.15
                                     where Name = @Name;";

                     using (SqlCommand command = new SqlCommand(query, conection))
                     {
                         string Name = row["Name"].ToString();
                         int PerformanceRating = (int)row["PerformanceRating"];
                         int Salary = (int)row["Salary"];

                         if (PerformanceRating > 90) Salary = (int)(Salary * 1.15);
                         if (PerformanceRating >= 75) Salary = (int)(Salary * 1.10);
                         else if (PerformanceRating >= 50)  Salary = (int)(Salary * 1.05);

                         command.Parameters.AddWithValue("@Name", Name);
                         command.Parameters.AddWithValue("@Salary", Salary);

                         effortRow = command.ExecuteNonQuery();
                     }
                 }
            }
            return effortRow != 0;
        }

    }
}

