using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmptyReportWithCrystalReport
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection("server = .; DataBase = DVLD; User Id = sa; PassWord = 123456;");

            string query =
              @"select *from Users;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                string sourceName = "Exception";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }

                EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Error);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        private void MoveDataToReport()
        {
            DataTable dtReportData = GetAllPeople();
            dtReportData.TableName = "Users";
            CrystalReport2 report2 = new CrystalReport2();
            report2.SetDataSource(dtReportData);
            crystalReportViewer1.ReportSource = report2;
            crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            MoveDataToReport();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
