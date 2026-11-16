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

namespace LIBMS.Returns
{
    public partial class frmReturnReport : Form
    {
        public int SaleID { get; set; }
        public frmReturnReport(int SaleID)
        {
            InitializeComponent();
            this.SaleID = SaleID;
        }

        private void MoveDataToReport()
        {
            DataTable InvoiceDetails = clsReturn.GetDataForReturnInvoiceDetails(SaleID);
            InvoiceDetails.TableName = "ReturnDetailsInvoice";

            DataTable InvoiceHeader = clsReturn.GetDataForReturnInvoiceHeader(SaleID);
            InvoiceDetails.TableName = "ReturnHeaderInvoice";

            ReturnReport report = new ReturnReport();
            report.Database.Tables["ReturnDetailsInvoice"].SetDataSource(InvoiceDetails);
            report.Database.Tables["ReturnHeaderInvoice"].SetDataSource(InvoiceHeader);

            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }

        private void frmReturnReport_Load(object sender, EventArgs e)
        {
            MoveDataToReport();
        }

    }
}
