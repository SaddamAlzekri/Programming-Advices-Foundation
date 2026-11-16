using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public static bool UpdateCountry(int ID,string Title,string Author,string Category,string Price,string Date ,int Rate ,string Cover)
        {
          string stringConnection = @"Server = .; Database = LibraryManagement; User Id = sa; Password = 123456;";

          int rowsAffected = 0;
          SqlConnection connection = new SqlConnection(stringConnection);

          string query = @"update Books 
                  set ID = @ID,
                  Title = @Title,
                  Author = @Author,
                  Category = @Category,
                  Price = @Price,
                  Date =  @Date,
                  Rate = @Rate,
                  Cover = @Cover
                  where ID = 1;";

          SqlCommand command = new SqlCommand(query, connection);

          command.Parameters.AddWithValue("@ID", ID);
          command.Parameters.AddWithValue("@Title", Title);
          command.Parameters.AddWithValue("@Author", Author);
          command.Parameters.AddWithValue("@Category", Category);
          command.Parameters.AddWithValue("@Price", Price);
          command.Parameters.AddWithValue("@Date", Date);
          command.Parameters.AddWithValue("@Rate", Rate);
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

            

            if ( UpdateCountry(1, "فلكd"))
            {
                Console.WriteLine("okey");
            }
            Console.ReadKey();
        }
    }
}
