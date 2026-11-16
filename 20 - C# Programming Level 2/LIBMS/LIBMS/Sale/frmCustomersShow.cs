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
    public partial class frmCustomersShow : Form
    {
        public delegate void DataBackEventHandler(object sender, int CustomerID,string CustomerName);
        public event DataBackEventHandler DataBack;

        public frmCustomersShow()
        {
            InitializeComponent();
        }
        private DataTable _dtGetAllCustomers;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCustomersShow_Load(object sender, EventArgs e)
        {
            _dtGetAllCustomers = clsCustomers.GetAllCustomers();
            dgvCustomers.DataSource = _dtGetAllCustomers;
            dgvCustomers.AllowUserToAddRows = false;
            lblRecordsCount.Text = dgvCustomers.Rows.Count.ToString();
            cbFilterBy.SelectedIndex = 0;
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "PersonID":
                    FilterColumn = "PersonID";
                    break;

                case "NationalNo":
                    FilterColumn = "NationalNo";
                    break;

                case "FullName":
                    FilterColumn = "FullName";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "CountryName":
                    FilterColumn = "CountryName";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilterValue.Text.Trim() == "" || cbFilterBy.Text == "None")
            {
                _dtGetAllCustomers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvCustomers.Rows.Count.ToString();
            }

            if (FilterColumn == "PersonID")
            {
                if (!string.IsNullOrEmpty(txtFilterValue.Text))
                {
                    _dtGetAllCustomers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
                }
            }
            else
                _dtGetAllCustomers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvCustomers.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "PersonID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnChose_Click(object sender, EventArgs e)
        {
            if (DataBack != null)
            {
                DataBack.Invoke(this, (int)dgvCustomers.CurrentRow.Cells[0].Value, dgvCustomers.CurrentRow.Cells[3].Value.ToString());
            }
            this.Close();
        }

        private void dgvCustomers_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                btnChose.PerformClick();
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
