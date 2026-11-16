using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsBusinessLayer;

namespace ContactsPresentationLayer
{
    public partial class frmAddEditContact : Form
    {
        public frmAddEditContact()
        {
            InitializeComponent();
        }

        private void _RefreshData()
        {
            dgvAllContacts.DataSource = clsContact.GetAllContacts();
        }
        
        private void frmAddEditContact_Load(object sender, EventArgs e)
        {
            _RefreshData();
        }

        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            frmListContacts frm = new frmListContacts(-1);
            frm.ShowDialog();
            _RefreshData();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListContacts frm = new frmListContacts((int)dgvAllContacts.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want delete " + dgvAllContacts.CurrentRow.Cells[0].Value, "Delete row", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsContact.DeleteContact((int)dgvAllContacts.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Delete seccessfully", "Delete", MessageBoxButtons.OK);
                }
            }
            _RefreshData();
        }
    }
}
