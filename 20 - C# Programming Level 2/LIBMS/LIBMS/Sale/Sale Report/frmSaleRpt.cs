using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIBMS_Business;
//using LIBMS.Sale.Sale_Report;

namespace LIBMS.Sale.Sale_Report
{
    public partial class frmSaleRpt : Form
    {
        public int SaleID { get; set; }
        public frmSaleRpt(int SaleID)
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

            CrystalReport2 report = new CrystalReport2();
            report.Database.Tables["InvoiceDetails"].SetDataSource(InvoiceDetails);
            report.Database.Tables["InvoiceHeader"].SetDataSource(InvoiceHeader);

            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
        private void frmSaleRpt_Load(object sender, EventArgs e)
        {
            MoveDataToReport();
            //var myReport = new LIBMS.Sale.Sale_Report.CrystalReport2();
            //crystalReportViewer1.ReportSource = myReport;
            //crystalReportViewer1.RefreshReport();
        }

    }
}
