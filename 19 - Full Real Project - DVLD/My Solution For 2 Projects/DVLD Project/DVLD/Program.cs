using System;
using DVLD.Login;
using DVLD.Applications.Local_Driving_License;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new frmMain());
          //  Application.Run(new People.frmFindPerson());
          //  Application.Run(new People.frmShowPersonInfo(1));
           // Application.Run(new frmAddUpdateLocalDrivingLicenseApplication());
           Application.Run(new frmLogin());

        }
    }
}
