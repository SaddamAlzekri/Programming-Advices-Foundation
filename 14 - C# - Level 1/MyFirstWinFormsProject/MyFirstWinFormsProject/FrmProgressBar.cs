using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class FrmProgressBar : Form
    {
        public FrmProgressBar()
        {
            InitializeComponent();
        }
        int Counter = 0;
        void ResetProgressBar()
        {
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            lblProgressBar.Text = "0 %";
        }

        void ResetProgressBar2()
        {
            progressBar2.Maximum = 100;
            progressBar2.Minimum = 0;
            progressBar2.Value += 0;

            lblProgressBar2.Text = "0 %";
        }

        int MinCountOfNodeOfTreeview(TreeNodeCollection Nodes)
        {
            int Counter = Convert.ToInt32(lblNumberOfTasks.Text);
            Counter--;         
            foreach (TreeNode Node in Nodes)
            {
                Counter--;
                this.MinCountOfNodeOfTreeview(Node.Nodes); 
            }
            return Counter;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ResetProgressBar();
            for (int i = 0; i <= 10; i++)
            {
                if(progressBar1.Value < progressBar1.Maximum)
                {
                    Thread.Sleep(500);
                    progressBar1.Value += 10;
                    lblProgressBar.Text = (((float)progressBar1.Value / progressBar1.Maximum) * 100) + " %";
                    progressBar1.Refresh();
                    lblProgressBar.Refresh();
                }else
                {
                    lblProgressBar.Enabled = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblProgressBar.Enabled = true;
            ResetProgressBar();
        }

        private void lblNumberOfTasks_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Counter++;
            treeView1.Nodes.Add(txtAddTask.Text);
            lblNumberOfTasks.Text = Convert.ToString(Counter);
        }

        private void btnAddRootTask_Click(object sender, EventArgs e)
        {
            if(treeView1.SelectedNode != null)
            {
                Counter++;
                treeView1.SelectedNode.Nodes.Add(txtAddTask.Text);
                lblNumberOfTasks.Text = Convert.ToString(Counter);
            } 
            else
            {
                MessageBox.Show("Select any Node please", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblNumberOfTasks.Text = Convert.ToString(MinCountOfNodeOfTreeview(treeView1.SelectedNode.Nodes));

            treeView1.SelectedNode.Nodes.Remove(treeView1.SelectedNode);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            lblNumberOfTasks.Text = " 0 ";
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            int incrementNode = 100 / Counter;
            int RestNumber = 100 % Counter;
            ResetProgressBar2();
                if (progressBar2.Value < progressBar2.Maximum)
                {
                    Thread.Sleep(500);

                    if (e.Node.Checked)
                    {
                            progressBar2.Value += incrementNode;
                    }
                    else
                         progressBar2.Value -= incrementNode;

                    lblProgressBar2.Text = (((float)progressBar2.Value / progressBar2.Maximum) * 100) + " %";
                    progressBar2.Refresh();
                    lblProgressBar2.Refresh();
                }

                if (progressBar2.Value == 100)
                {
                    lblProgressBar2.Enabled = false;
                }   
        }

        private void btnProgressBar2_Click(object sender, EventArgs e)
        {
            progressBar2.Maximum = 100;
            progressBar2.Minimum = 0;
            progressBar2.Value = 0;

            lblProgressBar2.Text = "0";
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void txtAddTask_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
