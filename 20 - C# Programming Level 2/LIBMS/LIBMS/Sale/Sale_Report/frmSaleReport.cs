using LIBMS_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBMS.Sale.Sale_Report
{
    public partial class frmSaleReport : Form
    {
        public int SaleID { get; set; }
        public frmSaleReport(int SaleID)
        {
            InitializeComponent();
            this.SaleID = SaleID;
        }

        private void MoveDataToReport()
        {
            DataTable InvoiceDetails = clsSale.GetDataForInvoiceDetails(SaleID);
            InvoiceDetails.TableName = "InvoiceDetails";

            DataTable InvoiceHeader = clsSale.GetDataForInvoiceHeader(SaleID);
            InvoiceDetails.TableName = "InvoiceHeader";

            SaleReport report = new SaleReport();
            report.Database.Tables["InvoiceDetails"].SetDataSource(InvoiceDetails);
            report.Database.Tables["InvoiceHeader"].SetDataSource(InvoiceHeader);

            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
        private void frmSaleReport_Load(object sender, EventArgs e)
        {
            MoveDataToReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
