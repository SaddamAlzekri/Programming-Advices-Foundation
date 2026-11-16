using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsBusinessLayer;

namespace ContactsPresentationLayer
{
    public partial class frmListContacts : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode;

        int _Contacts;
        clsContact Contacts;
        public frmListContacts(int Contacts)
        {
            InitializeComponent();
            _Contacts = Contacts;

            if (Contacts == -1)
                Mode = enMode.AddNew;
            else
                Mode = enMode.Update;
        }

        private void FillComboBox()
        {
            DataTable DataTable = clsCountry.GetAllCountries();

            foreach(DataRow row in DataTable.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }

            cbCountry.SelectedIndex = 0;
        }

        private void frmListContacts_Load(object sender, EventArgs e)
        {
            FillComboBox();

            if(Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Contact";
                Contacts = new clsContact();
                return;
            }

            Contacts = clsContact.Find(_Contacts);

            if(Contacts == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _Contacts);
                this.Close();

                return;
            }

            lblMode.Text = "Edit Contact ID = " + _Contacts;
            lblContactID.Text = _Contacts.ToString();
            txtFirstName.Text = Contacts.FirstName;
            txtLastName.Text = Contacts.LastName;
            txtEmail.Text = Contacts.Email;
            txtPhone.Text = Contacts.Phone;
            txtAddress.Text = Contacts.Address;
            dtpDateOfBirth.Value = Contacts.DateOfBirth;


            if(Contacts.ImagePath != "")
            {
                pictureBox1.Load(Contacts.ImagePath);
            }

            llRemoveImage.Visible = (Contacts.ImagePath != "");

            cbCountry.SelectedIndex = cbCountry.FindString(clsCountry.Find(Contacts.CountryID).CountryName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int CountryID = clsCountry.Find(cbCountry.Text).ID;

            Contacts.FirstName = txtFirstName.Text;
            Contacts.LastName = txtLastName.Text;
            Contacts.Email = txtEmail.Text;
            Contacts.Phone = txtPhone.Text;
            Contacts.Address = txtAddress.Text;
            Contacts.DateOfBirth = dtpDateOfBirth.Value;
            Contacts.CountryID = CountryID;


            if (pictureBox1.ImageLocation != null)
                Contacts.ImagePath = pictureBox1.ImageLocation;
            else
                Contacts.ImagePath = "";

            if (Contacts.Save())
                MessageBox.Show("Data Saved Successfully.");
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.");

            Mode = enMode.Update;
            lblMode.Text = "Edit Contact ID = " + Contacts.ID;
            lblContactID.Text = Contacts.ID.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
