using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendDataBackFromForm2ToForm1
{
    public partial class Form2 : Form
    {
        public delegate void DatabackEventHandler(object sender, int PersonID);

        public event DatabackEventHandler DataBack;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSendBackData_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(textBox1.Text);

            if(DataBack != null)
            {
                DataBack.Invoke(this, PersonID);
            }

            this.Close();
        }
    }
}
