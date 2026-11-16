using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeYourPizza
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                if (txtbox_UserName.Text == "Saddam" && txtbox_Password.Text == "1234")
                {
                    Form frm = new Form1();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username/password is wrong!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }
    }
}
