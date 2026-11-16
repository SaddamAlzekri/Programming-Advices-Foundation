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
using LIBMS_Business;
using System.IO;
using LIBMS.Properties;

namespace LIBMS.Books
{
    public partial class frmAddUpdateBook : Form
    {
        public enum enMode { AddNew = 0, Update = 1}
        private enMode Mode = enMode.AddNew;
        clsBook _clsBook;

        int BookID = -1;
        int AutherID = -1;
        int BookAuthorID = -1;

        public frmAddUpdateBook(int BookID, int AutherID,int BookAuthorID)
        {
            InitializeComponent();
            Mode = enMode.Update;
            this.BookID = BookID;
            this.AutherID = AutherID;
            this.BookAuthorID = BookAuthorID;
        }

        public frmAddUpdateBook()
        {
            InitializeComponent();
            _clsBook = new clsBook();
            Mode = enMode.AddNew;
        }

        private bool _HandlePersonImage()
        {

            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.


            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (_clsBook.CoverPath != pbCoverOfBook.ImageLocation)
            {
                if (_clsBook.CoverPath != "")
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(_clsBook.CoverPath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if (pbCoverOfBook.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = pbCoverOfBook.ImageLocation.ToString();

                    if (clsUtil.CopyImageToCoverOfBooksFolder(ref SourceImageFile))
                    {
                        pbCoverOfBook.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }

        private void llSetImgee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbCoverOfBook.Load(selectedFilePath);
                llRemoveImage.Visible = true;
                // ...
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbCoverOfBook.ImageLocation = null;

            pbCoverOfBook.Image = Resources.book__1_;

            llRemoveImage.Visible = false;
        }
        
        private void LoadCategoryName()
        {
            DataTable dtCategoryName = clsBook.GetAllCategoryName();

            cbCategoryName.DataSource = dtCategoryName;
            cbCategoryName.DisplayMember = "CategoryName";
            cbCategoryName.ValueMember = "CategoryID";
        }

        private void _Load()
        {
            _clsBook = clsBook.GetBookInfoByBookID(BookAuthorID);

            lblBookID.Text = BookID.ToString();
            txtISBN.Text = _clsBook.ISBN;
            txtAvailableName.Text = _clsBook.AvailableCopies.ToString();
            txtPublicationYear.Text = _clsBook.PublicationYear.ToString();
            txtTitle.Text = _clsBook.Title.ToString();
            cbCategoryName.SelectedItem = _clsBook.CategoryName;
            _clsBook.AuthorID = AutherID;
            
            ctrlPersonCardWithFilter1.ctrlPersonCard1.LoadPersonInfo(_clsBook.PersonID);
            ctrlPersonCardWithFilter1.txtFilterValue.Text = _clsBook.PersonID.ToString();

            if (_clsBook.CoverPath != "")
            {
                pbCoverOfBook.ImageLocation = _clsBook.CoverPath;
            }

        }

        private void frmAddUpdateBook_Load(object sender, EventArgs e)
        {
            LoadCategoryName();
            if (Mode == enMode.Update)
                _Load();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (!_HandlePersonImage())
                return;

            _clsBook.ISBN = txtISBN.Text;
            _clsBook.Title = txtTitle.Text;
            _clsBook.PublicationYear = Convert.ToInt32(txtPublicationYear.Text);
            _clsBook.AvailableCopies = Convert.ToInt32(txtAvailableName.Text);
            _clsBook.CategoryID = Convert.ToInt32(cbCategoryName.SelectedValue);
            
            if (pbCoverOfBook.ImageLocation != null)
                _clsBook.CoverPath = pbCoverOfBook.ImageLocation;
            else
                _clsBook.CoverPath = "";

            if (Mode == enMode.Update)
            {
                _clsBook.BookID = BookID;
                _clsBook.PersonID = Convert.ToInt32(ctrlPersonCardWithFilter1.ctrlPersonCard1.lblPersonID.Text);
                _clsBook.AuthorID = AutherID;
            }else
                _clsBook.PersonID = Convert.ToInt32(ctrlPersonCardWithFilter1.ctrlPersonCard1.lblPersonID.Text);

            if (_clsBook.Save())
            {
                lblBookID.Text = _clsBook.BookID.ToString();
                Mode = enMode.Update;
                lblTitle.Text = "Update Person";

                // Enter the AddNewBookItem

                //BookID = _clsBook.BookID;
                //_clsBook.BookID = BookID;
                BookID = _clsBook.Save() == true ? _clsBook.BookID : BookID;



                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtNumberOfCopies_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAvailableName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPublicationYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
