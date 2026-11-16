using System;
using Microsoft.Win32;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Business;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace DVLD.GlobalClasses
{
    public class clsGlobal
    {
        public static clsUser CurrentUser;

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD\Login";
           

            try
            {

            Registry.SetValue(keyPath, "Username", Username, RegistryValueKind.String);
            Registry.SetValue(keyPath, "Password", Password, RegistryValueKind.String);

            }catch(Exception ex)
            {
                return false;
            }
            return true;
        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD\Login";

            try
            {
                string UsernameV = Registry.GetValue(keyPath, "Username", null) as string;
                string PasswordV = Registry.GetValue(keyPath, "Password", null) as string;

                if(UsernameV != null && PasswordV != null)
                {
                    Username = UsernameV;
                    Password = PasswordV;
                }

            }catch(Exception ex)
            {
                Username = "";
                Password = "";
                return false;
            }
            return true;
        }

        public static void ApplyRoundCorner(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }
    }
}
