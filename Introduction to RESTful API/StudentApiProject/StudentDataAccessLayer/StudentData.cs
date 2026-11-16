using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace StudentDataAccessLayer
{
    public class StudentDTO
    {
        public StudentDTO(int Id, string Name, int Age ,int Grade)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.Grade = Grade;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
    }

    public class StudentData
    {
        static string _connectionString = "Server=.;Database=StudentsDB;User Id=sa;Password=123456;Encrypt=False;TrustServerCertificate=True;Connection Timeout=30;";

        public static int AddStudent(StudentDTO studentDTO)
        {
            int newStudentId = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_AddStudent", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Name", studentDTO.Name);
                        command.Parameters.AddWithValue("@Age", studentDTO.Age);
                        command.Parameters.AddWithValue("@Grade", studentDTO.Grade);

                        connection.Open();
                        var result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            newStudentId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                string sourceName = "Exception";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }

                EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Error);
            }
           return newStudentId;
        }

        public static List<StudentDTO> GetAllStudents()
        {
            List<StudentDTO> students = new List<StudentDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetAllStudents", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                students.Add(new StudentDTO(
                                reader.GetInt32(reader.GetOrdinal("Id")),
                                reader.GetString(reader.GetOrdinal("Name")),
                                reader.GetInt32(reader.GetOrdinal("Age")),
                                reader.GetInt32(reader.GetOrdinal("Grade"))
                                ));
                            }
                        }
                    }
                }
            }catch(Exception ex)
            {
                string sourceName = "Exception";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }

                EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Error);
            }
            return students;
        }

    }
}
