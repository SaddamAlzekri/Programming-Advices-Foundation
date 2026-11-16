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

namespace LIBMS.Package
{
    public partial class frmUpdateMembershipPackage : Form
    {
        public enum enMode { AddNew = 0, Update = 1}
        public enMode Mode;
        private int PackageID = 0;
        clsPackage _Package;
        public frmUpdateMembershipPackage()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public frmUpdateMembershipPackage(int PackageID)
        {
            InitializeComponent();
            this.PackageID = PackageID;
            Mode = enMode.Update;
        }

        private void LoadData()
        {
            _Package = new clsPackage();

            _Package = clsPackage.GetPackageInfoByPackageID(PackageID);

            lblPackageID.Text = PackageID.ToString();
            txtPackageName.Text = _Package.PackageName;
            txtPackagePrice.Text = _Package.PackagePrice.ToString();
            txtDescription.Text = _Package.Description;
            txtDurationMonths.Text = _Package.DurationMonth.ToString();
        }

        private void frmUpdateMembershipPackage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Package.PackageName = txtPackageName.Text;
            _Package.PackagePrice = decimal.Parse(txtPackagePrice.Text);
            _Package.Description = txtDescription.Text;
            _Package.DurationMonth = int.Parse(txtDurationMonths.Text);

            if (_Package.UpdatePackageInfo(PackageID))
             {
                 MessageBox.Show("Data Updated Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }else
             {
                 MessageBox.Show("Error: Data Is not Updated Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }
    }
}
