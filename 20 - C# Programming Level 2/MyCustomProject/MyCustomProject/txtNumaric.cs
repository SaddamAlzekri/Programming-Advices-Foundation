using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCustomProject
{
    public partial class txtNumaric : TextBox
    {
        public txtNumaric()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public enum enStateOfTextox { String = 0, Number = 1, All = 2 }

        public enStateOfTextox StateOfTextBox { get; set; } = enStateOfTextox.String;

        private void txtNumaric_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (StateOfTextBox == enStateOfTextox.Number)
            {
                if (!char.IsDigit(this.Text.FirstOrDefault()))
                {
                    this.Text = "";
                }
            }
            else if (StateOfTextBox == enStateOfTextox.String)
            {
                if (char.IsDigit(this.Text.FirstOrDefault()))
                {
                    this.Text = "";
                }
            }else
            {
                e.Handled = false;
            }
        }
    }
}
