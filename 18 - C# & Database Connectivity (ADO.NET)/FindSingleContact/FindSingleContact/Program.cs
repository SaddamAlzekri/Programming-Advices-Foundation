using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace FindSingleContact
{
    class Program
    {
        static string ConnectString = "Server = .; DataBase = ContactsDB; User Id = sa; Password = 123456";

        public struct stConnect
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public int CountryID { get; set; }
        }
        static bool FindContactByID(int ContactID, ref stConnect ContactInfo)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(ConnectString);
            string Query = "Select *from Contacts Where CountryID = @CountryID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryID", ContactID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if(Reader.Read())
                {
                    isFound = true;
                    ContactInfo.ID = (int)Reader["ContactID"];
                    ContactInfo.FirstName = (string)Reader["FirstName"];
                    ContactInfo.LastName = (string)Reader["LastName"];
                    ContactInfo.Email = (string)Reader["Email"];
                    ContactInfo.Phone = (string)Reader["Phone"];
                    ContactInfo.Address = (string)Reader["Address"];
                    ContactInfo.CountryID = (int)Reader["CountryID"];
                }
                else
                {
                    isFound = false;
                }
                Connection.Close();
                Reader.Close();
                Command.Clone();
            }catch(Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            return isFound;
        }
        static void Main(string[] args)
        {
            stConnect ContactInfo = new stConnect();

            if(FindContactByID(2, ref  ContactInfo))
            {
                Console.WriteLine(ContactInfo.ID);
                Console.WriteLine(ContactInfo.FirstName);
                Console.WriteLine(ContactInfo.LastName);
                Console.WriteLine(ContactInfo.Email);
                Console.WriteLine(ContactInfo.Phone);
                Console.WriteLine(ContactInfo.Address);
                Console.WriteLine(ContactInfo.CountryID);
            }else{
                Console.WriteLine("The Rowdo not Found");
            }
            Console.ReadKey();
        }
    }
}
