using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.BusnissLayer;

namespace LibraryManagement.PresentationLayer
{
    public partial class FRM_ADDCAT : Form
    {
        public FRM_ADDCAT()
        {
            InitializeComponent();
        }
        public int ID;
       
        private void BnfImgBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            BusinessClass Business = new BusinessClass();

            if (bmtxtCategoryName.Text != "")
            {
                if(ID == 0)
                {
                 
                    Business.AddNewContact(bmtxtCategoryName.Text);
                    bmtxtCategoryName.Text = "";
                    FRM_DADD frm = new FRM_DADD();
                    frm.ShowDialog();
                }
                else
                {
                    Business.UpdateContact(ID, bmtxtCategoryName.Text);
                    bmtxtCategoryName.Text = "";
                    FRM_DADD frm = new FRM_DADD();
                    frm.ShowDialog();
                }
                              
            }
            else{
                FRM_ERRORINSERT frm2 = new FRM_ERRORINSERT();
                frm2.ShowDialog();
            }
            }
        }
    }

