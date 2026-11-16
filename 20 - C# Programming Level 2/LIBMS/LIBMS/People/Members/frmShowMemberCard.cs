using System;
using LIBMS.Gloal_Classes;
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
    public partial class frmShowMemberCard : Form
    {
        private int MemberShipID = 0;
        public frmShowMemberCard(int MemberShipID)
        {
            InitializeComponent();
            this.MemberShipID = MemberShipID;
        }

        public frmShowMemberCard()
        {
            InitializeComponent();
        }

        private void frmShowMemberCard_Load(object sender, EventArgs e)
        {
            Gloal_Classes.clsGlobal.ApplyRoundCorner(this, 30);
            ctrlMemberShipID1.LoadDataFromDB(MemberShipID);
            clsGlobal.ApplyRoundCorner(ctrlMemberShipID1.pbImagePersonal, 80);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("في التحديث القادم سيتم العمل على هذه الخاصية");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            btnClose.Hide();
            Bitmap img = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(img, new Rectangle(Point.Empty, this.Size));
            e.Graphics.DrawImage(img, 0, 0);
        }

        private void btnCloseBar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
