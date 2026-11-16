using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIBMS.Sale.Sale_Report;
using LIBMS_Business;

namespace LIBMS.Sale
{
    public partial class frmAddUpdateBookSale : Form
    {
        public enum enMode { AddNew = 0, Update = 1}
        public enMode Mode = enMode.AddNew;
        public int SaleID { get; set; }
        int oldCopies = 0;
        public frmAddUpdateBookSale()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public frmAddUpdateBookSale(int SaleID)
        {
            InitializeComponent();
            Mode = enMode.Update;
            this.SaleID = SaleID;
        }

        clsSale _clsSale = new clsSale();
        private DataTable dtSales = new DataTable();
        private decimal InvoiceTotal = 0;

        private decimal TotalAmountCalculateAndUpdateTotalAmount()
        {
            return clsSale.GetTotalAmount(SaleID);
        }

        private void AddToGrid()
        {
            DataRow row = dtSales.NewRow();

            row["BookID"] = lblBookID.Text;
            row["Title"] = txtBookTitle.Text;
            row["Price"] = txtPrice.Text;
            row["Quentity"] = numericUpDown1.Value;
            row["LineTotal"] = txtTotal.Text;

            InvoiceTotal += decimal.Parse(txtTotal.Text);
            lblTotalAmount.Text = InvoiceTotal.ToString();

            dtSales.Rows.Add(row);
        }

        private void CreateAndRenameDt()
        {
            dtSales.Columns.Add("BookID");
            dtSales.Columns.Add("Title");
            dtSales.Columns.Add("Price");
            dtSales.Columns.Add("Quentity");
            dtSales.Columns.Add("LineTotal");

            dgvBookSale.DataSource = dtSales;
            dgvBookSale.AllowUserToAddRows = false;
        }

        private void calculateTotal()
        {
            decimal UnitPrice = decimal.Parse(txtPrice.Text);

            int Quentity = (int)numericUpDown1.Value;

            decimal TotalPrice = (UnitPrice * Quentity);

            txtTotal.Text = TotalPrice.ToString();
        }

        private void Frm_DataBackFromBookItems(object sender,  int BookID, string ISBN, string Title, decimal Price)
        {
            lblISNB.Text = ISBN;
            lblBookID.Text = BookID.ToString();
            txtBookTitle.Text = Title;
            txtPrice.Text = Price.ToString();
            numericUpDown1.Value = 1;

            calculateTotal();
        }

