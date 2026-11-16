using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIBMS.Sale;
using LIBMS.Returns;
using LIBMS.Sale.Sale_Report;
using LIBMS_Business;

namespace LIBMS.Sale
{
    public partial class frmBookSaleList : Form
    {
        public frmBookSaleList()
        {
            InitializeComponent();
        }

        private DataTable dtGetAllBookSaleData;
        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            frmAddUpdateBookSale frm = new frmAddUpdateBookSale();
            frm.ShowDialog();
            RefreshData();
        }

        private void RefreshData()
        {
            dtGetAllBookSaleData = clsSale.GetAllBookSale();
            dgvBookSale.DataSource = dtGetAllBookSaleData;
            dgvBookSale.AllowUserToAddRows = false;
            lblRecordsCount.Text = dgvBookSale.Rows.Count.ToString();
            cbFilterBy.SelectedIndex = 0;
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateBookSale frm = new frmAddUpdateBookSale((int)dgvBookSale.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshData();
        }

        private void frmBookSaleList_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            
            switch (cbFilterBy.Text)
            {
                case "InvoiceNo":
                    FilterColumn = "InvoiceNo";
                    break;

                case "FullName":
                    FilterColumn = "FullName";
                    break;

                case "SaleDate":
                    FilterColumn = "SaleDate";
                    break;

                case "TotalAmount":
                    FilterColumn = "TotalAmount";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilterValue.Text.Trim() == "" || cbFilterBy.Text == "None")
            {
                dtGetAllBookSaleData.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dtGetAllBookSaleData.Rows.Count.ToString();
            }

            if (FilterColumn == "InvoiceNo" || FilterColumn == "TotalAmount" || FilterColumn == "Phone")
            {
                if (!string.IsNullOrEmpty(txtFilterValue.Text))
                {
                    dtGetAllBookSaleData.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
                }
            }
            else
                dtGetAllBookSaleData.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dtGetAllBookSaleData.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "InvoiceNo" || cbFilterBy.Text == "TotalAmount" || cbFilterBy.Text == "Phone")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedIndex == 0)
            {
                txtFilterValue.ReadOnly = true;
            }
            else
                txtFilterValue.ReadOnly = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void copiesSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaleReport frm = new frmSaleReport((int)dgvBookSale.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (dgvBookSale.SelectedRows.Count > 0)
                {
                    try
                    {
                        clsSale.DeleteBookSaleWithStockRestoration((int)dgvBookSale.CurrentRow.Cells[0].Value);
                        RefreshData();
                        MessageBox.Show("Done Seccessfully");
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
                MessageBox.Show("The delete Operation is feiled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
        }

        private void returnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateBookReturn frm = new frmAddUpdateBookReturn((int)dgvBookSale.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

    }
}
