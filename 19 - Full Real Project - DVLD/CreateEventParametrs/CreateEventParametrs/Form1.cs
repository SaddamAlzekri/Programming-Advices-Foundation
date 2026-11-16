using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateEventParametrs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculaterWithEvent1_OnPersonSelected(int obj)
        {
            int Number = obj;

            MessageBox.Show(Number.ToString());

        }
    }
}
