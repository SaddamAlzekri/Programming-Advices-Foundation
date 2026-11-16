using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {

        string connectionString =
             "Server=.;Database=EmployeesDB;User Id=sa;Password=123456;";
        DataSet dataSet = new DataSet();


        // Create a new DataAdapter with a SELECT query and the connection string
        string query = "SELECT * FROM Employees;";
        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connectionString);

        // Open the connection
        SqlConnection connection = new SqlConnection(connectionString);

       
       connection.Open();

            // Set the SelectCommand of the DataAdapter to the connection
       dataAdapter.SelectCommand.Connection = connection;

       // Fill the DataSet with data from the data source
       dataAdapter.Fill(dataSet, "Employees");

       connection.Close();

        // Display the data from the DataSet
        DataTable customersTable = dataSet.Tables["Employees"];
        foreach (DataRow row in customersTable.Rows)
        {
            Console.WriteLine("{0} \t {1} \t {2} \t {3}", row["EmployeeID"], row["Name"], row["ManagerID"], row["Salary"]);
        }

        Console.ReadKey();
    }
}



class Program
{
    static void Main()
    {


        // Create a new DataAdapter with a SELECT query and the connection string
 

        // Open the connection
       


        // Display the data from the DataSet
   

        Console.ReadKey();
    }
}
