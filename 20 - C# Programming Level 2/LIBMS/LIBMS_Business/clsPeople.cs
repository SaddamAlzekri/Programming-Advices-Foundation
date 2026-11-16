using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIBMS_DataAccess;

namespace LIBMS_Business
{
    public class clsPeople
    {
        public enum enMode { AddNew = 0, Update = 1}
        public enMode Mode = enMode.AddNew;

        public int PersonID { set; get; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get {return FirstName + " " + SecondName + " " + ThirdName + " " + LastName;}
        }

        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gendor { get; set; }
        public string Address { get; set; }
        public int NationalityCountryID { get; set; }

        public clsCountry CountryInfo;

        private string _ImagePath;

        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }

        public clsPeople()
        {
            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.DateOfBirth = DateTime.Now;
            this.Address = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";

            Mode = enMode.AddNew;
        }

        private clsPeople(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName,
        string Email, string Phone, DateTime DateOfBirth, int Gendor, string Address, int NationalityCountryID,
        string ImagePath)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.NationalNo = NationalNo;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            this.CountryInfo = clsCountry.Find(NationalityCountryID);
            Mode = enMode.Update;
        }
         
        private bool _AddNewPerson()
        {
            this.PersonID = clsPeopleData.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
            this.Email, this.Phone, this.DateOfBirth, this.Gendor, this.Address, this.NationalityCountryID,
            this.ImagePath);

            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return clsPeopleData.UpdatePerson( PersonID,this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
                  this.Email, this.Phone, this.DateOfBirth, this.Gendor, this.Address, this.NationalityCountryID,
                  this.ImagePath);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdatePerson();

            }
            return false;
        }

        public static DataTable GetAllPeople()
        {
            return clsPeopleData.GetAllPeople();
        }

        public static bool DeletePerson(int ID)
        {
            return clsPeopleData.DeletePerson(ID);
        }

        public static bool isPersonExist(int ID)
        {
            return clsPeopleData.IsPersonExist(ID);
        }

        public static bool isPersonExist(string NationlNo)
        {
            return clsPeopleData.IsPersonExist(NationlNo);
        }

        public static clsPeople Find(int PersonID)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", NationalNo = "", Email = "",
                Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int Gendor = -1, CountryID = -1;

            bool isFound = clsPeopleData.GetPersonInfoByID
                (
                PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref Email, ref Phone, ref DateOfBirth, ref Gendor, ref Address, ref CountryID,
                ref ImagePath
                );

            if (isFound)
                return new clsPeople(
                PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName,
                Email, Phone, DateOfBirth, Gendor, Address, CountryID,
                ImagePath);
            else
            {
                return null;
            }
        }

        public static clsPeople Find(string NationalNo)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "",
                Phone = "", Address = "", ImagePath = "";
            int PersonID = 0;
            DateTime DateOfBirth = DateTime.Now;
            int Gendor = -1, CountryID = -1;

            bool isFound = clsPeopleData.GetPersonInfoByNationalNo
                (
                NationalNo, ref PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref Email, ref Phone, ref DateOfBirth, ref Gendor, ref Address, ref CountryID,
                ref ImagePath
                );

            if (isFound)
                return new clsPeople(
                PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName,
                Email, Phone, DateOfBirth, Gendor, Address, CountryID,
                ImagePath);
            else
            {
                return null;
            }
        }

    }
}
