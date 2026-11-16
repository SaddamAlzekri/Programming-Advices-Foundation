using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIBMS_Business;
using System.IO;

namespace LIBMS.Reading_Session
{
    public partial class ctrlMemberInfo : UserControl
    {
        private int MemberID = -1;
        public ctrlMemberInfo(int MemberID)
        {
            InitializeComponent();
            this.MemberID = MemberID;
        }

        public ctrlMemberInfo()
        {
            InitializeComponent();
        }

        private void _LoadPersonImage(string imagePath)
        {
            if (imagePath != "")
                if (File.Exists(imagePath))
                    pbImagePersonal.ImageLocation = imagePath;
                else
                    MessageBox.Show("Could not find this image: = " + imagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void LoadDataToForm(int MemberID)
        {
            DataTable dtMemberInfo = clsReasonSession.GetMemberInfo(MemberID);

            if (dtMemberInfo.Rows.Count > 0)
            {
                DataRow row = dtMemberInfo.Rows[0];

                lblMemberID.Text = MemberID.ToString();
                lblPackageID.Text = row["PackageID"].ToString();
                lblStartDate.Text = row["StartDate"].ToString();
                lblEndDate.Text = row["EndDate"].ToString();

                if (row["IsActive"].ToString() == "True")
                    lblStatus.Text = "Active";
                else
                    lblStatus.Text = "Not Active";

                lblFullName.Text = row["FullName"].ToString();

                string imagePath = row["ImagePath"].ToString();

                _LoadPersonImage(imagePath);
            }else
            {
                MessageBox.Show("Sorry ,Enter a valid MemberShipID Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFilterValue_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoadDataToForm(Convert.ToInt32(txtFilterValue.Text));
            }
        }
    }
}
