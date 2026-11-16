using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPractice
{
    public partial class sendMessage : UserControl
    {
        public bool ButtonEnable
        {
            get { return btnMessage.Enabled; }
            set { btnMessage.Enabled = value; }
        }
        public sendMessage()
        {
            InitializeComponent();
        }

        private void txtMassege_TextChanged(object sender, EventArgs e)
        {
            ButtonEnable = !string.IsNullOrEmpty(txtMassege.Text);
        }

        private void sendMessage_Load(object sender, EventArgs e)
        {
            btnMessage.Enabled = false;
        }

    }
}
