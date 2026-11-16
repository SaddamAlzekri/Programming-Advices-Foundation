using System;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIBMS_DataAccess;

namespace LIBMS_Business
{
    public class clsPackage
    {
        public int PackageID { get; set; }
        public string PackageName { get; set; }
        public string Description { get; set; }
        public decimal PackagePrice { get; set; }
        public int DurationMonth { get; set; }

        public clsPackage()
        {
            this.PackageID = -1;
            this.PackageName = "";
            this.Description = "";
            this.PackagePrice = 0;
            this.DurationMonth = 0;
        }

        private clsPackage(int PackageID, string PackageName, string Description, decimal PackagePrice, int DurationMonth)
        {
            this.PackageID = PackageID;
            this.PackageName = PackageName;
            this.Description = Description;
            this.PackagePrice = PackagePrice;
            this.DurationMonth = DurationMonth;
        }

        public static DataTable GetAllPackage()
        {
            return clsPackageData.GetAllPackage();
        }

        public bool UpdatePackageInfo(int PackageID)
        {
            return clsPackageData.UpdatePackageInfo(PackageID, PackageName, Description, PackagePrice, DurationMonth);
        }

        public static clsPackage GetPackageInfoByPackageID(int PackageID)
        {
            string PackageName = "", Description = "";
            decimal PackagePrice = 0;
            int DurationMonth = 0;

            bool isFound = clsPackageData.GetPackageInfoByPackageID(PackageID, ref PackageName, ref Description, ref PackagePrice, ref DurationMonth);

            if(isFound)
            {
                return new clsPackage(PackageID, PackageName, Description, PackagePrice, DurationMonth);
            }else
            {
                return null;
            }
        }

        public static DataTable GetMemberCardInfoByMemberShipID(int MemberShipID)
        {
            return clsPackageData.GetMemberCardInfoByMemberShipID(MemberShipID);
        }

    }
}
