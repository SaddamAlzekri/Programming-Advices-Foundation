using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIBMS_Business;

namespace LIBMS.Gloal_Classes
{
    public class clsGlobal
    {
        public static clsUser CurrentUser;

        public static void ControlOfpnlLetfList(Panel pnlLetfList, Button btnClose, Label lblTime, Label lblUserName, PictureBox pictureBox1, Label lblPersonalImage, Label label2, Label label4)
        {
            if (pnlLetfList.Width == 200)
            {
                btnClose.Location = new Point(3, 1);
                lblTime.Visible = false;
                lblUserName.Visible = false;
                pictureBox1.Visible = false;
                lblPersonalImage.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                pnlLetfList.Width = 50;
            }
            else
            {
                btnClose.Location = new Point(155, 3);
                lblTime.Visible = true;
                lblUserName.Visible = true;
                label2.Visible = true;
                lblPersonalImage.Visible = true;
                label4.Visible = true;
                pictureBox1.Visible = true;
                pnlLetfList.Width = 200;
            }
        }

        public static void NowTime(Label lblTime)
        {
            DateTime time = DateTime.Now;

            lblTime.Text = time.ToString("hh : mm : ss tt");
        }

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\LIBMS\Login";

            try
            {

                Registry.SetValue(keyPath, "Username", Username, RegistryValueKind.String);
                Registry.SetValue(keyPath, "Password", Password, RegistryValueKind.String);

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\LIBMS\Login";

            try
            {
                string UsernameV = Registry.GetValue(keyPath, "Username", null) as string;
                string PasswordV = Registry.GetValue(keyPath, "Password", null) as string;

                if (UsernameV != null && PasswordV != null)
                {
                    Username = UsernameV;
                    Password = PasswordV;
                }

            }
            catch (Exception ex)
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
