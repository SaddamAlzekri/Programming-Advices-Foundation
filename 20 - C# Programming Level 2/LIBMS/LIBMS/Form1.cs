using System;
using LIBMS.Books;
using LIBMS.People.Members;
using LIBMS.Package;
using LIBMS.People.Users;
using LIBMS.Gloal_Classes;
using LIBMS.People;
using LIBMS.People.Users.Controls;
using Functionality;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIBMS.Login;
using System.IO;
using LIBMS.Categories;
using LIBMS.Reading_Session;
using LIBMS.Sale;
using LIBMS.Returns;
using LIBMS.ReservationOfRooms;
using LIBMS.RoomsReservation;
using LIBMS.LibraryAccessing;

namespace LIBMS
{
    public partial class Form1 : Form
    {
        frmLogin _frmLogin;
        public Form1(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void SetPermissionEnablesISTrue()
        {
            roomsToolStripMenuItem.Enabled = true;
            usersToolStripMenuItem.Enabled = true;
            operationsToolStripMenuItem.Enabled = true;
            roomReservationToolStripMenuItem.Enabled = true;
            peopleToolStripMenuItem.Enabled = true;
            membersToolStripMenuItem.Enabled = true;
            salesAndReturnsToolStripMenuItem.Enabled = true;
            readingSessionToolStripMenuItem.Enabled = true;
            borrowingRecordsToolStripMenuItem.Enabled = true;
            libraryAccessLogToolStripMenuItem.Enabled = true;
        }

        private void SetPermissionEnablesISFalse()
        {
            roomsToolStripMenuItem.Enabled = false;
            usersToolStripMenuItem.Enabled = false;
            operationsToolStripMenuItem.Enabled = false;
            roomReservationToolStripMenuItem.Enabled = false;
            peopleToolStripMenuItem.Enabled = false;
            membersToolStripMenuItem.Enabled = false;
            salesAndReturnsToolStripMenuItem.Enabled = false;
            readingSessionToolStripMenuItem.Enabled = false;
            borrowingRecordsToolStripMenuItem.Enabled = false;
            libraryAccessLogToolStripMenuItem.Enabled = false;
        }

        private void SetPermission()
        {
            int Permission = 0;
            Permission = clsGlobal.CurrentUser.Permission;
            if (Permission == -1)
            {
                SetPermissionEnablesISTrue();
            }
            else
            {
                if ((Permission & 1) == 1)
                {
                    roomsToolStripMenuItem.Enabled = true;
                }

                if ((Permission & 2) == 2)
                {
                    usersToolStripMenuItem.Enabled = true;
                }

                if ((Permission & 4) == 4)
                {
                    operationsToolStripMenuItem.Enabled = true;
                }

                if ((Permission & 8) == 8)
                {
                    roomReservationToolStripMenuItem.Enabled = true;
                }

                if ((Permission & 16) == 16)
                {
                    peopleToolStripMenuItem.Enabled = true;
                }

                if ((Permission & 32) == 32)
                {
                    membersToolStripMenuItem.Enabled = true;
                }

                if ((Permission & 64) == 64)
                {
                    salesAndReturnsToolStripMenuItem.Enabled = true;
                }

                if ((Permission & 128) == 128)
                {
                    readingSessionToolStripMenuItem.Enabled = true;
                }

                if ((Permission & 256) == 256)
                {
                    borrowingRecordsToolStripMenuItem.Enabled = true;
                }

                if ((Permission & 512) == 512)
                {
                    libraryAccessLogToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            Functionality.Functionality.Maximize(this);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            Functionality.Functionality.Minimize(this);
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListUsers frm = new frmListUsers();
            frm.ShowDialog();
        }

        private void btnLeftList_Click(object sender, EventArgs e)
        {
            Gloal_Classes.clsGlobal.ControlOfpnlLetfList(pnlLetfList, btnClose, lblTime, lblUserName, pbImagePersonal, lblPersonalImage, label2, label4);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Gloal_Classes.clsGlobal.NowTime(lblTime);

        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPeople frm = new frmListPeople();
            frm.ShowDialog();
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void sighnOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void LoadRightTab()
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
             
        private void Form1_Load(object sender, EventArgs e)
        {
            SetPermissionEnablesISFalse();
            SetPermission();
            LoadRightTab();
        }

        private void membershipPackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListMembershipPackage frm = new frmListMembershipPackage();
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmChanngePassword Frm1 = new frmChanngePassword(clsGlobal.CurrentUser.UserID);
            Frm1.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo Frm1 = new frmUserInfo(clsGlobal.CurrentUser.UserID);
            Frm1.ShowDialog();
        }

        private void membersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListMembers frm = new frmListMembers();
            frm.ShowDialog();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListCategories frm = new frmListCategories();
            frm.ShowDialog();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBooks frm = new frmListBooks();
            frm.ShowDialog();
        }

        private void readingSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListReadingSession frm = new frmListReadingSession();
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookSaleList frm = new frmBookSaleList();
            frm.ShowDialog();
        }

        private void returnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookReturnList frm = new frmBookReturnList();
            frm.ShowDialog();
        }

        private void libraryAccessLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLibraryAccessingList frm = new frmLibraryAccessingList();
            frm.ShowDialog();
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoomList frm = new frmRoomList();
            frm.ShowDialog();
        }

        private void roomReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservationRoomList frm = new frmReservationRoomList();
            frm.ShowDialog();
        }
    }
}
