using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllowanesProgram_Business;
using System.Diagnostics;

namespace Allowances_Program
{
    public partial class frmIncrementEmployees : Form
    {
        DataTable _dtAllowances = new DataTable();
        clsAllowances _Allowances;
        public frmIncrementEmployees()
        {
            InitializeComponent();
        }
        public frmIncrementEmployees(DataTable _dtAllowances)
        {
            InitializeComponent();
            this._dtAllowances = _dtAllowances; 
        }

        private void frmIncrementEmployees_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if(radioButton1.Checked)
            {
                _Allowances = new clsAllowances();
                Stopwatch sw = Stopwatch.StartNew();

                if (_Allowances.UpdateAllowancesByProgramming(_dtAllowances))
                {
                    sw.Stop();
                    MessageBox.Show("Done! with C# Language : " + sw.ElapsedMilliseconds + " ms", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }else
            {
                _Allowances = new clsAllowances();
                Stopwatch sw1 = Stopwatch.StartNew();
                if (_Allowances.UpdateAllowances())
                {
                    sw1.Stop();
                    MessageBox.Show("Done! with T-SQL Language : " + sw1.ElapsedMilliseconds + " ms", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
