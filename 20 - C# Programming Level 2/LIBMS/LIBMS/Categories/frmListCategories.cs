using System;
using LIBMS.Categories;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIBMS_Business;

namespace LIBMS.Categories
{
    public partial class frmListCategories : Form
    {

        public frmListCategories()
        {
            InitializeComponent();
        }

        private void frmListCategories_Load(object sender, EventArgs e)
        {
            DataTable dtCategories = clsCategories.GetAllCatgories();
            dgvCategories.DataSource = dtCategories;

            lblRecordsCount.Text = dtCategories.Rows.Count.ToString();
            dgvCategories.AllowUserToAddRows = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            frmAddUpdateCategories frm = new frmAddUpdateCategories();
            frm.ShowDialog();
            frmListCategories_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateCategories frm = new frmAddUpdateCategories((int)dgvCategories.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListCategories_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + dgvCategories.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                //Perform Delele and refresh
                if (clsCategories.DeleteCategory((int)dgvCategories.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListCategories_Load(null, null);

                }

                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddUpdateCategories frm = new frmAddUpdateCategories();
            frm.ShowDialog();
            frmListCategories_Load(null, null);

        }

        private void dgvCategories_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == DBNull.Value && e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                e.Value = "NULL";
                dgvCategories.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(235, 182, 193);
            }
        }
    }
}
