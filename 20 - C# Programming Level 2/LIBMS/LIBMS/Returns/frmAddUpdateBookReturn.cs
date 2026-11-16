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
    public partial class frmAddUpdateBookReturn : Form
    {
        public int SaleID { get; set; }
        public frmAddUpdateBookReturn(int SaleID)
        {
            InitializeComponent();
            this.SaleID = SaleID;
        }
        private decimal returnValue = 0;
        private void SetupRetrunDetailsColumns()
        {
            dgvBookReturn.Columns.Clear();

            dgvBookReturn.Columns.Add("BookID", "Book ID");
            dgvBookReturn.Columns.Add("SaleDetailID", "SaleDetailID");
            dgvBookReturn.Columns.Add("BookTitle", "Book Title");
            dgvBookReturn.Columns.Add("UnitPrice", "Unit Price");
            dgvBookReturn.Columns.Add("QtyReturned", "Qty Returned");
            dgvBookReturn.Columns.Add("LineTotal", "Line Total");

            dgvBookReturn.Columns["BookID"].Visible = false;
            dgvBookReturn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void RefreshData()
        {
            DataTable dtSaleDetails = clsSale.GetSaleDetailsBySaleID(SaleID);

            dgvBookSale.DataSource = dtSaleDetails;
            dgvBookSale.AllowUserToAddRows = false;
        }
        private void frmAddUpdateBookReturn_Load(object sender, EventArgs e)
        {
            lblInvoiceTotal.Text = clsReturn.GetTotalAmountBySaleID(SaleID).ToString();

            SetupRetrunDetailsColumns();
            cbReason.SelectedIndex = 0;

            RefreshData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void GetDataToReturnInfo()
{
    if (dgvBookSale.CurrentRow == null) return;
    try
    {
        int selectedSaleDetailID = Convert.ToInt32(dgvBookSale.CurrentRow.Cells["SaleDetailID"].Value);

        DataTable dtsaleDetail = clsReturn.GetBookDetails(selectedSaleDetailID);

        if (dtsaleDetail != null)
        {
            DataRow saleDetailRow = dtsaleDetail.Rows[0];

            lblCustomerID.Text = saleDetailRow["CustomerID"].ToString();
            txtCustomerName.Text = saleDetailRow["Customer Name"].ToString();
            lblSaleID.Text = saleDetailRow["SaleID"].ToString();

            lblBookID.Text = saleDetailRow["BookID"].ToString();
            lblSaleDetailID.Text = saleDetailRow["SaleDetailID"].ToString();
            txtBookTitle.Text = saleDetailRow["Book Title"].ToString();
            txtPrice.Text = Convert.ToDecimal(saleDetailRow["Price"]).ToString("F2");
            
            numQuantity.Value = 0; 
            numQuantity.Maximum = Convert.ToInt32(saleDetailRow["Quantity"]); 
            
            txtTotal.Text = "0.00";
        }
        else
        {
            MessageBox.Show("The is not found.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("The error done when git data." + ex.Message, "ERROR in Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

        private void getDataToFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataToReturnInfo();
        }

        private void ResetReturnInfoTools()
        {
            lblSaleDetailID.Text = "#ID";
            lblBookID.Text = "#ID";
            lblCustomerID.Text = "#ID";
            txtBookTitle.Clear();
            txtCustomerName.Clear();
            txtPrice.Text = "0.00";
            numQuantity.Value = 0;
            txtTotal.Text = "0.00";
            cbReason.SelectedIndex = -1;
        }
        private void CalculateReturnSummary(decimal TotalAmount)
        {
             returnValue += TotalAmount;
             lblReturnValue.Text = returnValue.ToString();
        }
        private void AddToGrid()
        {
            if (lblBookID.Text == "#ID" || numQuantity.Value <= 0)
            {
                MessageBox.Show("Please, Choose the book and specific the count its!", "warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookId = Convert.ToInt32(lblBookID.Text);
            string isbn = lblSaleDetailID.Text;
            string bookTitle = txtBookTitle.Text;
            decimal price = Convert.ToDecimal(txtPrice.Text);
            int qtyRequestedToReturn = Convert.ToInt32(numQuantity.Value);

            int originalSaleQty = 0;
            foreach (DataGridViewRow saleRow in dgvBookSale.Rows)
            {
                if (saleRow.Cells["BookID"].Value != null && Convert.ToInt32(saleRow.Cells["BookID"].Value) == bookId)
                {
                    originalSaleQty = Convert.ToInt32(saleRow.Cells["Quantity"].Value);
                    break;
                }
            }

            int alreadyReturnedQty = 0;
            DataGridViewRow existingReturnRow = null;

            foreach (DataGridViewRow returnRow in dgvBookReturn.Rows)
            {
                if (returnRow.Cells["BookID"].Value != null && Convert.ToInt32(returnRow.Cells["BookID"].Value) == bookId)
                {
                    alreadyReturnedQty = Convert.ToInt32(returnRow.Cells["QtyReturned"].Value);
                    existingReturnRow = returnRow;
                    break;
                }
            }

            int totalFutureReturnQty = alreadyReturnedQty + qtyRequestedToReturn;

            if (totalFutureReturnQty > originalSaleQty)
            {
                int maxAllowed = originalSaleQty - alreadyReturnedQty;

                string errorMessage = string.Format("Accounting Error: This quantity connot be returned!\n\n" +
                                                    "Original quantity Purchased : {0}\n" +
                                                    "Quantity already returned: {1}\n" +
                                                    "Maximum quantity you can return now is: {2}",
                                                    originalSaleQty, alreadyReturnedQty, maxAllowed);

                MessageBox.Show(errorMessage, "Sales Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (existingReturnRow != null)
            {
                existingReturnRow.Cells["QtyReturned"].Value = totalFutureReturnQty;
                existingReturnRow.Cells["LineTotal"].Value = totalFutureReturnQty * price;
            }
            else
            {
                decimal lineTotal = price * qtyRequestedToReturn;
                dgvBookReturn.Rows.Add(bookId, isbn, bookTitle, price, qtyRequestedToReturn, lineTotal);
            }

            CalculateReturnSummary(decimal.Parse(txtTotal.Text));
            ResetReturnInfoTools();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddToGrid();
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            txtTotal.Text = (decimal.Parse(txtPrice.Text) * (decimal)numQuantity.Value).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            lblNewBalance.Text = clsReturn.GetTotalAmountBySaleID(SaleID).ToString();
            RefreshData();
        }

        private void SaveData()
        {
            DataTable detailsTable = new DataTable();
            detailsTable.Columns.Add("SaleDetailID", typeof(int));
            detailsTable.Columns.Add("ReturnedQuantity", typeof(int));
            detailsTable.Columns.Add("RefundAmount", typeof(decimal));

            foreach (DataGridViewRow row in dgvBookReturn.Rows)
            {
                if (row.Cells["SaleDetailID"].Value != null)
                {
                    detailsTable.Rows.Add(
                        Convert.ToInt32(row.Cells["SaleDetailID"].Value),
                        Convert.ToInt32(row.Cells["QtyReturned"].Value),
                        Convert.ToDecimal(row.Cells["LineTotal"].Value)
                    );
                }
            }

            try
            {
                int saleID = Convert.ToInt32(lblSaleID.Text);
                DateTime returnDate = dateTimePicker1.Value;
                string reason = cbReason.Text;
                decimal totalRefund = Convert.ToDecimal(lblInvoiceTotal.Text);

                bool success = clsReturn.ProcessBookReturn(saleID, returnDate, reason, totalRefund, detailsTable);

                if (success)
                {
                    MessageBox.Show("Done");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                lblReturnID.Text = clsReturn.newReturnID.ToString();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
            lblNewBalance.Text = clsReturn.GetTotalAmountBySaleID(SaleID).ToString();
            RefreshData();
        }
    }
}
