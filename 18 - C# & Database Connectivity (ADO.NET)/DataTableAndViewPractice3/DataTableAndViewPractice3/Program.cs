using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTableAndViewPractice3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable EmployeesDataTable = new DataTable();
            DataColumn dColumn = new DataColumn();

            dColumn.DataType = typeof(int);
            dColumn.ColumnName = "ID";
            dColumn.AutoIncrement = true;
            dColumn.AutoIncrementSeed = 1;
            dColumn.AutoIncrementStep = 1;

            dColumn.Caption = "Employee ID";
            dColumn.ReadOnly = true;
            dColumn.Unique = true;
            EmployeesDataTable.Columns.Add(dColumn);
            //////////////////////////////
            dColumn = new DataColumn();
            dColumn.DataType = typeof(string);
            dColumn.ColumnName = "Name";
            dColumn.AutoIncrement = false;
            dColumn.Caption = "Employee Name";
            dColumn.ReadOnly = false;
            dColumn.Unique = false;
            EmployeesDataTable.Columns.Add(dColumn); 
            //////////////////////////////
            dColumn = new DataColumn();
            dColumn.DataType = typeof(string);
            dColumn.ColumnName = "Country";
            dColumn.AutoIncrement = false;
            dColumn.Caption = "Employee Country";
            dColumn.ReadOnly = false;
            dColumn.Unique = false;
            EmployeesDataTable.Columns.Add(dColumn);
            //////////////////////////////

            dColumn = new DataColumn();
            dColumn.DataType = typeof(double);
            dColumn.ColumnName = "Salary";
            dColumn.AutoIncrement = false;
            dColumn.Caption = "Employee Salary";
            dColumn.ReadOnly = false;
            dColumn.Unique = false;

            EmployeesDataTable.Columns.Add(dColumn);
            //////////////////////////////
            dColumn = new DataColumn();
            dColumn.DataType = typeof(DateTime);
            dColumn.ColumnName = "Date";
            dColumn.AutoIncrement = false;
            dColumn.Caption = "Employee Date";
            dColumn.ReadOnly = false;
            dColumn.Unique = false;
            EmployeesDataTable.Columns.Add(dColumn);

            DataColumn[] primarykey = new DataColumn[1];
            primarykey[0] = EmployeesDataTable.Columns["ID"];
            EmployeesDataTable.PrimaryKey = primarykey;

            EmployeesDataTable.Rows.Add(null, "Saddam Alzekri", "YEMEN", 6000, DateTime.Now);
            EmployeesDataTable.Rows.Add(null, "Ali Alzekri", "YEMEN", 6000, DateTime.Now);
            EmployeesDataTable.Rows.Add(null, "Samir Alzekri", "UAE", 6000, DateTime.Now);
            EmployeesDataTable.Rows.Add(null, "Samira Alzekri", "USA", 6000, DateTime.Now);
            EmployeesDataTable.Rows.Add(null, "Shaker Almagrami", "EYGPT", 6000, DateTime.Now);

            Console.WriteLine("\nDataTable\n");

            foreach(DataRow rows in EmployeesDataTable.Rows)
            {
                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}", rows["ID"], rows["Name"], rows["Country"], rows["Salary"], rows["Date"]);
            }

            DataView DataView = new DataView();
            DataView = EmployeesDataTable.DefaultView;

            Console.WriteLine("\nDataView\n");

            for (int i = 0; i < DataView.Count; i++)
            {
                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}", DataView[i][0], DataView[i][1], DataView[i][2], DataView[i][3], DataView[i][4]);
            }

            DataView.RowFilter = "Country = 'YEMEN'";

            Console.WriteLine("\nRowFilter\n");

            for (int i = 0; i < DataView.Count; i++)
            {
                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}", DataView[i][0], DataView[i][1], DataView[i][2], DataView[i][3], DataView[i][4]);
            }

            DataView.Sort = "Name ASC";

            Console.WriteLine("\nSortting\n");

            for (int i = 0; i < DataView.Count; i++)
            {
                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}", DataView[i][0], DataView[i][1], DataView[i][2], DataView[i][3], DataView[i][4]);
            }
                Console.ReadKey();
        }
    }
}
