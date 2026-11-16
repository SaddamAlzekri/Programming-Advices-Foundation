using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PractiseAboutCSharpWithDataBase
{
    class Program
    {
        static string ConnectString = "Server = .; DataBase = ContactsDB; User Id = sa; PassWord = 123456";

        static void RetrieveDataBase(string _FirstName)
        {
            SqlConnection Connection = new SqlConnection(ConnectString);
            string Query = "Select *from Contacts Where FirstName = @FirstName";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@FirstName", _FirstName);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                while(Reader.Read())
                {
                    int ID = (int)Reader["ContactID"];
                    string FirstName = (string)Reader["FirstName"];
                    string LastName = (string)Reader["LastName"];
                    string Email = (string)Reader["Email"];
                    string Phone = (string)Reader["Phone"];
                    string Address = (string)Reader["Address"];
                    int CountryID = (int)Reader["CountryID"];

                    Console.WriteLine("ID : " + ID);
                    Console.WriteLine("FirstName : " + FirstName);
                    Console.WriteLine("LastName : " + LastName);
                    Console.WriteLine("Email : " + Email);
                    Console.WriteLine("Phone : " + Phone);
                    Console.WriteLine("Address : " + Address);
                    Console.WriteLine("CountryID : " + CountryID);
                    Console.WriteLine();
                }
                Connection.Close(); Reader.Close();
            }catch(Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
            }

        }

        static void SearchContactsWith(string StrSearch, int _CountryID)
        {
            SqlConnection Connection = new SqlConnection(ConnectString);
            string Query = "Select *from Contacts where FirstName like '' + @FirstName + '%' And CountryID = @CountryID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@FirstName", StrSearch);
            Command.Parameters.AddWithValue("@CountryID", _CountryID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    int ID = (int)Reader["ContactID"];
                    string FirstName = (string)Reader["FirstName"];
                    string LastName = (string)Reader["LastName"];
                    string Email = (string)Reader["Email"];
                    string Phone = (string)Reader["Phone"];
                    string Address = (string)Reader["Address"];
                    int CountryID = (int)Reader["CountryID"];

                    Console.WriteLine("ID : " + ID);
                    Console.WriteLine("FirstName : " + FirstName);
                    Console.WriteLine("LastName : " + LastName);
                    Console.WriteLine("Email : " + Email);
                    Console.WriteLine("Phone : " + Phone);
                    Console.WriteLine("Address : " + Address);
                    Console.WriteLine("CountryID : " + CountryID);
                    Console.WriteLine();
                }
                Connection.Close(); Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
            }
        }

        static string GetFirstName(int _ContactID)
        {
            string FirstName = "";
            SqlConnection Connection = new SqlConnection(ConnectString);
            string Query = "Select FirstName from Contacts where ContactID = @ContactID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ContactID", _ContactID);

            try
            {
                Connection.Open();
                object Reader = Command.ExecuteScalar();
                if (Reader != null)
                {
                    FirstName = Reader.ToString();
                }
                else
                {
                    FirstName = "";
                }
                Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
            }

            return FirstName;
        }
        public struct stContactinfo
        {
            public int ContactID {get; set;}
            public string FirstName {get; set;}
            public string LastName {get; set;}
            public string Email {get; set;}
            public string Phone {get; set;}
            public string Address {get; set;}
            public int CountryID {get; set;}
        }

        public struct stContactinfo2
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public int CountryID { get; set; }
        }
        static bool FindContactByID(int _CountryID, ref stContactinfo ContactIfo)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(ConnectString);
            string Query = "Select *from Contacts where CountryID = @CountryID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@CountryID", _CountryID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                 if (Reader.Read())
                {
                    isFound = true;
                    ContactIfo.ContactID = (int)Reader["ContactID"];
                    ContactIfo.FirstName = (string)Reader["FirstName"];
                    ContactIfo.LastName = (string)Reader["LastName"];
                    ContactIfo.Email = (string)Reader["Email"];
                    ContactIfo.Phone = (string)Reader["Phone"];
                    ContactIfo.Address = (string)Reader["Address"];
                    ContactIfo.CountryID = (int)Reader["CountryID"];

                }
                 else
                 {
                     isFound = false;
                 }
                Connection.Close(); Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
            }
            return isFound;
        }

        static void Insert(stContactinfo2 ContactInfo)
        {
            SqlConnection Connection = new SqlConnection(ConnectString);
            string Query = "Insert into Contacts (FirstName, LastName, Email, Phone, Address, CountryID) values (@FirstName, @LastName, @Email, @Phone, @Address, @CountryID)";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@FirstName", ContactInfo.FirstName);
            Command.Parameters.AddWithValue("@LastName", ContactInfo.LastName);
            Command.Parameters.AddWithValue("@Email", ContactInfo.Email);
            Command.Parameters.AddWithValue("@Phone", ContactInfo.Phone);
            Command.Parameters.AddWithValue("@Address", ContactInfo.Address);
            Command.Parameters.AddWithValue("@CountryID", ContactInfo.CountryID);

            try
            {
                Connection.Open();
                int Result = Command.ExecuteNonQuery();

                if (Result > 0)
                    Console.WriteLine("The Rows is seccussfully");
                else
                    Console.WriteLine("The Rows is failed");

                Connection.Close();
            }catch(Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }

        }

        static void Main(string[] args)
        {
            //RetrieveDataBase("Saddam");
           // SearchContactsWith("Ja", 1);
           // Console.WriteLine(GetFirstName(4));
            //stContactinfo ContactInfo = new stContactinfo();
            //if (FindContactByID(2, ref ContactInfo))
            //{
            //    Console.WriteLine(ContactInfo.ContactID);
            //    Console.WriteLine(ContactInfo.FirstName);
            //    Console.WriteLine(ContactInfo.LastName);
            //    Console.WriteLine(ContactInfo.Email);
            //    Console.WriteLine(ContactInfo.Phone);
            //    Console.WriteLine(ContactInfo.Address);
            //    Console.WriteLine(ContactInfo.CountryID);
            //}
            //else
            //{
            //    Console.WriteLine("The row is not Found");
            //}

            stContactinfo2 ContactInfo = new stContactinfo2
            {
                FirstName = "Soso",
                LastName = "AlMagrami",
                Email = "AlMagrami@gmail.com",
                Phone = "71234434",
                Address = "AlMagrami 70",
                CountryID = 2
            };

            Insert(ContactInfo);

            Console.ReadKey();
        }
    }
}
