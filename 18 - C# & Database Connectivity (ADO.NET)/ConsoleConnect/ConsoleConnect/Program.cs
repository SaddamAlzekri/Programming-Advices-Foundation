using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ConsoleConnect
{
    class Program
    {
        static string ConnectString = "Server = .; DataBase = ContactsDB; User Id = sa; Password = 123456";
        static void PrintAllDataBase(string First_Name, int Country_ID)
        {
            SqlConnection Connect = new SqlConnection(ConnectString);

            string Query = "select *from Contacts where FirstName = @First_Name And CountryID = @Country_ID";

            SqlCommand Command = new SqlCommand(Query, Connect);

            Command.Parameters.AddWithValue("@First_Name", First_Name);
            Command.Parameters.AddWithValue("@Country_ID", Country_ID);

            try
            {
                Connect.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    int ContactID = (int)Reader["ContactID"];
                    string FirstName1 = (string)Reader["FirstName"];
                    string LastName = (string)Reader["LastName"];
                    string Email = (string)Reader["Email"];
                    string Phone = (string)Reader["Phone"];
                    string Address = (string)Reader["Address"];
                    int CountryID = (int)Reader["CountryID"];

                    Console.WriteLine("ContactID : {0}", ContactID);
                    Console.WriteLine("FirtsName : {0}", FirstName1);
                    Console.WriteLine("LastName : {0}", LastName);
                    Console.WriteLine("Email : {0}", Email);
                    Console.WriteLine("Phone : {0}", Phone);
                    Console.WriteLine("Address : {0}", Address);
                    Console.WriteLine("CountryID : {0}", CountryID);
                    Console.WriteLine();
                }

                Command.Clone(); Connect.Close();
            }catch(Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }

        }

        static string GetScalar(int Country_ID)
        {
            string FirstName = "";

            SqlConnection Connect = new SqlConnection(ConnectString);
            string Query = "select FirstName From Contacts where CountryID = @Country_ID";

            SqlCommand Command = new SqlCommand(Query, Connect);

            Command.Parameters.AddWithValue("@Country_ID", Country_ID);

            try
            {
                Connect.Open();

                object result = Command.ExecuteScalar();

                if (result != null)
                {
                    FirstName = result.ToString();
                }
                else
                    FirstName = "";


                Command.Clone(); Connect.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            return FirstName;
        }

        static void Search(string Search)
        {
            SqlConnection Connect = new SqlConnection(ConnectString);

            string Query = "select *From Contacts where FirstName like ''+ @Search + '%' And CountryID = 1";

            SqlCommand Command = new SqlCommand(Query, Connect);
            Command.Parameters.AddWithValue("@Search", Search);

            try
            {
                Connect.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    int ContactID = (int)Reader["ContactID"];
                    string FirstName1 = (string)Reader["FirstName"];
                    string LastName = (string)Reader["LastName"];
                    string Email = (string)Reader["Email"];
                    string Phone = (string)Reader["Phone"];
                    string Address = (string)Reader["Address"];
                    int CountryID = (int)Reader["CountryID"];

                    Console.WriteLine("ContactID : {0}", ContactID);
                    Console.WriteLine("FirtsName : {0}", FirstName1);
                    Console.WriteLine("LastName : {0}", LastName);
                    Console.WriteLine("Email : {0}", Email);
                    Console.WriteLine("Phone : {0}", Phone);
                    Console.WriteLine("Address : {0}", Address);
                    Console.WriteLine("CountryID : {0}", CountryID);
                    Console.WriteLine();
                }

                Command.Clone(); Connect.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }

        }

        static void Main(string[] args)
        {

           PrintAllDataBase("Ali", 1);

            Console.WriteLine(GetScalar(1));
            Console.WriteLine();

            Search("Al");
            Console.ReadKey();
        }
    }
}
