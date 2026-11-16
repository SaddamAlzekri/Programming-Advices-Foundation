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
using LIBMS.Gloal_Classes;

namespace LIBMS.Books.Book_Items
{
    public partial class frmAddUpdateCopies : Form
    {
        clsBookItems _BookItem = new clsBookItems();

        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        public int BookID = 0;
        clsBook _clsBook = new clsBook();

        public frmAddUpdateCopies(int BookID)
        {
            InitializeComponent();
            this.BookID = BookID;
        }

        private void RefreshData()
        {
            cbCopyStatus.SelectedIndex = 0;
            dgvBookItem.DataSource = clsBookItems.GETBookItemsByBookID(BookID);
            lblRecordsCount.Text = dgvBookItem.Rows.Count.ToString();
        }
        private void frmAddUpdateCopies_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void GetBookItemInfo()
        {
            int ItemID = (int)dgvBookItem.CurrentRow.Cells[0].Value;
            _BookItem = clsBookItems.GetBookItems(ItemID);
            lblItemID.Text = _BookItem.ItemID.ToString();
            txtNumberOfCopies.Enabled = false;
            cbCopyStatus.Text = _BookItem.CopyStatus;
            txtLocationRack.Text = _BookItem.LocationRack;
            txtPrice.Text = _BookItem.Price.ToString();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mode = enMode.Update;
            GetBookItemInfo();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _BookItem.Mode = clsBookItems.enMode.AddNew;
            txtNumberOfCopies.Enabled = true;
            lblItemID.Text = "#ID";
            txtNumberOfCopies.Text = "";
            txtLocationRack.Text = "";
            txtPrice.Text = "";
            cbCopyStatus.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (Mode != enMode.Update)
            {
                _BookItem.BookID = BookID;
                _BookItem.NumberOfCopies = int.Parse(txtNumberOfCopies.Text);
            }else
            {
                _BookItem.ItemID = int.Parse(lblItemID.Text);
            }

            _BookItem.LocationRack = txtLocationRack.Text;
            _BookItem.CopyStatus = cbCopyStatus.Text;
            _BookItem.Price = decimal.Parse(txtPrice.Text);

            if (_BookItem.Save())
            {
                lblItemID.Text = _BookItem.ItemID.ToString();
                if(Mode == enMode.Update)
                {
                    this.Text = "Update BookItem";
                }
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshData();
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtNumberOfCopies_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}


