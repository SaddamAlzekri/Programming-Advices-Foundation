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

namespace LIBMS.Reading_Session
{
    public partial class frmShowBookInfo : Form
    {
        private int MemberID = 0;
        public frmShowBookInfo(int MemberID)
        {
            InitializeComponent();
            this.MemberID = MemberID;
        }
        DataTable _BookInfo;
        public frmShowBookInfo()
        {
            InitializeComponent();
        }

        private void frmShowBookInfo_Load(object sender, EventArgs e)
        {
            ctrlMemberInfo1.label7.Hide();
            ctrlMemberInfo1.txtFilterValue.Hide();

            ctrlMemberInfo1.LoadDataToForm(MemberID);

            _BookInfo =  clsReasonSession.GetBooksInfo(MemberID);

            dgvReadingSession.DataSource = _BookInfo;
            dgvReadingSession.AllowUserToAddRows = false;
            lblRecordsCount.Text = dgvReadingSession.Rows.Count.ToString();
            cbFilterBy.SelectedItem = "Book ID";
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
             
                case "Book ID":
                    FilterColumn = "BookID";
                    break;

                case "ISBN":
                    FilterColumn = "ISBN";
                    break;

                case "Title":
                    FilterColumn = "Title";
                    break;

                case "Publication Year":
                    FilterColumn = "PublicationYear";
                    break;

                case "Category Name":
                    FilterColumn = "CategoryName";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilterValue.Text.Trim() == "" || cbFilterBy.Text == "None")
            {
                _BookInfo.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvReadingSession.Rows.Count.ToString();
            }

            if (FilterColumn == "BookID" || FilterColumn == "PublicationYear")
            {
                if (!string.IsNullOrEmpty(txtFilterValue.Text))
                {
                    _BookInfo.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
                }
            }
            else
                _BookInfo.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvReadingSession.Rows.Count.ToString();
        }

        private void cbFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Book ID" || cbFilterBy.Text == "Publication Year")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ctrlMemberInfo1_Load(object sender, EventArgs e)
        {

        }

    }
}
