using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ContactsDB
{
    class Program
    {
        static string ConnectString = "Server = ., DataBase = ContactDB, User Id = sa, Password = 123456";

        static void PrintAllDatabase()
        {
            SqlConnection Connection = new SqlConnection(ConnectString);

            string Query = "Select *from Contacts";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = new SqlDataReader();
                Console.WriteLine("ContactId    FirstName    LastName    Email    Phone    Address    CountryID");
                while (Reader.Read())
                {
                    int ContactId = (int)Reader["ContactID"];
                    string FirstName = (string)Reader["FirstName"];
                    string LastName = (string)Reader["LastName"];
                    string Email = (string)Reader["Email"];
                    string Phone = (string)Reader["Phone"];
                    string Address = (string)Reader["Address"];
                    int CountryID = (int)Reader["CountryID"];

                    Console.WriteLine("{0}    {1}    {2}    {3}    {4}    {5}    {6}", ContactId, FirstName, LastName, Email, Phone, Address, CountryID);


                }
                Connection.Close();
                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.Write("Error: {0}", ex.Message);
            }

        }

        static void Main(string[] args)
        {
            PrintAllDatabase();

            Console.ReadKey();
        }
    }
}
