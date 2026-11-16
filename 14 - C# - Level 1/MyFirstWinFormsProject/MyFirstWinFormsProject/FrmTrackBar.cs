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
    public partial class FrmTrackBar : Form
    {
        public FrmTrackBar()
        {
            InitializeComponent();
        }
        void PictureOpacity(PictureBox PicttureBox, double Opacity)
        {
            Bitmap btm = new Bitmap(PicttureBox.Image);

            for(int i = 0; i< btm.Width; i++)
            {
                for (int j = 0; j < btm.Height; j++)
                {
                    Color pixelColor = btm.GetPixel(i, j);

                    Color newcolor = Color.FromArgb(
                        255,
                        pixelColor.R,
                        pixelColor.G,
                        pixelColor.B
                        );
                    btm.SetPixel(i,j,newcolor);
                }
            }
            PicttureBox.Image = btm;
        }

        byte value1, value2, value3;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblTrackBar.Text = trackBar1.Value.ToString();
            pictureBox1.Width = trackBar1.Value;
            pictureBox1.Height = trackBar1.Value;
            pictureBox1.Refresh();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            lblTrackBar2.Text = trackBar2.Value.ToString();
            value1 = Convert.ToByte(lblTrackBar2.Text);
            lblTrackBar2.BackColor = Color.FromArgb(value1, value1, value1);

            lblMixedColors.BackColor = Color.FromArgb(value1, value2, value3);

            pictureBox1.BackColor = Color.FromArgb(value1, value2, value3);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            lblTrackBar3.Text = trackBar3.Value.ToString();
            byte value2 = Convert.ToByte(lblTrackBar3.Text);
            lblTrackBar3.BackColor = Color.FromArgb(value2, value2, value2);

            lblMixedColors.BackColor = Color.FromArgb(value1, value2, value3);

            pictureBox1.BackColor = Color.FromArgb(value1, value2, value3);
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            lblTrackBar4.Text = trackBar4.Value.ToString();
            byte value3 = Convert.ToByte(lblTrackBar4.Text);
            lblTrackBar4.BackColor = Color.FromArgb(value3, value3, value3);

            lblMixedColors.BackColor = Color.FromArgb(value1, value2, value3);

            pictureBox1.BackColor = Color.FromArgb(value1, value2, value3);
        }

        private void lblTrackBar2_Click(object sender, EventArgs e)
        {
            byte value = Convert.ToByte(lblTrackBar2.Text);
            lblTrackBar2.BackColor = Color.FromArgb(value, value, value);

        }
    }
}
