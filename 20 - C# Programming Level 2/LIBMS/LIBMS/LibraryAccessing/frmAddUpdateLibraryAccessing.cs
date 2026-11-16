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

namespace LIBMS.LibraryAccessing
{
    public partial class frmAddUpdateLibraryAccessing : Form
    {
        clsLibraryAccessing _clsLibraryAccessing = new clsLibraryAccessing();
        public enum enMode { AddNew = 0, ShowData = 1}
        public enMode Mode = enMode.AddNew;
        public int LogID { get; set; }
        public int PersonID { get; set; }


        public frmAddUpdateLibraryAccessing(enMode frmMode)
        {
            InitializeComponent();
            Mode = frmMode;
        }

        public frmAddUpdateLibraryAccessing(enMode frmMode,int LogID ,int PersonID)
        {
            InitializeComponent();
            Mode = frmMode;
            this.LogID = LogID;
            this.PersonID = PersonID;
        }

        private void GetDataFromDB()
        {
            _clsLibraryAccessing = _clsLibraryAccessing.GetLibraryAccesslogByLogID(1022);
            lblLogID.Text = LogID.ToString();
            txtReason.Text = _clsLibraryAccessing._Reason;

            dtAccessTime.Value = _clsLibraryAccessing._AccessTime;
            dtOutTime.Value = _clsLibraryAccessing._OutTime?? DateTime.Now;
        }

        private void frmAddUpdateLibraryAccessing_Load(object sender, EventArgs e)
        {
            if(Mode == enMode.AddNew)
            {
                dtAccessTime.Enabled = false;
                dtOutTime.Visible = false;
                lblOutTime.Visible = false;
            }
            else
            {
                dtOutTime.Visible = true;
                dtOutTime.Enabled = false;
                dtAccessTime.Enabled = false;
                txtReason.Enabled = false;
                ctrlPersonCardWithFilter1.txtFilterValue.Enabled = false;
                ctrlPersonCardWithFilter1.ctrlPersonCard1.LoadPersonInfo(PersonID);
                GetDataFromDB();
            }
        }

        private void AddNew()
        {
            int intParse = 0;
            try
            {
                if (int.TryParse(ctrlPersonCardWithFilter1.ctrlPersonCard1.lblPersonID.Text, out intParse))
                {
                    _clsLibraryAccessing._PersonID = intParse;
                }
                _clsLibraryAccessing._AccessTime = dtAccessTime.Value;
                _clsLibraryAccessing._Reason = txtReason.Text;

                if (_clsLibraryAccessing.AddLibraryAccessing())
                {
                    MessageBox.Show("Done Successfully");
                    lblLogID.Text = _clsLibraryAccessing._LogID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Mode == enMode.AddNew)
            {
                AddNew();
            }
        }

        private void ctrlPersonCardWithFilter1_Load(object sender, EventArgs e)
        {

        }

    }
}
