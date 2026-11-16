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
    public partial class FrmTreeview : Form
    {
        public FrmTreeview()
        {
            InitializeComponent();
        }

        private void btnNodeName_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Text = txtNodeName.Text;
        }

        private void AfterCheck(TreeNode Node, Boolean ischecked)
        {
            foreach(TreeNode item in Node.Nodes)
            {
                item.Checked = ischecked;

                if(item.Nodes.Count > 0)
                {
                    this.AfterCheck(item, ischecked);
                }
            }
        }
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            AfterCheck(e.Node, e.Node.Checked);
        }

        private void lblNewNode_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Nodes.Add(txtNewNode.Text);
        }

        private void btnRenameOfNode_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Text = txtRenameOfNode.Text;
        }

        private void btnRemoveNode_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void FrmTreeview_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNewNode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemoveNodeByName_Click(object sender, EventArgs e)
        {

        }

        void RemoveByName(TreeNodeCollection Nodes, string Name )
        {
            foreach (TreeNode Node in Nodes)
            {
                if (Node.Text == Name)
                {
                    treeView1.Nodes.Remove(Node); return;
                }
                else if (Node.Nodes.Count > 0)
                {
                    this.RemoveByName(Node.Nodes, Name);
                }
            }
        }
        private void btnRemoveNodeByName_Click_1(object sender, EventArgs e)
        {
            RemoveByName(treeView1.Nodes, txtRemoveNodeByName.Text);
        }



          

    }
}
