using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIBMS_DataAccess;
using System.Data;
using LIBMS_Business;
using System.Windows.Forms;

namespace LIBMS_Business
{
    public class clsLibraryAccessing
    {
        public int _LogID { get; set; }
        public int _PersonID { get; set; }
        public DateTime _AccessTime { get; set; }
        public DateTime? _OutTime { get; set; }
        public string _Reason { get; set; }

        public clsLibraryAccessing()
        {
            _LogID = -1;
            _PersonID = -1;
            _AccessTime = DateTime.Now;
            _OutTime = null;
            _Reason = "";
        }

        private clsLibraryAccessing(int LogID, DateTime AccessTime, DateTime? OutTime, string Reason)
        {
            _LogID = LogID;
            _AccessTime = AccessTime;
            _OutTime = OutTime;
            _Reason = Reason;
        }

        public static DataTable GetAllLibraryAccessing()
        {
            return clsLibraryAccessData.GetAllLibraryAccessing();
        }

        public bool AddLibraryAccessing()
        {
            _LogID = clsLibraryAccessData.AddLibraryAccessing(_PersonID, _AccessTime, _OutTime, _Reason);
            return (_LogID != -1);
        }

        public bool UpdateLibraryAccesslog()
        {
            return clsLibraryAccessData.UpdateLibraryAccesslog(_LogID, _OutTime);
        }

        public clsLibraryAccessing GetLibraryAccesslogByLogID(int LogID)
        {
            DateTime AccessTime = DateTime.Now; DateTime? OutTime = null;
            string Reason = "";

            bool isFound = clsLibraryAccessData.GetLibraryAccesslogByLogID(LogID, ref AccessTime, ref OutTime, ref Reason);
            if (isFound)
            {
                return new clsLibraryAccessing(LogID, AccessTime, OutTime, Reason);
            }
            else
            {
                return null;
            }
        }

    }
}
