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
    public partial class FrmTabControl : Form
    {
        public FrmTabControl()
        {
            InitializeComponent();
        }
        string AddCourseName()
        {
            string text = "";
            if (Chk1.Checked)
                text += Chk1.Text;
            if (Chk2.Checked)
                text += ", " + Chk2.Text;
            if (Chk3.Checked)
                text += "-" + Chk3.Text;
            if (Chk4.Checked)
                text += "-" + Chk4.Text;
            if (Chk5.Checked)
                text += "-" + Chk5.Text;
            if (Chk6.Checked)
                text += "-" + Chk6.Text;
            if (text.StartsWith("-"))
                text = text.Substring(1, text.Length - 1).Trim();
            if (text == "")
                text = "No Topponing";

            return text;
        }
        private void btnRegidter_Click(object sender, EventArgs e)
        {
            listView1.SmallImageList = imageList1;
            ListViewItem item = new ListViewItem(txtID.Text);

            if (Male.Checked)
                item.ImageIndex = 0;
            else
                item.ImageIndex = 1;
            item.SubItems.Add(txtName.Text);
            item.SubItems.Add(dateTimePicker1.Text);
            item.SubItems.Add(dateTimePicker2.Text);

            if(Male.Checked)
                item.SubItems.Add(Male.Text);
            else
                item.SubItems.Add(Female.Text);

            item.SubItems.Add(txtAddress.Text);
            item.SubItems.Add(txtPhoneNumber.Text);
            item.SubItems.Add(txtGmail.Text);
            item.SubItems.Add(comboBox1.Text);
            item.SubItems.Add(AddCourseName());
            item.SubItems.Add(comboBox3.Text);

            listView1.Items.Add(item);
        }

        string[] Split(string S1)
        {
            return S1.Split('-');
        }

        void CourseName(string S1)
        {
            int x = S1.Count();
            string[] CoursesName = new string[6];
            CoursesName = Split(S1);
            for (int i = 0; i < CoursesName.Count(); i++)
            {
                if (CoursesName[i] == Chk1.Text)
                    Chk1.Checked = true;
                if (CoursesName[i] == Chk2.Text)
                    Chk2.Checked = true;
                if (CoursesName[i] == Chk3.Text)
                    Chk3.Checked = true;
                if (CoursesName[i] == Chk4.Text)
                    Chk4.Checked = true;
                if (CoursesName[i] == Chk5.Text)
                    Chk5.Checked = true;
                if (CoursesName[i] == Chk6.Text)
                    Chk6.Checked = true;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            listView1.SmallImageList = imageList1;
            ListViewItem item = listView1.SelectedItems[0];

            item.SubItems[0].Text = txtID.Text;
           
            if (Male.Checked)
                item.ImageIndex = 0;
            else
                item.ImageIndex = 1;
            item.SubItems[1].Text = txtName.Text;
            item.SubItems[2].Text = dateTimePicker1.Text;
            item.SubItems[3].Text = dateTimePicker2.Text;

            if (Male.Checked)
                item.SubItems[4].Text = Male.Text;
            else
                item.SubItems[4].Text = Female.Text;

            item.SubItems[5].Text = txtAddress.Text;
            item.SubItems[6].Text = txtPhoneNumber.Text;
            item.SubItems[7].Text = txtGmail.Text;
            item.SubItems[8].Text = comboBox1.Text;
            item.SubItems[9].Text = AddCourseName();
            item.SubItems[10].Text = comboBox3.Text;

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                txtID.Text = item.SubItems[0].Text;
                txtName.Text = item.SubItems[1].Text;

                if (item.SubItems[4].Text == "Male")
                {
                    Male.Checked = true;
                    personalImage.Image = Properties.Resources.Boy;
                }
                else
                {
                    Female.Checked = true;
                    personalImage.Image = Properties.Resources.Girl;
                }

                comboBox1.Text = item.SubItems[8].Text;
                comboBox3.Text = item.SubItems[10].Text;
                txtAddress.Text = item.SubItems[5].Text;
                txtPhoneNumber.Text = item.SubItems[6].Text; 
                txtGmail.Text = item.SubItems[7].Text;
                string S1= item.SubItems[9].Text;
                CourseName(S1);
            }
           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
                MessageBox.Show("Select any row please", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Chk5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems.Clear();
            txtID.Text = "";
            personalImage.Image = null;
            txtName.Text = "";
            txtPhoneNumber.Text = "";
            txtGmail.Text = "";
            txtAddress.Text = "";
            comboBox1.Text = "";
            comboBox3.Text = "";
            if (Male.Checked)
                Male.Checked = false;
            if (Female.Checked)
                Female.Checked = false;
            Chk1.Checked = false;
            Chk2.Checked = false;
            Chk3.Checked = false;
            Chk4.Checked = false;
            Chk5.Checked = false;
            Chk6.Checked = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems.Clear();
            foreach(ListViewItem item in listView1.Items)
            {
                if(item.SubItems[1].Text.ToLower().Contains(txtName.Text.ToLower()))
                {
                        listView1.SmallImageList = imageList1;
                        txtID.Text = item.SubItems[0].Text;
                        txtName.Text = item.SubItems[1].Text;

                        if (item.SubItems[4].Text == "Male")
                        {
                            Male.Checked = true;
                            personalImage.Image = Properties.Resources.Boy;
                        }
                        else
                        {
                            Female.Checked = true;
                            personalImage.Image = Properties.Resources.Girl;
                        }

                        comboBox1.Text = item.SubItems[8].Text;
                        comboBox3.Text = item.SubItems[10].Text;
                        txtAddress.Text = item.SubItems[5].Text;
                        txtPhoneNumber.Text = item.SubItems[6].Text;
                        txtGmail.Text = item.SubItems[7].Text;
                        string S1 = item.SubItems[9].Text;
                        CourseName(S1);

                        item.Selected = true;
                        item.EnsureVisible(); break;

                }
            }
        }
    }
}
