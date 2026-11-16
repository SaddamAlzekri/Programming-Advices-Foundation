using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ConsoleReturnAutoNumber
{
    class Program
    {
        static string ConnectionString = "Server = .; DataBase = ContactsDB; User Id = sa; Password = 123456";

        public struct stContact
        {
            public string FirstName {get; set;}
            public string LastName {get; set;}
            public string Email {get; set;}
            public string Phone {get; set;}
            public string Address {get; set;}
            public int CountryID {get; set;}
        }

        static void UpdateDataBase(int ContactID, stContact ContactInfo)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query =
            @"Update Contacts set FirstName = @FirstName, LastName = @LastName, Email = @Email, Phone = @Phone, Address = @Address, CountryID = @CountryID where ContactID = @ContactID";
            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@ContactID", ContactID);
            command.Parameters.AddWithValue("@FirstName", ContactInfo.FirstName);
            command.Parameters.AddWithValue("@LastName", ContactInfo.LastName);
            command.Parameters.AddWithValue("@Email", ContactInfo.Email);
            command.Parameters.AddWithValue("@Phone", ContactInfo.Phone);
            command.Parameters.AddWithValue("@Address", ContactInfo.Address);
            command.Parameters.AddWithValue("@CountryID", ContactInfo.CountryID);


            try
            {
                Connection.Open();
                int Result = command.ExecuteNonQuery();

                if(Result > 0)
                    Console.WriteLine("Record Update seccessfully");
                else
                    Console.WriteLine("Record Update failed");
                Connection.Close();

            }catch(Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }
        static void DropDataBase(int ContactID)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query = @"delete from Contacts where ContactID = @ContactID";
            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@ContactID", ContactID);

            try
            {
                Connection.Open();
                int Result = command.ExecuteNonQuery();

                if (Result > 0)
                    Console.WriteLine("Record Insert seccessfully");
                else
                    Console.WriteLine("Record Insert failed");
                Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        static void Main(string[] args)
        {
            stContact Contact = new stContact
            {
                FirstName = "Saddam",
                LastName = "Al-zekri",
                Email = "Saddam@gmail.com",
                Phone = "71212122",
                Address = "123 Turba",
                CountryID = 2
            };

           // UpdateDataBase(1, Contact);

            DropDataBase(6);

            Console.ReadKey();
        }
    }
}
