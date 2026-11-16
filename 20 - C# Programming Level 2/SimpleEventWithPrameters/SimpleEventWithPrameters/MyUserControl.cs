using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleEventWithPrameters
{
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            InitializeComponent();
        }

        public class CalculationCompleteEventArgs : EventArgs
        {
            public int Value1 { get; set; }
            public int Value2 { get; set; }
            public int Result { get; set; }

            public CalculationCompleteEventArgs(int value1, int value2, int Result)
            {
                this.Value1 = value1;
                this.Value2 = value2;
                this.Result = Result;
            }
        }

        public event EventHandler<CalculationCompleteEventArgs> OnCalculationComplete;

        public void RaiseCalculationComplete(int value1, int value2, int Result)
        {
            RaiseonCalculationComplete(new CalculationCompleteEventArgs(value1, value2, Result));
        }

        protected virtual void RaiseonCalculationComplete(CalculationCompleteEventArgs e)
        {
            if(OnCalculationComplete != null)
            {
                OnCalculationComplete.Invoke(this, e);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int Value1 = int.Parse(textBox1.Text);
            int Value2 = int.Parse(textBox1.Text);

            int Result = Value1 + Value2;
            lblResult.Text = Result.ToString();

            if(OnCalculationComplete != null)
            {
                RaiseCalculationComplete(Value1, Value2, Result);
            }
        }
    }
}
