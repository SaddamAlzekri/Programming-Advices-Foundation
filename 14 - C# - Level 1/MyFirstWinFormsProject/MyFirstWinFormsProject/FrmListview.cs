using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class FrmListview : Form
    {
        public FrmListview()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtGmail.Text = "";

            listView1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // int i = 0;
            listView1.SmallImageList = imageList1;

            ListViewItem item = new ListViewItem(txtID.Text);
            if (radioButton1.Checked)
                item.ImageIndex = 0;
            else
                item.ImageIndex = 1;
            item.SubItems.Add(txtName.Text);
            item.SubItems.Add(txtGmail.Text);
            if (radioButton1.Checked)
                item.SubItems.Add(radioButton1.Text);
            else
                item.SubItems.Add(radioButton2.Text);

            listView1.Items.Add(item);
           // i++;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];

                txtID.Text = item.Text;
                txtName.Text = item.SubItems[2].Text;
                txtGmail.Text = item.SubItems[3].Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];

                item.Text = txtID.Text;
                item.SubItems[2].Text = txtName.Text;
                item.SubItems[3].Text = txtGmail.Text;
            }
            else
                MessageBox.Show("Please selected any row for update", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
                MessageBox.Show("Please selected any row for Remove", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];


                lblID.Text = item.Text;

                if (item.SubItems[3].Text == "Male")
                    pictureBox1.Image = Properties.Resources.Boy;
                else
                    pictureBox1.Image = Properties.Resources.Girl;

                lblGender.Text = item.SubItems[3].Text;
                lblName.Text = item.SubItems[1].Text;
                lblGmail.Text = item.SubItems[2].Text;

            }else
                MessageBox.Show("Please selected any row for Display", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void txtID_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtID.Text))
            {
                e.Cancel = true;
                txtID.Focus();
                errorProvider1.SetError(txtID, "First Should have a value");
            }else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtID, "");
            }
        }

        private void txtGmail_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtGmail.Text))
            {
                e.Cancel = true;
                txtGmail.Focus();
                errorProvider1.SetError(txtGmail, "First Should have a value");
            } else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtGmail, "");
            }

        }

        private void radioButton1_Validating(object sender, CancelEventArgs e)
        {
            if(!radioButton1.Checked && !radioButton1.Checked)
            {
                e.Cancel = true;
                radioButton1.Focus();
                radioButton2.Focus();
                errorProvider1.SetError(radioButton2, "First Should have a value");
                errorProvider1.SetError(radioButton2, "First Should have a value");
            }else
            {
                e.Cancel = false;
                errorProvider1.SetError(radioButton2, "");
                errorProvider1.SetError(radioButton2, "");
            }
        }
    }
}
