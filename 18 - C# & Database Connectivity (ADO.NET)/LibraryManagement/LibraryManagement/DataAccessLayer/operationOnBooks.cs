using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagement.DataAccessLayer
{
    class operationOnBooks
    {
        public DataTable GetAllCategories()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(StringConnection.stringConnection);


            string query = "SELECT *FROM CATEGORIES;";
            SqlCommand command = new SqlCommand(query, connection);

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
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public int AddNewContact(string CategoryName)
        {
            //this function will return the new contact id if succeeded and -1 if not.
            int ContactID = -1;

            SqlConnection connection = new SqlConnection(StringConnection.stringConnection);

            string query = @"INSERT INTO  CATEGORIES(Category_Name)
                             VALUES (@CategoryName);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CategoryName", CategoryName);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null)
                {
                    ContactID = Convert.ToInt32(result.ToString());
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return ContactID;
        }

        public bool UpdateContact(int ID, string Category_Name)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(StringConnection.stringConnection);

            string query = @"update CATEGORIES 
                             set Category_Name = @Category_Name
                             where ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Category_Name", Category_Name);
            command.Parameters.AddWithValue("@ID", ID);

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

        public bool DeleteContact(int ID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(StringConnection.stringConnection);

            string query = @"Delete CATEGORIES 
                                where ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }

        public DataTable SearchCategories(string Category_Name)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(StringConnection.stringConnection);
            string query = @"select *from CATEGORIES where Category_Name like '%' + @Category_Name + '%';";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Category_Name", Category_Name);

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
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public void Order()
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(StringConnection.stringConnection);

            string query = @"DECLARE @Maxid INT 
                             SELECT @Maxid = MAX (ID) FROM CATEGORIES

                             UPDATE CATEGORIES SET ID = RowNumber 
                             from 
                             (
                             SELECT ID, ROW_NUMBER() OVER (ORDER BY ID) AS RowNumber
                                                                     FROM CATEGORIES
                             ) AS subquery
                             WHERE CATEGORIES.ID = subquery.ID;
                             DBCC CHECKIDENT ('CATEGORIES', RESEED, @Maxid);";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }

            finally
            {
                connection.Close();
            }
        }
    }
}
