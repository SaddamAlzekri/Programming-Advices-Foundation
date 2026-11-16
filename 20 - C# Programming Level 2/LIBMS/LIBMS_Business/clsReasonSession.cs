using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIBMS_DataAccess;
using System.Data;

namespace LIBMS_Business
{
    public class clsReasonSession
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int SessionID { get; set; }
        public int MemberID { get; set; }
        public int BookID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public string ReasonOfCancel { get; set; }

        public clsReasonSession()
        {
            this.SessionID = -1;
            this.MemberID = -1;
            this.BookID = -1;
            this.StartDate = DateTime.Now;
            this.EndDate = DateTime.Now.AddMonths(3);
            this.Status = "Active";
            this.ReasonOfCancel = null;

            Mode = enMode.AddNew;
        }

        public clsReasonSession(int SessionID, int MemberID, int BookID, DateTime StartTime, DateTime EndTime, string Status, string ReasonOfCancel)
        {
            this.SessionID = SessionID;
            this.MemberID = MemberID;
            this.BookID = BookID;
            this.StartDate = StartDate;
            this.EndDate = EndTime;
            this.Status = Status;
            this.ReasonOfCancel = ReasonOfCancel;

            Mode = enMode.Update;
        }

        public static DataTable GetAllReadingSession()
        {
            return clsReasonSessionData.GetAllReadingSession();
        }

        private bool AddNewReadingSession()
        {
            this.SessionID = clsReasonSessionData.AddNewReadingSession(this.MemberID, this.BookID, this.StartDate, this.EndDate, this.Status, this.ReasonOfCancel);

            return (this.SessionID != -1);
        }

        private bool CancelledOfReadingSession()
        {
            return clsReasonSessionData.CancelledOfReadingSession(this.SessionID, this.EndDate, this.Status, this.ReasonOfCancel);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewReadingSession())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return CancelledOfReadingSession();
            }
            return false;
        }

        public static bool CompletedOfReadingSession(int SessionID, DateTime EndDate, string Status)
        {
            return clsReasonSessionData.CompletedOfReadingSession(SessionID, EndDate, Status);
        }

        public static DataTable GetReasonSessionInfo(int SessionID)
        {
            return clsReasonSessionData.GetReasonSessionInfo(SessionID);
        }

        public static DataTable GetBooksInfo(int MemberID)
        {
            return clsReasonSessionData.GetBooksInfo(MemberID);
        }

        public static DataTable GetMemberInfo(int MemberID)
        {
            return clsReasonSessionData.GetMemberInfo(MemberID);
        }

        public DataTable GetMemberInfo()
        {
            return clsReasonSessionData.GetMemberInfo(this.MemberID);
            Mode = enMode.Update;
        }

    }
}






