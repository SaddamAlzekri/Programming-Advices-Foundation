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

namespace LIBMS.Sale
{
    public partial class frmBookItemsShow : Form
    {
        public delegate void DataBackEventHandler(object sender, int BookID, string ISBN, string Title, decimal Price);
        public event DataBackEventHandler DataBack;

        public frmBookItemsShow()
        {
            InitializeComponent();
        }
        private DataTable _dtBookItems;
        private void frmBookItemsShow_Load(object sender, EventArgs e)
        {
            _dtBookItems = clsSale.GetBooksAndBookItemsData();
            dgvBookItems.DataSource = _dtBookItems;
            dgvBookItems.AllowUserToAddRows = false;
            lblRecordsCount.Text = dgvBookItems.Rows.Count.ToString();
            cbFilterBy.SelectedIndex = 0;
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            
            switch (cbFilterBy.Text)
            {
                case "ItemID":
                    FilterColumn = "ItemID";
                    break;

                case "BookID":
                    FilterColumn = "BookID";
                    break;

                case "SerialNumber":
                    FilterColumn = "SerialNumber";
                    break;

                case "CopyStatus":
                    FilterColumn = "CopyStatus";
                    break;

                case "LocationRack":
                    FilterColumn = "LocationRack";
                    break;

                case "Price":
                    FilterColumn = "Price";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilterValue.Text.Trim() == "" || cbFilterBy.Text == "None")
            {
                _dtBookItems.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvBookItems.Rows.Count.ToString();
            }

            if (FilterColumn == "ItemID" || FilterColumn == "BookID" || FilterColumn == "Price")
            {
                if (!string.IsNullOrEmpty(txtFilterValue.Text))
                {
                    _dtBookItems.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
                }
            }
            else
                _dtBookItems.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvBookItems.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "ItemID" || cbFilterBy.Text == "BookID" || cbFilterBy.Text == "Price")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChose_Click(object sender, EventArgs e)
        {
            int BookID = (int)dgvBookItems.CurrentRow.Cells[0].Value;
            string ISBN = dgvBookItems.CurrentRow.Cells[1].Value.ToString();
            string Title = dgvBookItems.CurrentRow.Cells[2].Value.ToString();
            decimal Price = decimal.Parse(dgvBookItems.CurrentRow.Cells[7].Value.ToString());

            if (DataBack != null)
            {
                DataBack.Invoke(this, BookID, ISBN, Title, Price);
            }
            this.Close();
        }

        private void dgvBookItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                btnChose.PerformClick();
            }
        }
    }
}
