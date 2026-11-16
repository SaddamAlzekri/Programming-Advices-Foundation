using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIBMS_DataAccess;
using System.Security.Cryptography;
using System.Data;

namespace LIBMS_Business
{
    public class clsUser
    {
        public enum enMode { Addnew = 0, Update = 1}
        public enMode Mode = enMode.Addnew;

        public int UserID { set; get; }
        public int PersonID { set; get; }
        public clsPeople PersonInfo;
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }
        public int Permission { set; get; }

        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = true;
            this.Permission = -1;

            Mode = enMode.Addnew;
        }

        public clsUser(int UserID, int PersonID, string UserName, string Password, bool IsActive, int Permission)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.PersonInfo = clsPeople.Find(PersonID);
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            this.Permission = Permission;

            Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUserData.AddNewUser(this.PersonID, this.UserName, ComputeHashing(this.Password), this.IsActive, this.Permission);

            return (UserID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserID, this.PersonID, this.UserName, ComputeHashing(this.Password), this.IsActive, this.Permission);
        }

        public static clsUser FindByUserID(int UserID)
        {
            int PersonID = -1, Permission = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            if (clsUserData.GetUserInfoByUserID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive, ref Permission))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive, Permission);
            }else
            {
                return null;
            }
        }

        public static clsUser FindByPersonID(int PersonID)
        {
            int UserID = -1, Permission = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            if (clsUserData.GetUserInfoByPersonID(PersonID, ref UserID, ref UserName, ref Password, ref IsActive, ref Permission))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive, Permission);
            }
            else
            {
                return null;
            }
        }

        public static clsUser FindByUsernameAndPassword(string UserName, string Password)
        {
            int UserID = -1;
            int PersonID = -1, Permission = -1;
            bool IsActive = false;


            bool IsFound = clsUserData.GetUserInfoByUsernameAndPassword
                                (UserName, ComputeHashing(Password), ref UserID, ref PersonID, ref IsActive, ref Permission);

            if (IsFound)
                return new clsUser(UserID, PersonID, UserName, Password, IsActive, Permission);
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Addnew:
                    if (_AddNewUser())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser();

            }

            return false;
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

        public static bool isUserExist(int UserID)
        {
            return clsUserData.IsUserExist(UserID);
        }

        public static bool isUserExist(string UserName)
        {
            return clsUserData.IsUserExist(UserName);
        }

        public static bool isUserExistForPersonID(int PersonID)
        {
            return clsUserData.IsUserExistForPersonID(PersonID);
        }

        private static string ComputeHashing(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

    }
}
