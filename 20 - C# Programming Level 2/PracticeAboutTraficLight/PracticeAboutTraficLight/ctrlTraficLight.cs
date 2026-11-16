using PracticeAboutTraficLight.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeAboutTraficLight
{
    public partial class ctrlTraficLight : UserControl
    {
        public ctrlTraficLight()
        {
            InitializeComponent();
        }

        private enum enPoints { RedPoint = 0, OrangePoint = 1, GreenPoint = 2};

        private enPoints _3Points = enPoints.RedPoint;

        private int TotalOfPoints = 22;

        private void ChangeImageAndPicture(int TotalOfPoints)
        {
            if (TotalOfPoints <= 22 && TotalOfPoints > 12)
            {
                pbTraficLight.Image = Resources.Red;
            }
            else if (TotalOfPoints <= 12 && TotalOfPoints > 5)
            {
                pbTraficLight.Image = Resources.Orange;
            }
            else
            {
                pbTraficLight.Image = Resources.Green;
            }
        }

        private void Messagebox(int TotalOfPoints, int  Point, string mgs)
        {
            if(TotalOfPoints == Point)
            {
                MessageBox.Show(mgs);  
            }
        }
        
        public void Start()
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            lblCountTrafic.Text = TotalOfPoints.ToString();
            if(TotalOfPoints == 0)
            {
                TotalOfPoints = 22;
            } else
            {
                ChangeImageAndPicture(TotalOfPoints);

                --TotalOfPoints;

                Messagebox(TotalOfPoints + 1, 22, "Red");
                Messagebox(TotalOfPoints, 12, "Orange");
                Messagebox(TotalOfPoints, 5, "green");
            }

        }

        private void _ChangeLight()
        {

        }
    }
}
