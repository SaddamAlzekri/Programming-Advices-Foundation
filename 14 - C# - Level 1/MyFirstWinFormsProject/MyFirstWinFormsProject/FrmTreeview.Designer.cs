namespace MyFirstWinFormsProject
{
    partial class FrmTreeview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Saddam");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Abdoraman");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("NarAllah");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Boys", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Tolin");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Elin");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Sarah", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Kahlan");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Somaia", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Girls", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode9});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTreeview));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtNodeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNodeName = new System.Windows.Forms.Button();
            this.lblNewNode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewNode = new System.Windows.Forms.TextBox();
            this.btnRenameOfNode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRenameOfNode = new System.Windows.Forms.TextBox();
            this.btnRemoveNode = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemoveNodeByName = new System.Windows.Forms.TextBox();
            this.btnRemoveNodeByName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.treeView1.CheckBoxes = true;
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node12";
            treeNode1.Text = "Saddam";
            treeNode2.Name = "Node13";
            treeNode2.Text = "Abdoraman";
            treeNode3.Name = "Node14";
            treeNode3.Text = "NarAllah";
            treeNode4.Name = "Node10";
            treeNode4.Text = "Boys";
            treeNode5.Name = "Node17";
            treeNode5.Text = "Tolin";
            treeNode6.Name = "Node18";
            treeNode6.Text = "Elin";
            treeNode7.Name = "Node15";
            treeNode7.Text = "Sarah";
            treeNode8.Name = "Node19";
            treeNode8.Text = "Kahlan";
            treeNode9.Name = "Node16";
            treeNode9.Text = "Somaia";
            treeNode10.Name = "Node11";
            treeNode10.Text = "Girls";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode10});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(269, 323);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Boy.png");
            this.imageList1.Images.SetKeyName(1, "Girl.png");
            // 
            // txtNodeName
            // 
            this.txtNodeName.Location = new System.Drawing.Point(462, 30);
            this.txtNodeName.Name = "txtNodeName";
            this.txtNodeName.Size = new System.Drawing.Size(100, 20);
            this.txtNodeName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(287, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = " Enter Name Of Node  :";
            // 
            // btnNodeName
            // 
            this.btnNodeName.Location = new System.Drawing.Point(382, 70);
            this.btnNodeName.Name = "btnNodeName";
            this.btnNodeName.Size = new System.Drawing.Size(109, 23);
            this.btnNodeName.TabIndex = 3;
            this.btnNodeName.Text = "Add Name of Node";
            this.btnNodeName.UseVisualStyleBackColor = true;
            this.btnNodeName.Click += new System.EventHandler(this.btnNodeName_Click);
            // 
            // lblNewNode
            // 
            this.lblNewNode.Location = new System.Drawing.Point(382, 178);
            this.lblNewNode.Name = "lblNewNode";
            this.lblNewNode.Size = new System.Drawing.Size(109, 23);
            this.lblNewNode.TabIndex = 6;
            this.lblNewNode.Text = "Add New Node";
            this.lblNewNode.UseVisualStyleBackColor = true;
            this.lblNewNode.Click += new System.EventHandler(this.lblNewNode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(330, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = " Add New Node :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNewNode
            // 
            this.txtNewNode.Location = new System.Drawing.Point(462, 138);
            this.txtNewNode.Name = "txtNewNode";
            this.txtNewNode.Size = new System.Drawing.Size(100, 20);
            this.txtNewNode.TabIndex = 4;
            this.txtNewNode.TextChanged += new System.EventHandler(this.txtNewNode_TextChanged);
            // 
            // btnRenameOfNode
            // 
            this.btnRenameOfNode.Location = new System.Drawing.Point(748, 70);
            this.btnRenameOfNode.Name = "btnRenameOfNode";
            this.btnRenameOfNode.Size = new System.Drawing.Size(109, 23);
            this.btnRenameOfNode.TabIndex = 9;
            this.btnRenameOfNode.Text = "Rename Of Node";
            this.btnRenameOfNode.UseVisualStyleBackColor = true;
            this.btnRenameOfNode.Click += new System.EventHandler(this.btnRenameOfNode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(658, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = " Rename of Node  :";
            // 
            // txtRenameOfNode
            // 
            this.txtRenameOfNode.Location = new System.Drawing.Point(817, 30);
            this.txtRenameOfNode.Name = "txtRenameOfNode";
            this.txtRenameOfNode.Size = new System.Drawing.Size(100, 20);
            this.txtRenameOfNode.TabIndex = 7;
            // 
            // btnRemoveNode
            // 
            this.btnRemoveNode.Location = new System.Drawing.Point(834, 139);
            this.btnRemoveNode.Name = "btnRemoveNode";
            this.btnRemoveNode.Size = new System.Drawing.Size(109, 23);
            this.btnRemoveNode.TabIndex = 12;
            this.btnRemoveNode.Text = "Remove  Node";
            this.btnRemoveNode.UseVisualStyleBackColor = true;
            this.btnRemoveNode.Click += new System.EventHandler(this.btnRemoveNode_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(587, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Selected Node that Remove  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(388, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Selected Node that Remove by Name :";
            // 
            // txtRemoveNodeByName
            // 
            this.txtRemoveNodeByName.Location = new System.Drawing.Point(668, 253);
            this.txtRemoveNodeByName.Name = "txtRemoveNodeByName";
            this.txtRemoveNodeByName.Size = new System.Drawing.Size(100, 20);
            this.txtRemoveNodeByName.TabIndex = 13;
            // 
            // btnRemoveNodeByName
            // 
            this.btnRemoveNodeByName.Location = new System.Drawing.Point(590, 294);
            this.btnRemoveNodeByName.Name = "btnRemoveNodeByName";
            this.btnRemoveNodeByName.Size = new System.Drawing.Size(109, 23);
            this.btnRemoveNodeByName.TabIndex = 15;
            this.btnRemoveNodeByName.Text = "Remove  Node";
            this.btnRemoveNodeByName.UseVisualStyleBackColor = true;
            this.btnRemoveNodeByName.Click += new System.EventHandler(this.btnRemoveNodeByName_Click_1);
            // 
            // FrmTreeview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(952, 347);
            this.Controls.Add(this.btnRemoveNodeByName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRemoveNodeByName);
            this.Controls.Add(this.btnRemoveNode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRenameOfNode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRenameOfNode);
            this.Controls.Add(this.lblNewNode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewNode);
            this.Controls.Add(this.btnNodeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNodeName);
            this.Controls.Add(this.treeView1);
            this.Name = "FrmTreeview";
            this.Text = "FrmTreeview";
            this.Load += new System.EventHandler(this.FrmTreeview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txtNodeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNodeName;
        private System.Windows.Forms.Button lblNewNode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewNode;
        private System.Windows.Forms.Button btnRenameOfNode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRenameOfNode;
        private System.Windows.Forms.Button btnRemoveNode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemoveNodeByName;
        private System.Windows.Forms.Button btnRemoveNodeByName;
    }
}