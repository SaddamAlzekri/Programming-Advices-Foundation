using System;
using LIBMS_Business;
using LIBMS.Books;
using LIBMS.Gloal_Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBMS.Books
{
    public partial class frmListBooks : Form
    {
        public frmListBooks()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            frmAddUpdateBook frm = new frmAddUpdateBook();
            frm.ShowDialog();
            LoaddgvDataFromDB();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateBook frm = new frmAddUpdateBook((int)dgvBooks.CurrentRow.Cells[2].Value, (int)dgvBooks.CurrentRow.Cells[1].Value, (int)dgvBooks.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            LoaddgvDataFromDB();
        }

        private void showBookInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowBookInfo frm = new frmShowBookInfo((int)dgvBooks.CurrentRow.Cells[2].Value, (int)dgvBooks.CurrentRow.Cells[1].Value, (int)dgvBooks.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            LoaddgvDataFromDB();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + dgvBooks.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                //Perform Delele and refresh
                if (clsBook.DeleteBook((int)dgvBooks.CurrentRow.Cells[2].Value, (int)dgvBooks.CurrentRow.Cells[1].Value, (int)dgvBooks.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoaddgvDataFromDB();
                }

                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoaddgvDataFromDB()
        {
            DataTable dtBook = clsBook.GetAllBooks();
            dgvBooks.DataSource = dtBook;

            lblRecordsCount.Text = dtBook.Rows.Count.ToString();
            dgvBooks.AllowUserToAddRows = false;
        }

        private void frmListBooks_Load(object sender, EventArgs e)
        {
            LoaddgvDataFromDB();
        }

        private void dgvBooks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == DBNull.Value && e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                e.Value = "NULL";
                dgvBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(235, 182, 193);
            }
        }
    }
}
