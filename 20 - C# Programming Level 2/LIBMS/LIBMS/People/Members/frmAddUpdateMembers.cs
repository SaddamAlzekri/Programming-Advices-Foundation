using System;
using LIBMS_Business;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBMS.People.Members
{
    public partial class frmAddUpdateMembers : Form
    {
        public enum enMode { Update = 0, AddNew = 1}
        private enMode Mode = enMode.AddNew;
        private int MemberShipID = -1;
        clsMembers _clsMember;

        public frmAddUpdateMembers()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public frmAddUpdateMembers(int MemberShipID)
        {
            InitializeComponent();
            this.MemberShipID = MemberShipID;
            Mode = enMode.Update;
        }

        private void _ResetDefualtValues()
        {
            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Member";
                this.Text = "Add New Member";
                _clsMember = new clsMembers();

                ctrlPersonCardWithFilter1.FilterFocus();
                tcMemberInfo.Enabled = false;
            }
            else
            {
                lblTitle.Text = "Update Member";
                this.Text = "Update Member";
                tcMemberInfo.Enabled = true;
            }

            rdbBasic.Checked = true;
            chkIsActive.Checked = true;
            dtpEndDate.Value = DateTime.Now.AddMonths(3);

            dtpEndDate.Enabled = false;
            dtpStartDate.Enabled = false;

            ctrlPersonCardWithFilter1.txtFilterValue.Focus();
        }

        private void LoadData()
        {
            _clsMember = clsMembers.GetMemberInfoByMemberShipID(MemberShipID);
            ctrlPersonCardWithFilter1.LoadPersonInfo(_clsMember.PersonID);

            if (_clsMember.PackageID == 1)
            {
                rdbBasic.Checked = true;
            }
                

            if (_clsMember.PackageID == 2)
            {
                rdbPremium.Checked = true;
            }
                

            if (_clsMember.PackageID == 3)
            {
                rdbGold.Checked = true;
            }

            dtpStartDate.Value = _clsMember.StartDate;
            dtpEndDate.Value = _clsMember.EndDate;
            chkIsActive.Checked = _clsMember.IsActive;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUpdateMembers_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if (Mode == enMode.Update)
                LoadData();
        }

        private void btnPersonInfoNext_Click(object sender, EventArgs e)
        {
            if(Mode == enMode.Update)
            {
                tcMemberlog.SelectedTab = tcMemberlog.TabPages["tcMemberInfo"];
                return;
            }

            if(ctrlPersonCardWithFilter1.PersonID != -1)
            {
                if (clsMembers.isPersonIDExist(ctrlPersonCardWithFilter1.PersonID))
                {
                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter1.FilterFocus();
                }else
                {
                    tcMemberInfo.Enabled = true;
                    tcMemberlog.SelectedTab = tcMemberlog.TabPages["tcMemberInfo"];
                }
            }else
            {
                MessageBox.Show("Select any person do not choose before", "Select Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void rdbBasic_CheckedChanged(object sender, EventArgs e)
        {
            dtpEndDate.Value = DateTime.Now.AddMonths(3);
        }

        private void rdbPremium_CheckedChanged(object sender, EventArgs e)
        {
            dtpEndDate.Value = DateTime.Now.AddMonths(6);
        }

        private void rdbGold_CheckedChanged(object sender, EventArgs e)
        {
            dtpEndDate.Value = DateTime.Now.AddYears(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tcMemberlog.SelectedTab = tcMemberlog.TabPages["tpPersonInfo"];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            _clsMember.PersonID = Convert.ToInt32(ctrlPersonCardWithFilter1.ctrlPersonCard1.lblPersonID.Text.ToString());

            if (rdbBasic.Checked)
                _clsMember.PackageID = 1;

            if (rdbPremium.Checked)
                _clsMember.PackageID = 2;

            if (rdbGold.Checked)
                _clsMember.PackageID = 3;

            _clsMember.StartDate = dtpStartDate.Value;
            _clsMember.EndDate = dtpEndDate.Value;

            if (chkIsActive.Checked)
                _clsMember.IsActive = true;

            if (_clsMember.Save())
            {
                Mode = enMode.Update;
                lblTitle.Text = "Update User";
                this.Text = "Update User";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    }
}
