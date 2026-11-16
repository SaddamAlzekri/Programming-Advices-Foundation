using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrySomethings
{

    class Program
    {
        public static bool UpdateStudents(int ID, string Name, string Location, string phone, string Email, string School, string Dept, string Cover)
        {

            int rowsAffected = 0;        
            string stringConnection = @"Server = .; Database = LibraryManagement; User Id = sa; Password = 123456;";

            SqlConnection connection = new SqlConnection(stringConnection);

            string query = @"update Students  set Name = @Name,
                                 Location = @Location,
                                 phone = @phone,
                                 Email = @Email,
                                 School =@School,
                                 Dept = @Dept,
                                 Cover = @Cover
                                 where ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Location", Location);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@School", School);
            command.Parameters.AddWithValue("@Dept", Dept);
            command.Parameters.AddWithValue("@Cover", Cover);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        static void Main(string[] args)
        {

            UpdateStudents(5, "Ala", "AbdoAlellah", "1234456", "Ala@gmail.com", "technology", "IT", "E:IconimageBusiness Man in Blue Jacket.png");


            Console.ReadKey();
        }

    }
}
