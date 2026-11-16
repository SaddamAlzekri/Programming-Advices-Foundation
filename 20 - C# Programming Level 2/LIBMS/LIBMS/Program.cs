using System;
using LIBMS.Reading_Session;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIBMS.People;
using LIBMS.Login;
using LIBMS.Books;
using LIBMS.Sale;
using LIBMS.Returns;

namespace LIBMS
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
           // Application.Run(new Form1());
            Application.Run(new frmLogin());
            // Application.Run(new frmListReadingSession());
            // Application.Run(new frmListBooks());
            // Application.Run(new frmBookReturnList());
        }
    }
}
