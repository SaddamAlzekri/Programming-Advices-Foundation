using System;
using System.IO;
using DVLD.Login;
using DVLD.User;
using DVLD.Drivers;
using DVLD.Test;
using DVLD.License.Detain_License;
using DVLD.Applications.Renew_Local_License;
using DVLD.Applications.Rlease_Detained_License;
using DVLD.Applications.Application_Type;
using DVLD.Applications.Local_Driving_License;
using DVLD.GlobalClasses;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business;
using DVLD.Applications.ReplaceLostOrDamagedLicense;
using DVLD.Applications.International_License;

    namespace DVLD
{
    public partial class frmMain : Form
    {
        frmLogin _frmLogin;
        public frmMain(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLeftList_Click(object sender, EventArgs e)
        {
            GlobalClasses.ClassOfMainForm.ControlOfpnlLetfList(pnlLetfList, btnClose, lblTime, lblUserName, pbImagePersonal, lblPersonalImage, label2, label4);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            GlobalClasses.ClassOfMainForm.Maximize(this);

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            GlobalClasses.ClassOfMainForm.Minimize(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GlobalClasses.ClassOfMainForm.NowTime(lblTime);
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            People.frmListPeople frm = new People.frmListPeople();
            frm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.frmListUsers frm = new User.frmListUsers();
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChanngePassword frm = new frmChanngePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            clsGlobal.ApplyRoundCorner(pbImagePersonal, 80);


            if (clsGlobal.CurrentUser.PersonInfo != null)
            {
                if (clsGlobal.CurrentUser.PersonInfo.ImagePath != "")
                {
                    if (File.Exists(clsGlobal.CurrentUser.PersonInfo.ImagePath))
                    {
                        pbImagePersonal.ImageLocation = clsGlobal.CurrentUser.PersonInfo.ImagePath;
                    }
                }
            }

            lblUserName.Text = clsGlobal.CurrentUser.UserName;
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListApplicatinType frm = new frmListApplicatinType();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListTestTypes frm = new frmListTestTypes();
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenseApplication frm = new frmAddUpdateLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListLocalDrivingLicesnseApplications frm = new frmListLocalDrivingLicesnseApplications();
            frm.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewLocalDrivingLicenseApplication frm = new frmRenewLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void replacementForLostOrDamageLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplaceLostOrDamagedLicenseApplication frm = new frmReplaceLostOrDamagedLicenseApplication();
            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDetainLicenseApplication frm = new frmDetainLicenseApplication();
            frm.ShowDialog();
        }

        private void manageDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDetainedLicenses frm = new frmListDetainedLicenses();
            frm.ShowDialog();
        }

        private void releaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicenseApplication frm = new frmReleaseDetainedLicenseApplication();
            frm.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListLocalDrivingLicesnseApplications frm = new frmListLocalDrivingLicesnseApplications();
            frm.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicenseApplication frm = new frmNewInternationalLicenseApplication();
            frm.ShowDialog();
        }

        private void internationalDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListInternationalLicesnseApplications frm = new frmListInternationalLicesnseApplications();
            frm.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDrivers frm = new frmListDrivers();
            frm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void currrentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

    }
}
