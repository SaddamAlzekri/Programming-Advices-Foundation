using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateEventParametrs
{
    public partial class CalculaterWithEvent : UserControl
    {
        public CalculaterWithEvent()
        {
            InitializeComponent();
        }

        public event Action<int> OnPersonSelected;
        protected virtual void PersonSelected(int PersonID)

        {
            Action<int> handler = OnPersonSelected;

            if(handler != null)
            {
                handler(PersonID);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Result = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);

            label2.Text = Result.ToString();

            if (OnPersonSelected != null)
            {
                PersonSelected(Result);
            }
        }



    }
}
