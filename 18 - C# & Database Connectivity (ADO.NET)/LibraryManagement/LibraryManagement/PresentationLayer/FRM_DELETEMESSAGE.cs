using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.BusnissLayer;

namespace LibraryManagement.PresentationLayer
{
    public partial class FRM_DELETEMESSAGE : Form
    {
        public FRM_DELETEMESSAGE()
        {
            InitializeComponent();
        }
        public int ID;
        private void BnfImgBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            BusinessClass BusinessClass = new BusinessClass();
            BusinessClass.DeleteContact(ID);

            //FRM_DDELETE FCAT = new FRM_DDELETE();
            //FCAT.ShowDialog();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
