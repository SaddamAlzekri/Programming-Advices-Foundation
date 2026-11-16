using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendDataToForm
{
    public partial class Form2 : Form
    {
        private int PersonID = -1;

        public Form2(int PersonID)
        {
            InitializeComponent();
            this.PersonID = PersonID;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblResult.Text = PersonID.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
