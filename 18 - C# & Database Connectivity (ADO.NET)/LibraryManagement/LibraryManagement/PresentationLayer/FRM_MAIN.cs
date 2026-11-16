using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.BusnissLayer;
using System.Windows.Forms;


namespace LibraryManagement.PresentationLayer
{
    public partial class FRM_MAIN : Form
    {
        public FRM_MAIN()
        {
            InitializeComponent();
        }
        void GetId()
        {
            PresentationLayer.FRM_DELETEMESSAGE frm = new FRM_DELETEMESSAGE();
            frm.ID = (int)dataGridView1.CurrentRow.Cells[1].Value;

        }

        string state = "";
        public void RefreshCateGory()
        {
            BusinessClass BusinessClass = new BusinessClass();

            dataGridView1.DataSource = BusinessClass.GetAllCategories();
            dataGridView1.Columns[0].HeaderText = "التسلسل";
            dataGridView1.Columns[1].HeaderText = "الأصناف";
        }
        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
            P_MAIN.Visible = true;
            P_HOME.Visible = false;
            lblTitle.Text = "الرئيسية";
        }

        private void BnfImgBtnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BnfImgBtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void BnfImgBtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if(P_MB.Size.Width == 205)
            {
                P_MB.Width = 50;
                button1.RightToLeft = RightToLeft.Yes;
                button2.RightToLeft = RightToLeft.Yes;
                button3.RightToLeft = RightToLeft.Yes;
                button4.RightToLeft = RightToLeft.Yes;
                button5.RightToLeft = RightToLeft.Yes;
                button6.RightToLeft = RightToLeft.Yes;
                button7.RightToLeft = RightToLeft.Yes;
            }else
            {
                P_MB.Width = 205;
                button1.RightToLeft = RightToLeft.No;
                button2.RightToLeft = RightToLeft.No;
                button3.RightToLeft = RightToLeft.No;
                button4.RightToLeft = RightToLeft.No;
                button5.RightToLeft = RightToLeft.No;
                button6.RightToLeft = RightToLeft.No;
                button7.RightToLeft = RightToLeft.No;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            P_MAIN.Visible = false;
            P_HOME.Visible = true;
            bunifuThinButton24.Visible = false;
            lblTitle.Text = "الاصناف";
            state = "Categories";
            RefreshCateGory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            P_MAIN.Visible = true;
            P_HOME.Visible = false;
            lblTitle.Text = "الرئيسية";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(state == "Categories")
            {
                PresentationLayer.FRM_ADDCAT FCAT = new FRM_ADDCAT();
                FCAT.ID = 0;
                bunifuTransition1.ShowSync(FCAT);
            }     
        }

        private void FRM_MAIN_Activated(object sender, EventArgs e)
        {
            RefreshCateGory();
        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (state == "Categories")
            {
                PresentationLayer.FRM_ADDCAT FCAT = new FRM_ADDCAT();
                FCAT.bunifuThinButton21.ButtonText = "تعديل";
                FCAT.bmtxtCategoryName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                FCAT.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                bunifuTransition1.ShowSync(FCAT);
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (state == "Categories")
            {
                PresentationLayer.FRM_DELETEMESSAGE FCAT = new FRM_DELETEMESSAGE();
                FCAT.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                bunifuTransition1.ShowSync(FCAT);
            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            if (state == "Categories")
            {
                BusinessClass BusinessClass = new BusinessClass();

                DataTable dt = new System.Data.DataTable();
                dt = BusinessClass.SearchCategories(bunifuMaterialTextbox1.Text);

                dataGridView1.DataSource = dt;
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
