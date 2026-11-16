using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static DataTable GetNationalNo(string NationalNo)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection("Server = .; Database = DVLD; User Id = sa; Password = 123456");

            string query = "select NationalNo from People where NationalNo = @NationalNo;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                    reader.Close();
                }
            }
            catch { }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static int AddNewPeople(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, string DateOfBirth,
                         int Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int ContactID = -1;

            SqlConnection connection = new SqlConnection("Server = .; Database = DVLD; User Id = sa; Password = 123456");

            string query = @"INSERT INTO  People(NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, 
                                                 Address, Phone ,Email, NationalityCountryID, ImagePath)
                                                 VALUES (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, 
                                                 @Gendor, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath);
                                                 SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null)
                {
                    ContactID = Convert.ToInt32(result.ToString());
                }
            }

            catch { }

            finally
            {
                connection.Close();
            }

            return ContactID;
        }

        static void Main(string[] args)
        {
            
            Console.Write(AddNewPeople("N12", "Saddam", "Hussein", "Sharaf","Alzekri",  "2005-06-01 20:13:44.000", 0, "Al-Turba Town", "712126932",
         "Saddam@gmail.com", 90, "C:"));

            Console.ReadKey();
        }
    }
}
