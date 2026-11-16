using LIBMS_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBMS.Reading_Session
{
    public partial class frmCancelOfReadingSession : Form
    {
        private int MemberID = -1;
        private int SessionID = -1;
        clsReasonSession _ReasonSession = new clsReasonSession();
        public frmCancelOfReadingSession(int MemberID, int SessionID)
        {
            InitializeComponent();
            this.MemberID = MemberID;
            this.SessionID = SessionID;
        }

        private void frmCancelOfReadingSession_Load(object sender, EventArgs e)
        {
            ctrlMemberInfo1.label7.Hide();
            ctrlMemberInfo1.txtFilterValue.Hide();
            ctrlMemberInfo1.LoadDataToForm(MemberID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _ReasonSession.Mode = clsReasonSession.enMode.Update;

            _ReasonSession.SessionID = SessionID;
            _ReasonSession.EndDate = DateTime.Now;
            _ReasonSession.Status = "Concelled";
            _ReasonSession.ReasonOfCancel = txtReasonOfCancel.Text;

            if (MessageBox.Show("Are you sure you want to Concelled Reading Session [" + SessionID + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK && ctrlMemberInfo1.lblStatus.Text != "Completed")
            {
                if (_ReasonSession.Save())
                {
                    MessageBox.Show("Reading Session Concelled Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Reading Session was not Concelled because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
