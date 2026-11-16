namespace MyFirstWinFormsProject
{
    partial class FrmProgressBar
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgressBar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumberOfTasks = new System.Windows.Forms.Label();
            this.txtAddTask = new System.Windows.Forms.TextBox();
            this.btnAddRootTask = new System.Windows.Forms.Button();
            this.btnProgressBar2 = new System.Windows.Forms.Button();
            this.lblProgressBar2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(372, 35);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(176, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // lblProgressBar
            // 
            this.lblProgressBar.AutoSize = true;
            this.lblProgressBar.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblProgressBar.ForeColor = System.Drawing.Color.Blue;
            this.lblProgressBar.Location = new System.Drawing.Point(443, 7);
            this.lblProgressBar.Name = "lblProgressBar";
            this.lblProgressBar.Size = new System.Drawing.Size(33, 13);
            this.lblProgressBar.TabIndex = 1;
            this.lblProgressBar.Text = " 0 %";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Increase ProgressBar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(503, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Reset ProgressBar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(22, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(266, 216);
            this.treeView1.TabIndex = 5;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(44, 265);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(176, 23);
            this.progressBar2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(308, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "_________________________";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(331, 193);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(118, 23);
            this.btnAddTask.TabIndex = 9;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(399, 276);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Remove All";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(399, 232);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Remove Task";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(396, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Number Of Tasks   : ";
            // 
            // lblNumberOfTasks
            // 
            this.lblNumberOfTasks.AutoSize = true;
            this.lblNumberOfTasks.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblNumberOfTasks.ForeColor = System.Drawing.Color.Blue;
            this.lblNumberOfTasks.Location = new System.Drawing.Point(513, 325);
            this.lblNumberOfTasks.Name = "lblNumberOfTasks";
            this.lblNumberOfTasks.Size = new System.Drawing.Size(23, 13);
            this.lblNumberOfTasks.TabIndex = 13;
            this.lblNumberOfTasks.Text = " 0  ";
            this.lblNumberOfTasks.Click += new System.EventHandler(this.lblNumberOfTasks_Click);
            // 
            // txtAddTask
            // 
            this.txtAddTask.Location = new System.Drawing.Point(399, 167);
            this.txtAddTask.Name = "txtAddTask";
            this.txtAddTask.Size = new System.Drawing.Size(135, 20);
            this.txtAddTask.TabIndex = 14;
            this.txtAddTask.Click += new System.EventHandler(this.lblNumberOfTasks_Click);
            this.txtAddTask.TextChanged += new System.EventHandler(this.txtAddTask_TextChanged);
            // 
            // btnAddRootTask
            // 
            this.btnAddRootTask.Location = new System.Drawing.Point(489, 193);
            this.btnAddRootTask.Name = "btnAddRootTask";
            this.btnAddRootTask.Size = new System.Drawing.Size(118, 23);
            this.btnAddRootTask.TabIndex = 15;
            this.btnAddRootTask.Text = "Add Root Task";
            this.btnAddRootTask.UseVisualStyleBackColor = true;
            this.btnAddRootTask.Click += new System.EventHandler(this.btnAddRootTask_Click);
            // 
            // btnProgressBar2
            // 
            this.btnProgressBar2.Location = new System.Drawing.Point(63, 312);
            this.btnProgressBar2.Name = "btnProgressBar2";
            this.btnProgressBar2.Size = new System.Drawing.Size(118, 23);
            this.btnProgressBar2.TabIndex = 16;
            this.btnProgressBar2.Text = "Reset ProgressBar";
            this.btnProgressBar2.UseVisualStyleBackColor = true;
            this.btnProgressBar2.Click += new System.EventHandler(this.btnProgressBar2_Click);
            // 
            // lblProgressBar2
            // 
            this.lblProgressBar2.AutoSize = true;
            this.lblProgressBar2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblProgressBar2.ForeColor = System.Drawing.Color.Red;
            this.lblProgressBar2.Location = new System.Drawing.Point(110, 242);
            this.lblProgressBar2.Name = "lblProgressBar2";
            this.lblProgressBar2.Size = new System.Drawing.Size(33, 13);
            this.lblProgressBar2.TabIndex = 17;
            this.lblProgressBar2.Text = " 0 %";
            // 
            // FrmProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 347);
            this.Controls.Add(this.lblProgressBar2);
            this.Controls.Add(this.btnProgressBar2);
            this.Controls.Add(this.btnAddRootTask);
            this.Controls.Add(this.txtAddTask);
            this.Controls.Add(this.lblNumberOfTasks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblProgressBar);
            this.Controls.Add(this.progressBar1);
            this.Name = "FrmProgressBar";
            this.Text = "FrmProgressBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProgressBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumberOfTasks;
        private System.Windows.Forms.TextBox txtAddTask;
        private System.Windows.Forms.Button btnAddRootTask;
        private System.Windows.Forms.Button btnProgressBar2;
        private System.Windows.Forms.Label lblProgressBar2;
    }
}