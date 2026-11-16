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

namespace LIBMS.People.Members
{
    public partial class ctrlMemberShipID : UserControl
    {
        DataTable dtMemberCardInfo = new DataTable();
        public ctrlMemberShipID()
        {
            InitializeComponent();
        }

        private void _LoadPersonImage(int Gendor, string ImagePath)
        {
            if (Gendor == 0)
                pbImagePersonal.Image = Properties.Resources.icons8_person_100;
            else
                pbImagePersonal.Image = Properties.Resources.icons8_businesswoman_100;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbImagePersonal.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LoadDataToForm(DataTable dtMemberCardInfo)
        {
            DataRow row = dtMemberCardInfo.Rows[0];

            lblMemberShipID.Text = row["MemberShipID"].ToString();
            lblFullName.Text = row["FullName"].ToString();
            lblNationalNo.Text = row["NationalNo"].ToString();
            lblDateOfBirth.Text = row["DateOfBirth"].ToString();
            int Gendor = Convert.ToInt32(row["Gendor"]);
            //int int_Gendor = -1;
            if (Gendor == 1)
            {
                lblGendor.Text = "Male";
               // int_Gendor = 1;
            }
            else
            {
                lblGendor.Text = "Female";
                //int_Gendor = 0;
            }

            lblAddress.Text = row["Address"].ToString();
            lblPackageName.Text = row["PackageName"].ToString();
            lblStartDate.Text = row["StartDate"].ToString();
            lblEndDate.Text = row["EndDate"].ToString();
            lblStatus.Text = row["IsActive"].ToString();
            lblPhone.Text = "+967 " + row["Phone"].ToString();
            lblEmail.Text = row["Email"].ToString();

            _LoadPersonImage(Gendor, row["ImagePath"].ToString());
        }

        public void LoadDataFromDB(int MemberShipID)
        {
            dtMemberCardInfo = clsPackage.GetMemberCardInfoByMemberShipID(1);
            if(dtMemberCardInfo.Rows.Count > 0)
            {
                LoadDataToForm(dtMemberCardInfo);
            }
        }

    }
}
