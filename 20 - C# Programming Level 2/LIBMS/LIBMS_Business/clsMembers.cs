using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIBMS_DataAccess;
using System.Windows.Forms;

namespace LIBMS_Business
{
    public class clsMembers
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int MemberShipID { set; get; }
        public int PersonID { get; set; }
        public int PackageID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }

        public clsMembers()
        {
            this.MemberShipID = -1;
            this.PersonID = -1;
            this.PackageID = -1;
            this.StartDate = DateTime.Now;
            this.EndDate = DateTime.Now.AddMonths(6);
            this.IsActive = false;

            Mode = enMode.AddNew;
        }

        public clsMembers(int MemberShipID, int PersonID, int PackageID, DateTime StartDate, DateTime EndDate, bool IsActive)
        {
            this.MemberShipID = MemberShipID;
            this.PersonID = PersonID;
            this.PackageID = PackageID;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.IsActive = IsActive;

            Mode = enMode.Update;
        }
         
        public static DataTable GetAllMembers()
        {
            return clsMembersData.GetAllMembers();
        }

        public static bool DeleteMember(int MemberShipID)
        {
            return clsMembersData.DeleteMember(MemberShipID);
        }

        private bool UpdateMember()
        {
            return clsMembersData.UpdateMember(this.MemberShipID, this.PersonID, this.PackageID, this.StartDate, this.EndDate, this.IsActive);
        }

        private bool AddNewMember()
        {
            this.MemberShipID = clsMembersData.AddNewMember(this.PersonID, this.PackageID, this.StartDate, this.EndDate, this.IsActive);
            return (MemberShipID != -1);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewMember())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return UpdateMember();

            }
            return false;
        }

        public static bool isPersonIDExist(int PersonID)
        {
            return clsMembersData.IsPersonIDExist(PersonID);
        }

        public static clsMembers GetMemberInfoByMemberShipID(int MemberShipID)
        {
            int PersonID = -1, PackageID = -1;
            DateTime StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(3);
            bool IsActive = false;

            bool isFound = clsMembersData.GetMemberInfoByMemberShipID(MemberShipID, ref PersonID, ref PackageID, ref StartDate, ref EndDate, ref IsActive);
            if(isFound)
            {
                return new clsMembers(MemberShipID, PersonID, PackageID, StartDate, EndDate, IsActive);
            }else
            {
                return null;
            }
        }

    }
}