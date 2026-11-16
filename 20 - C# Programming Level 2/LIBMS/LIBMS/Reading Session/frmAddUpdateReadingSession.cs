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
    public partial class frmAddUpdateReadingSession : Form
    {
        private int MemberID = -1;
        clsReasonSession _ReasonSesson;
        public frmAddUpdateReadingSession(int MemberID)
        {
            InitializeComponent();
            this.MemberID = MemberID;
        }

        public frmAddUpdateReadingSession()
        {
            InitializeComponent();
            _ReasonSesson = new clsReasonSession();
        }

        private void frmAddUpdateReadingSession_Load(object sender, EventArgs e)
        {
            DataTable dtBookInfo = clsBook.GetAllBooks();

            dgvReadingSession.DataSource = dtBookInfo;

            lblRecordsCount.Text = dgvReadingSession.Rows.Count.ToString();

        }

        private void dgvReadingSession_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvReadingSession.CurrentCell = null;
        }

        private void btnPersonInfoNext_Click(object sender, EventArgs e)
        {
            if(ctrlMemberInfo1.lblMemberID.Text != "#ID")
            {
                tcReadingSession.SelectedTab = tcReadingSession.TabPages["tabPage2"];
                dgvReadingSession.CurrentCell = null;
            }
            else
                MessageBox.Show("Sorry ,Search and Display MemberInfo!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvReadingSession.CurrentCell == null || ctrlMemberInfo1.lblStatus.Text == "Not Active" || ctrlMemberInfo1.lblStatus.Text == "????" )
            {
                if(ctrlMemberInfo1.lblStatus.Text == "Not Active")
                {
                    MessageBox.Show("The status is Not not Active.","Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //Here we dont continue becuase the form is not valid
                    MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            _ReasonSesson.MemberID = Convert.ToInt32(ctrlMemberInfo1.lblMemberID.Text);
            _ReasonSesson.BookID = (int)dgvReadingSession.CurrentRow.Cells[2].Value;
            _ReasonSesson.StartDate = DateTime.Now;
            _ReasonSesson.Status = "Active";

            if (_ReasonSesson.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    }
}
