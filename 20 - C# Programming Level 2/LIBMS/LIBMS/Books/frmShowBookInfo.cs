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

namespace LIBMS.Books
{
    public partial class frmShowBookInfo : Form
    {
        private int BookID = -1;
        private int AuthorID = -1;
        private int BookAuthorID = -1;

        clsBook _clsBook;
        public frmShowBookInfo(int BookID, int AuthorID, int BookAuthorID)
        {
            InitializeComponent();
            this.BookID = BookID;
            this.AuthorID = AuthorID;
            this.BookAuthorID = BookAuthorID;
        }

        public frmShowBookInfo()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            _clsBook = clsBook.GetBookInfoByBookID(BookAuthorID);

            lblBookID.Text = BookID.ToString();
            lblISBN.Text = _clsBook.ISBN;
            lblTitle.Text = _clsBook.Title;
            lblCategoryName.Text = _clsBook.CategoryName;
            lblDescription.Text = _clsBook.Description;
            lblAvailableCopy.Text = _clsBook.AvailableCopies.ToString();
            lblPublicationYear.Text = _clsBook.PublicationYear.ToString();
            lblAuthorName.Text = _clsBook.AuthorName;

            if(_clsBook.CoverPath != "")
                pbImagePersonal.ImageLocation = _clsBook.CoverPath;
        }

        private void frmShowBookInfo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void llEditBookInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdateBook frm = new frmAddUpdateBook(BookID, AuthorID, BookAuthorID);
            frm.ShowDialog();
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
