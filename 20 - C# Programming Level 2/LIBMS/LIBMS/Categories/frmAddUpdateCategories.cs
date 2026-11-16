using System;
using LIBMS_Business;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBMS.Categories
{
    public partial class frmAddUpdateCategories : Form
    {
        public enum enMode { AddNew = 0, Update = 1}
        private enMode Mode = enMode.AddNew;
        clsCategories _clsCategory;

        int CategoryID = -1;

        public frmAddUpdateCategories()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
            _clsCategory = new clsCategories();
            this.Text = "Add Category";
            lblTitle.Text = "Add Category"; 
        }

        public frmAddUpdateCategories(int CategoryID)
        {
            InitializeComponent();
            Mode = enMode.Update;
            this.CategoryID = CategoryID;
            this.Text = "Update Category";
            lblTitle.Text = "Update Category"; 
        }

        private void _LoadDataFromDB()
        {
            _clsCategory = clsCategories.GetCategoryInfoByCategoryID(CategoryID);

            lblCategoryID.Text = _clsCategory.CategoryID.ToString();
            txtCategoryName.Text = _clsCategory.CategoryName;
            txtDescription.Text = _clsCategory.Description;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUpdateCategories_Load(object sender, EventArgs e)
        {

            if (Mode == enMode.Update)
                _LoadDataFromDB();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _clsCategory.CategoryName = txtCategoryName.Text;
            _clsCategory.Description = txtDescription.Text;

            if (_clsCategory.Save())
            {
                lblCategoryID.Text = _clsCategory.CategoryID.ToString();
                //change form mode to update.
                Mode = enMode.Update;
                lblTitle.Text = "Update Person";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    }
}
