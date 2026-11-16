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
    public partial class frmBookReturnList : Form
    {
        public frmBookReturnList()
        {
            InitializeComponent();
        }

        private DataTable dtGetAllBookReturnData = new DataTable();

        private void copiesSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvBookReturn.Rows.Count > 0)
            {
                frmReturnReport frm = new frmReturnReport((int)dgvBookReturn.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
            }else
            {
                MessageBox.Show("The Table is Empty", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void RefreshData()
        {
            dtGetAllBookReturnData = clsReturn.GetAllBookReturn();
            dgvBookReturn.DataSource = dtGetAllBookReturnData;
            dgvBookReturn.AllowUserToAddRows = false;
            lblRecordsCount.Text = dgvBookReturn.Rows.Count.ToString();
            cbFilterBy.SelectedIndex = 0;
        }
        private void frmBookReturnList_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {




            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Return ID":
                    FilterColumn = "Return ID";
                    break;

                case "Original Sale ID":
                    FilterColumn = "Original Sale ID";
                    break;

                case "Customer Name":
                    FilterColumn = "Customer Name";
                    break;

                case "Reason":
                    FilterColumn = "Reason";
                    break;
                    
                case "Total Items Returned":
                    FilterColumn = "Total Items Returned";
                    break;

                case "Total Quantity":
                    FilterColumn = "Total Quantity";
                    break;

                case "Refund Amount":
                    FilterColumn = "Refund Amount";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilterValue.Text.Trim() == "" || cbFilterBy.Text == "None")
            {
                dtGetAllBookReturnData.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dtGetAllBookReturnData.Rows.Count.ToString();
            }

            if (FilterColumn == "Refund Amount" || FilterColumn == "Total Quantity" || FilterColumn == "Total Items Returned" || FilterColumn == "Original Sale ID" || FilterColumn == "Return ID")
            {
                if (!string.IsNullOrEmpty(txtFilterValue.Text))
                {
                    dtGetAllBookReturnData.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
                }
            }
            else
                dtGetAllBookReturnData.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dtGetAllBookReturnData.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Refund Amount" || cbFilterBy.Text == "Total Quantity" || cbFilterBy.Text == "Total Items Returned" || cbFilterBy.Text == "Original Sale ID" || cbFilterBy.Text == "Return ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
