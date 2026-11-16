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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnShowPaert1_Click(object sender, EventArgs e)
        {
            Form Frm1 = new Form1();
            Frm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Frm1 = new Form1();
            Frm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Frm = new FrmMessageBox();
            Frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Frm = new FrmChkRadiogGroup();
            Frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Frm = new FrmTextbox();
            Frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form Frm = new FrmPictureBox();
            Frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form Frm = new FrmMaskedBox();
            Frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form Frm = new FrmComboBox();
            Frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form Frm = new FrmLinkLabel();
            Frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form Frm = new FrmCheckListBox();
            Frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form Frm = new FrmDateTimePicker();
            Frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form Frm = new FrmMonthCalendar();
            Frm.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form Frm = new FrmTimer();
            Frm.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form Frm = new FrmNotifyIcon();
            Frm.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form Frm = new FrmTreeview();
            Frm.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form Frm = new FrmProgressBar();
            Frm.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form Frm = new FrmListview();
            Frm.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form Frm = new FrmTrackBar();
            Frm.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form Frm = new FrmTabControl();
            Frm.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form Frm = new FrmGroupboxVSPanel();
            Frm.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form Frm = new FrmDialog();
            Frm.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            PracticeAboutPictureBox frm = new PracticeAboutPictureBox();
            frm.ShowDialog();
        }
    }
}