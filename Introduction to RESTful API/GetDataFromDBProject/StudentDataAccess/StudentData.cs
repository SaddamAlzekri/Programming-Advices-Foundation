using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataAccess
{
    public class StudentDTO
    {
        public StudentDTO(int Id, string Name, int Age, decimal Grade, string ImagePath)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.Grade = Grade;
            this.ImagePath = ImagePath;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Grade { get; set; }
        public string ImagePath { get; set; }
    }

    public class StudentData
    {
        static string _ConnectionString = "Server=localhost;Database=StudentsDB;User Id=sa;Password=123456;Encrypt=False;TrustServerCertificate=True;Connection Timeout=30;";

        public static int AddStudent(StudentDTO SDTO)
        {
            int IdLast = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(_ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_AddStudent", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Name", SDTO.Name);
                        command.Parameters.AddWithValue("@Age", SDTO.Age);
                        command.Parameters.AddWithValue("@Grade", SDTO.Grade);
                        command.Parameters.AddWithValue("@ImagePath", SDTO.ImagePath);
                        conn.Open();
                        object result = command.ExecuteScalar();
                        if(result != null && int.TryParse(result.ToString(), out int InsertedId))
                        {
                            IdLast = InsertedId;
                        }
                    }
                }
            }catch (Exception ex)
            {
                string SourceName = "ExceptionWithStudentServer";
                if (!EventLog.SourceExists(SourceName))
                {
                    EventLog.CreateEventSource(SourceName, "Application");
                }
                EventLog.WriteEntry(SourceName, ex.Message, EventLogEntryType.Error);
            }
            return IdLast;
        }
        public static bool UpdateStudent(StudentDTO SDTO)
        {
            int rowEffect = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(_ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_UpdateStudent", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Id", SDTO.Id);
                        command.Parameters.AddWithValue("@Name", SDTO.Name);
                        command.Parameters.AddWithValue("@Age", SDTO.Age);
                        command.Parameters.AddWithValue("@Grade", SDTO.Grade);
                        command.Parameters.AddWithValue("@ImagePath", SDTO.ImagePath);
                        conn.Open();
                        rowEffect = command.ExecuteNonQuery();
                    }
                }
            }catch (Exception ex)
            {
                string SourceName = "ExceptionWithStudentServer";
                if (!EventLog.SourceExists(SourceName))
                {
                    EventLog.CreateEventSource(SourceName, "Application");
                }
                EventLog.WriteEntry(SourceName, ex.Message, EventLogEntryType.Error);
            }
            return (rowEffect > 0);
        }
        public static List<StudentDTO> GetAllStudents()
        {
            List<StudentDTO> Students = new List<StudentDTO>();
            try
            {
                using (SqlConnection conn = new SqlConnection(_ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetAllStudents", conn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        conn.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Students.Add(new StudentDTO
                                (
                                    reader.GetInt32(reader.GetOrdinal("Id")),
                                    reader.GetString(reader.GetOrdinal("Name")),
                                    reader.GetInt32(reader.GetOrdinal("Age")),
                                    reader.GetDecimal(reader.GetOrdinal("Grade")),
                                    reader.GetString(reader.GetOrdinal("ImagePath"))
                                ));
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                string SourceName = "ExceptionWithStudentServer";
                if (!EventLog.SourceExists(SourceName))
                {
                    EventLog.CreateEventSource(SourceName, "Application");
                }
                EventLog.WriteEntry(SourceName, ex.Message, EventLogEntryType.Error);
            }
            return Students;
        }
        public static bool DeleteStudent(int Id)
        {
            int rowsEffect = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(_ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_DeleteStudent", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Id", Id);
                        conn.Open();
                        rowsEffect = (int)command.ExecuteNonQuery();
                    }
                }
            }catch(Exception ex)
            {
                string SourceName = "ExceptionWithStudentServer";
                if (!EventLog.SourceExists(SourceName))
                {
                    EventLog.CreateEventSource(SourceName, "Application");
                }
                EventLog.WriteEntry(SourceName, ex.Message, EventLogEntryType.Error);
            }
            return (rowsEffect == 1);
        }

        public static decimal GetAverageStudent()
        {
            decimal rowEffect = 0;

            try
            {
                using (SqlConnection  conn = new SqlConnection(_ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetAverageStudents", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        rowEffect = (decimal)command.ExecuteScalar();
                    }
                }
            }catch(Exception ex)
            {
                string SourceName = "ExceptionWithStudentServer";
                if (!EventLog.SourceExists(SourceName))
                {
                    EventLog.CreateEventSource(SourceName, "Application");
                }
                EventLog.WriteEntry(SourceName, ex.Message, EventLogEntryType.Error);
            }
            return rowEffect;
        }

        public static List<StudentDTO> GetPassStudents()
        {
            List<StudentDTO> StudentsList = new List<StudentDTO>();
            try
            {
                using (SqlConnection conn = new SqlConnection(_ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetPassedStudents", conn))
                    {
                        command.CommandType= CommandType.StoredProcedure;
                        conn.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                StudentsList.Add(
                                    new StudentDTO(
                                        reader.GetInt32(reader.GetOrdinal("Id")),
                                        reader.GetString(reader.GetOrdinal("Name")),
                                        reader.GetInt32(reader.GetOrdinal("Age")),
                                        reader.GetDecimal(reader.GetOrdinal("Grade")),
                                        reader.GetString(reader.GetOrdinal("ImagePath"))
                                        ));
                            }
                        }
                    }
                }
            }catch(Exception ex)
            {
                string SourceName = "ExceptionWithStudentServer";
                if (!EventLog.SourceExists(SourceName))
                {
                    EventLog.CreateEventSource(SourceName, "Application");
                }
                EventLog.WriteEntry(SourceName, ex.Message, EventLogEntryType.Error);
            }
            return StudentsList;
        }

        public static StudentDTO GetStudentById(int id)
        {
            StudentDTO Student = null;
            try
            { 
                using (SqlConnection conn = new SqlConnection(_ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetStudentById", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Id", id);
                        conn.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                Student = new StudentDTO(
                                        reader.GetInt32(reader.GetOrdinal("Id")),
                                        reader.GetString(reader.GetOrdinal("Name")),
                                        reader.GetInt32(reader.GetOrdinal("Age")),
                                        reader.GetDecimal(reader.GetOrdinal("Grade")),
                                        reader.GetString(reader.GetOrdinal("ImagePath"))
                                        );
                            }
                        }
                    }
                }
            }catch(Exception ex)
            {
                string SourceName = "ExceptionWithStudentServer";
                if (!EventLog.SourceExists(SourceName))
                {
                    EventLog.CreateEventSource(SourceName, "Application");
                }
                EventLog.WriteEntry(SourceName, ex.Message, EventLogEntryType.Error);
            }
            return Student;
        }
    }
}

