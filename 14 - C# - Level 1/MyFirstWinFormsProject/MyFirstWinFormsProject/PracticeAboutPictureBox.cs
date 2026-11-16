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
    public partial class PracticeAboutPictureBox : Form
    {
        public PracticeAboutPictureBox()
        {
            InitializeComponent();
        }

        string imagePath = "";
        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Photos";
            openFileDialog1.Title = "Change the image";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog1.FileName;
            }

            pictureBox1.Load(imagePath);
        }
    }
}
