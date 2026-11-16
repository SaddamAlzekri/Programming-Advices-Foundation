using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleInertInToDataBase
{
    class Program
    {
       // static string ConnectionString = "Server = ., DataBase = ContactsDB, User Id = sa, Password = 123456";
        static string connectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=123456;"; 

        public struct stContact
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public int countryID { get; set; }
        }

        static void InsertInToDtaBase(stContact InsertQuery)
        {
            SqlConnection Connection = new SqlConnection(connectionString);
            string Query = @"Insert into Contacts (FirstName, LastName, Email, Phone, Address, countryID) values (@FirstName, @LastName, @Email, @Phone, @Address, @countryID)";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@FirstName", InsertQuery.FirstName);
            Command.Parameters.AddWithValue("@LastName", InsertQuery.LastName);
            Command.Parameters.AddWithValue("@Email", InsertQuery.Email);
            Command.Parameters.AddWithValue("@Phone", InsertQuery.Phone);
            Command.Parameters.AddWithValue("@Address", InsertQuery.Address);
            Command.Parameters.AddWithValue("@countryID", InsertQuery.countryID);

            try
            {
                Connection.Open();
                int RowsAffects = Command.ExecuteNonQuery();

                if (RowsAffects > 0)
                    Console.WriteLine("Record insert Seccessfully");
                else
                    Console.WriteLine("Record insert Failed");

                Connection.Close();


            }catch(Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }
        static void Main(string[] args)
        {
            stContact ContactInfo = new stContact
            {
                FirstName = "Ali",
                LastName = "Al-zekri",
                Email = "Saddam@gmail.com",
                Phone = "712126932",
                Address = "123 Al-Turba",  
                countryID = 1
            };

            InsertInToDtaBase(ContactInfo);
            Console.ReadKey();
        }
    }
}
