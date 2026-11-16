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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);
            else if (rbMediam.Checked)
                return Convert.ToSingle(rbMediam.Tag); 
            else
                return Convert.ToSingle(rbLarg.Tag);
        }

        double calculateTopponingPrice()
        {
            double TopponingTotalPtice = 0;

            if (chkExtraChees.Checked)
                TopponingTotalPtice += Convert.ToSingle(chkExtraChees.Tag);
            if (chkMushroom.Checked)
                TopponingTotalPtice += Convert.ToSingle(chkMushroom.Tag);
            if (chkTomatoes.Checked)
                TopponingTotalPtice += Convert.ToSingle(chkTomatoes.Tag);
            if (chkOnion.Checked)
                TopponingTotalPtice += Convert.ToSingle(chkOnion.Tag);
            if (chkOlives.Checked)
                TopponingTotalPtice += Convert.ToSingle(chkOlives.Tag);
            if (chkGreenPapper.Checked)
                TopponingTotalPtice += Convert.ToSingle(chkGreenPapper.Tag);

            return TopponingTotalPtice;
        }

        double GetSelectedCrustPrice()
        {
            if (rbThinCrust.Checked)
                return Convert.ToSingle(rbThinCrust.Tag);
            else
                return Convert.ToSingle(rbThickCrust.Tag);
        }

        double calculateTotalPrice()
        {
            return GetSelectedSizePrice() + calculateTopponingPrice() + GetSelectedCrustPrice();
        }

        void UpdateTotalPrice()
        {
            lblPrice.Text = "" + Convert.ToSingle(calculateTotalPrice());
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
                lblSize.Text = rbSmall.Text;
            else if (rbMediam.Checked)
                lblSize.Text = rbMediam.Text;
            else 
                lblSize.Text = rbLarg.Text;
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbThinCrust.Checked)
                lblCrust.Text = rbThinCrust.Text;
            else
                lblCrust.Text = rbThickCrust.Text;
        }
        void UpdateWhereToEat()
        {
            if (rbEatIn.Checked)
                lblWhereToEat.Text = rbEatIn.Text;
            else
                lblWhereToEat.Text = rbTakeOut.Text;
        }

        void UpdateTopponing()
        {
            UpdateTotalPrice();

            string text = "";
            if(chkExtraChees.Checked)
                text += chkExtraChees.Text;
            if(chkMushroom.Checked)
                text += ", "+ chkMushroom.Text;
            if (chkTomatoes.Checked)
                text += ", " + chkTomatoes.Text;
            if (chkOnion.Checked)
                text += ", "+ chkOnion.Text;
            if (chkOlives.Checked)
                text += ", " + chkOlives.Text;
            if (chkGreenPapper.Checked)
                text += ", " + chkGreenPapper.Text;
            if (text.StartsWith(", "))
                text = text.Substring(1, text.Length - 1).Trim();
            if (text == "")
                text = "No Topponing";
            lblTopponing.Text = text;
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order place Successfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOrderPizza.Enabled = false;
                gbSize.Enabled = false;
                gbCrust.Enabled = false;
                gbTopponing.Enabled = false;
                gbWhereToEat.Enabled = false;
                nUDNumberofPizza.Enabled = false;
            }
            else
                MessageBox.Show("Update your order", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMediam_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopponing();
        }

        private void chkMushroom_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopponing();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopponing();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopponing();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopponing();
        }

        private void chkGreenPapper_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopponing();
        }

        private void lblNumberOfPizza_Click(object sender, EventArgs e)
        {

        }

        private void nUDNumberofPizza_ValueChanged(object sender, EventArgs e)
        {
            lblNumberOfPizza.Text = Convert.ToString(nUDNumberofPizza.Value);

            int NumnUD = Convert.ToInt32(nUDNumberofPizza.Value);
            int NumPrice = Convert.ToInt32(lblPrice.Text);


            lblPrice.Text = Convert.ToString(NumnUD * calculateTotalPrice());
        }

        private void gbTopponing_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblNumberOfPizza.Text = "1";

        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {

            if(!btnOrderPizza.Enabled)
            {
                btnOrderPizza.Enabled = true;
                gbSize.Enabled = true;
                gbCrust.Enabled = true;
                gbTopponing.Enabled = true;
                gbWhereToEat.Enabled = true;

                chkExtraChees.Checked = false;
                chkGreenPapper.Checked = false;
                chkMushroom.Checked = false;
                chkOlives.Checked = false;
                chkTomatoes.Checked = false;
                chkOnion.Checked = false;

                rbEatIn.Checked = true;

                rbThinCrust.Checked = true;

                rbSmall.Checked = true;
                nUDNumberofPizza.Enabled = true;
                nUDNumberofPizza.Value = 1;
            }

        }

    }
}