        private void Frm_DataBackFromCustumers(object sender, int CustomerID, string CustomerName)
        {
            lblCustomerID.Text = CustomerID.ToString();
            txtCustomerName.Text = CustomerName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBookItemsShow frm = new frmBookItemsShow();
            frm.DataBack += Frm_DataBackFromBookItems;
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCustomersShow frm = new frmCustomersShow();
            frm.DataBack += Frm_DataBackFromCustumers;
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            lblISNB.Text = "#ID";
            lblBookID.Text = "#ID";
            txtBookTitle.Text = "";
            txtPrice.Text = "";
            txtTotal.Text = "";

            if(Mode == enMode.AddNew)
            {
                lblSaleID.Text = "#ID";
                lblCustomerID.Text = "#ID";
                txtCustomerName.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                if(dgvBookSale.Rows.Count > 0)
                {
                    dtSales.Rows.Clear();
                }
            }
        }
        private void UpdateSaleDetails()
        {
            int newCopies = 0;
            _clsSale.SaleDetailID = (int)dgvBookSale.CurrentRow.Cells[0].Value;
            _clsSale.SaleID = int.Parse(lblSaleID.Text);
            _clsSale.BookID = int.Parse(lblBookID.Text);
            newCopies = int.Parse(numericUpDown1.Value.ToString());
            _clsSale.UnitPrice = decimal.Parse(txtPrice.Text);
            _clsSale.LineTotal = decimal.Parse(txtTotal.Text);

            int Differrence = newCopies - oldCopies;
            _clsSale.AvailableCopies = Differrence;
            _clsSale.Quantity = newCopies;


            // For added copies
            if ( _clsSale.AvailableCopies > 0 && _clsSale.CheckSaleValid())
            {
                UpdateSalesDetails();
                return;
            }

            if (_clsSale.AvailableCopies > 0 && !_clsSale.CheckSaleValid())
            {
                MessageBox.Show("The Stock is insufficient", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdateSalesDetails();
        }
        private void UpdateSalesDetails()
        {
            if (_clsSale.UpdateSaleDetails())
                MessageBox.Show("Done Update :-)", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            RefreshData();
            lblTotalAmount.Text = GetTotalAmountForBeforSaveFromdgv().ToString();

            _clsSale.SaleID = int.Parse(lblSaleID.Text);
            _clsSale.TotalAmount = TotalAmountCalculateAndUpdateTotalAmount();
            _clsSale.UpdateTotalAmount();
        }
        private void btnAddToGrid_Click(object sender, EventArgs e)
        {
            int intParse = 0;
            if(int.TryParse(lblBookID.Text, out intParse))
            {
                _clsSale.BookID = intParse;
            }

            int intParse2 = 0;
            if (int.TryParse(numericUpDown1.Text, out intParse2))
            {
                _clsSale.AvailableCopies = intParse2;
            }

            if(lblBookID.Text != "#ID")
            {
                if (Mode == enMode.AddNew)
                {
                    if (_clsSale.CheckSaleValid())
                    {
                        AddToGrid();
                    }
                    else
                        MessageBox.Show("The Stock is insufficient", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UpdateSaleDetails();
                }
            }else
            {
                MessageBox.Show("Please, enter invoice Data!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
        private void frmAddUpdateBookSale_Load(object sender, EventArgs e)
        {
            if(Mode == enMode.AddNew)
            {
                CreateAndRenameDt();
                getDataToFormToolStripMenuItem.Visible = false;
            }else
            {
                button2.Enabled = false;
                btnAddToGrid.Text = "Update";
                btnAddToGrid.TextAlign = ContentAlignment.MiddleCenter;
                tsmShowDetails.Text = "Update";
                tsmShowDetails.Visible = false;
                InvoiceDateHeader();
                RefreshData();
            }
        }

        private void InvoiceDateHeader()
        {
            DataTable dtInvoiceHeader = clsSale.GetInvoiceHeader(SaleID);

            if(dtInvoiceHeader.Rows.Count > 0)
            {
                DataRow row = dtInvoiceHeader.Rows[0];

                lblSaleID.Text = row["SaleID"].ToString();
                dateTimePicker1.Text = row["SateDate"].ToString();
                lblCustomerID.Text = row["PersonID"].ToString();
                txtCustomerName.Text = row["CustomerName"].ToString();
                lblTotalAmount.Text = row["TotalAmount"].ToString();
            }
            


        }

        private void RefreshData()
        {
            DataTable dtSaleDetails = clsSale.GetSaleDetailsBySaleID(SaleID);

            dgvBookSale.DataSource = dtSaleDetails;
            dgvBookSale.AllowUserToAddRows = false;
        }

        private void AddSeleDetails()
        {
            bool isSighn = false;

            foreach (DataGridViewRow row in dgvBookSale.Rows)
            {
                if (row.IsNewRow)
                    continue;

                _clsSale.SaleID = int.Parse(lblSaleID.Text);
                _clsSale.BookID = int.Parse(row.Cells[0].Value.ToString());
                _clsSale.UnitPrice = decimal.Parse(row.Cells[2].Value.ToString());
                _clsSale.Quantity = int.Parse(row.Cells[3].Value.ToString());
                _clsSale.LineTotal = decimal.Parse(row.Cells[4].Value.ToString());

                _clsSale.AddSaleDetails();
            }
            MessageBox.Show("Done insert :-)", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        // Save
        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            if(Mode == enMode.AddNew)
            {
                _clsSale.SaleDate = dateTimePicker1.Value;
                _clsSale.TotalAmount = decimal.Parse(lblTotalAmount.Text);
                _clsSale.CustomerID = int.Parse(lblCustomerID.Text);
                _clsSale.AddBookSale();

                lblSaleID.Text = _clsSale.SaleID.ToString();

                AddSeleDetails();
            }

        }

        private decimal GetTotalAmountForBeforSaveFromdgv()
        {
            decimal cellTotalAmount = 0;
            foreach(DataGridViewRow row in dgvBookSale.Rows)
            {
                if (row.Cells["LineTotal"].Value != null)
                {
                    decimal cellValue = 0;
                    if (decimal.TryParse(row.Cells["LineTotal"].Value.ToString(), out cellValue))
                    {
                        cellTotalAmount += cellValue;
                    }
                }
            }
            return cellTotalAmount;
        }

        // Delete
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (dgvBookSale.SelectedRows.Count > 0)
                {
                    if(Mode == enMode.AddNew)
                    {
                        if (lblSaleID.Text == "#ID")
                        {
                            DataGridViewRow selectRow = dgvBookSale.SelectedRows[0];

                            DataRowView rowView = (DataRowView)selectRow.DataBoundItem;

                            rowView.Row.Delete();
                            lblTotalAmount.Text = GetTotalAmountForBeforSaveFromdgv().ToString();
                        }
                        else
                        {
                            MessageBox.Show("Sory Donot edit form here", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        }
                    }else
                    {
                        if(clsSale.DeleteSaleDetailsBySaleID((int)dgvBookSale.CurrentRow.Cells[0].Value))
                        {
                            DataGridViewRow selectRow = dgvBookSale.SelectedRows[0];

                            DataRowView rowView = (DataRowView)selectRow.DataBoundItem;

                            rowView.Row.Delete();
                            lblTotalAmount.Text = TotalAmountCalculateAndUpdateTotalAmount().ToString();

                            _clsSale.SaleID = int.Parse(lblSaleID.Text);
                            _clsSale.TotalAmount = TotalAmountCalculateAndUpdateTotalAmount();
                            _clsSale.UpdateTotalAmount();
                        }
                    }
                }
            }
            else
                MessageBox.Show("The delete Operation is feiled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Print
        private void copiesSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lblSaleID.Text != "#ID")
            {
                frmSaleReport frm = new frmSaleReport(int.Parse(lblSaleID.Text));
                frm.ShowDialog();
            }else
            {
                MessageBox.Show("Enter and save the data before print its.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void getDataToFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblISNB.Text = dgvBookSale.CurrentRow.Cells["ISBN"].Value.ToString();
            lblBookID.Text = dgvBookSale.CurrentRow.Cells["BookID"].Value.ToString();
            txtBookTitle.Text = dgvBookSale.CurrentRow.Cells["BookTitle"].Value.ToString();
            txtPrice.Text = dgvBookSale.CurrentRow.Cells["UnitPrice"].Value.ToString();
            numericUpDown1.Text = dgvBookSale.CurrentRow.Cells["Quantity"].Value.ToString();
            oldCopies = int.Parse(dgvBookSale.CurrentRow.Cells["Quantity"].Value.ToString());

            txtTotal.Text = dgvBookSale.CurrentRow.Cells["LineTotal"].Value.ToString();
        }
    }
}
