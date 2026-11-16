using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsTestTypeData
    {
        public static bool GetTestTypeInfoByID(int TestTypeID, ref string TestTypeTitle, ref string TestDescription ,ref float TestFees)
        {
            bool isFound = true;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.conection);
            string query = "SELECT * FROM TestTypes WHERE TestTypeID = @TestTypeID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    TestTypeTitle = (string)reader["TestTypeTitle"];
                    TestDescription = (string)reader["TestTypeDescription"];
                    TestFees = Convert.ToSingle(reader["TestTypeFees"]);
                }else
                {
                    isFound = false;
                }
                reader.Close();
            }catch(Exception ex)
            {
                isFound = false;
            }finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static DataTable GetAllTestType()
        {
            DataTable dtAllTestType = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.conection);
            string query = "SELECT * FROM TestTypes order by TestTypeID";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                if(reader.HasRows)
                {
                    dtAllTestType.Load(reader);
                }
                reader.Close();
            }catch(Exception ex)
            {

            }finally
            {
                connection.Close();
            }
            return dtAllTestType;
        }

        public static int AddNewTestType( string Title,string Description, float Fees)
        {
            int TestTypeID = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.conection);

            string query = @"Insert Into TestTypes (TestTypeTitle,TestTypeTitle,TestTypeFees)
                            Values (@TestTypeTitle,@TestTypeDescription,@ApplicationFees)
                            where TestTypeID = @TestTypeID;
                            SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeTitle", Title);
            command.Parameters.AddWithValue("@TestTypeDescription", Description);
            command.Parameters.AddWithValue("@ApplicationFees", Fees);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                int objectResult = -1;
                if(result != null && int.TryParse(result.ToString() , out objectResult))
                {
                    TestTypeID = objectResult;
                }
                
            }catch(Exception ex)
            {

            }finally
            {
                connection.Close();
            }
            return TestTypeID;
        }

        public static bool UpdateTestType(int TestTypeID,string Title,string Description, float Fees)
        {
            int rowAffect = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.conection);
            string query = @"Update  TestTypes  
                            set TestTypeTitle = @TestTypeTitle,
                                TestTypeDescription=@TestTypeDescription,
                                TestTypeFees = @TestTypeFees
                                where TestTypeID = @TestTypeID";
            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@TestTypeTitle", Title);
            command.Parameters.AddWithValue("@TestTypeDescription", Description);
            command.Parameters.AddWithValue("@TestTypeFees", Fees);

            try
            {
                connection.Open();
                rowAffect = command.ExecuteNonQuery();

            }catch(Exception ex)
            {
                return false;
            }finally
            {
                connection.Close();
            }
            return (rowAffect > 0);
        }

    }
}
