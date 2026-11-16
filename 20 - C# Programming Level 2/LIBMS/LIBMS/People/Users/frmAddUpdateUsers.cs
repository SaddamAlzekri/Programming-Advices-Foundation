using LIBMS_Business;
using LIBMS.People.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBMS.People.Users
{
    public partial class frmAddUpdateUsers : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode Mode = enMode.AddNew;
        private int _UserID = -1;
        clsUser _User;
        public frmAddUpdateUsers()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public frmAddUpdateUsers(int _UserID)
        {
            InitializeComponent();
            Mode = enMode.Update;
            this._UserID = _UserID;
        }

        private int ReadPermission()
        {
            int Permission = 0;

            if (rdbManager.Checked)
            {
                Permission = -1;
            }
            else
            {
                if (chkRooms.Checked)
                {
                    Permission += 1;
                }
                if (chkUsers.Checked)
                {
                    Permission += 2;
                }
                if (chkCategoriesAndBooks.Checked)
                {
                    Permission += 4;
                }
                if (chkRoomResevation.Checked)
                {
                    Permission += 8;
                }
                if (chkPeople.Checked)
                {
                    Permission += 16;
                }
                if (chkMembers.Checked)
                {
                    Permission += 32;
                }
                if (chkSalesAndReturns.Checked)
                {
                    Permission += 64;
                }
                if (chkReadingSession.Checked)
                {
                    Permission += 128;
                }
                if (chkBorrowingRecords.Checked)
                {
                    Permission += 256;
                }
                if (chkLibraryAccessLog.Checked)
                {
                    Permission += 512;
                }
            }

            return Permission;
        }
        private void SetPermissions(int Permissions)
        {
            if (Permissions == -1)
            {
                rdbManager.Checked = true;
                // إذا كان المستخدم Manager، لا حاجة لتفعيل أي CheckBox آخر
                return;
            }

            if ((Permissions & 1) == 1)
            {
                chkRooms.Checked = true;
            }

            if ((Permissions & 2) == 2)
            {
                chkUsers.Checked = true;
            }

            if ((Permissions & 4) == 4)
            {
                chkCategoriesAndBooks.Checked = true;
            }

            if ((Permissions & 8) == 8)
            {
                chkRoomResevation.Checked = true;
            }

            if ((Permissions & 16) == 16)
            {
                chkPeople.Checked = true;
            }

            if ((Permissions & 32) == 32)
            {
                chkMembers.Checked = true;
            }

            if ((Permissions & 64) == 64)
            {
                chkSalesAndReturns.Checked = true;
            }

            if ((Permissions & 128) == 128)
            {
                chkReadingSession.Checked = true;
            }

            if ((Permissions & 256) == 256)
            {
                chkBorrowingRecords.Checked = true;
            }

            if ((Permissions & 512) == 512)
            {
                chkLibraryAccessLog.Checked = true;
            }
        }

        private void _ResetDefualtValues()
        {
            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUser();

                tpLoginInfoAndPermission.Enabled = false;

                ctrlPersonCardWithFilter1.FilterFocus();
            }
            else
            {
                lblTitle.Text = "Update User";
                this.Text = "Update User";

                tpLoginInfoAndPermission.Enabled = true;
                btnSave.Enabled = true;

            }

            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            chkIsActive.Checked = true;
            rdbManager.Checked = true;
            groupBox1.Visible = false;
        }
        private void LoadData()
        {
            _User = clsUser.FindByUserID(_UserID);

            if (_User == null)
            {
                this.Close();
                return;
            }

            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName.ToString();
            chkIsActive.Checked = _User.IsActive;
            SetPermissions(_User.Permission);
            ctrlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);

            if (_User.Permission != -1)
            {
                rdbUser.Checked = true;
                groupBox1.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

            _User.PersonID = ctrlPersonCardWithFilter1.PersonID;
            _User.UserName = txtUserName.Text.Trim();
            _User.Password = txtPassword.Text.Trim();
            _User.IsActive = chkIsActive.Checked;
            _User.Permission = ReadPermission();

            if (_User.Save())
            {
                lblUserID.Text = _User.UserID.ToString();
                //change form mode to update.
                Mode = enMode.Update;
                lblTitle.Text = "Update User";
                this.Text = "Update User";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnPersonInfoNext_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpLoginInfoAndPermission.Enabled = true;
                tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpLoginInfoAndPermission"];
                return;
            }

            //incase of add new mode.
            if (ctrlPersonCardWithFilter1.PersonID != -1)
            {

                if (clsUser.isUserExistForPersonID(ctrlPersonCardWithFilter1.PersonID))
                {

                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter1.FilterFocus();
                }
                else
                {
                    btnSave.Enabled = true;
                    tpLoginInfoAndPermission.Enabled = true;
                    tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpLoginInfoAndPermission"];
                }
            }

            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FilterFocus();

            }
        }

        private void frmAddUpdateUsers_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            };
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            };
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            };


            if (Mode == enMode.AddNew)
            {

                if (clsUser.isUserExist(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "username is used by another user");
                }
                else
                {
                    errorProvider1.SetError(txtUserName, null);
                };
            }
            else
            {
                //incase update make sure not to use anothers user name
                if (_User.UserName != txtUserName.Text.Trim())
                {
                    if (clsUser.isUserExist(txtUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUserName, null);
                    };
                }
            }
        }

        private void frmAddUpdateUsers_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if (Mode == enMode.Update)
                LoadData();
        }

        private void rdbUser_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = rdbUser.Checked;
        }

    }
}
