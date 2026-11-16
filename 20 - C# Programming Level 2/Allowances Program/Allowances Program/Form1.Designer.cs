namespace Allowances_Program
{
    partial class Form1
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
            this.cmsAllowancesUpdate = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.allowancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCountOfEmplyees = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvEmployees1 = new System.Windows.Forms.DataGridView();
            this.cmsAllowancesUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsAllowancesUpdate
            // 
            this.cmsAllowancesUpdate.AutoSize = false;
            this.cmsAllowancesUpdate.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.cmsAllowancesUpdate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allowancesToolStripMenuItem});
            this.cmsAllowancesUpdate.Name = "cmsAllowancesUpdate";
            this.cmsAllowancesUpdate.Size = new System.Drawing.Size(153, 48);
            // 
            // allowancesToolStripMenuItem
            // 
            this.allowancesToolStripMenuItem.Image = global::Allowances_Program.Properties.Resources.money;
            this.allowancesToolStripMenuItem.Name = "allowancesToolStripMenuItem";
            this.allowancesToolStripMenuItem.Size = new System.Drawing.Size(143, 32);
            this.allowancesToolStripMenuItem.Text = "Allowances";
            this.allowancesToolStripMenuItem.Click += new System.EventHandler(this.allowancesToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Count Of Employees :";
            // 
            // lblCountOfEmplyees
            // 
            this.lblCountOfEmplyees.AutoSize = true;
            this.lblCountOfEmplyees.Location = new System.Drawing.Point(185, 461);
            this.lblCountOfEmplyees.Name = "lblCountOfEmplyees";
            this.lblCountOfEmplyees.Size = new System.Drawing.Size(19, 21);
            this.lblCountOfEmplyees.TabIndex = 2;
            this.lblCountOfEmplyees.Text = "#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LBC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(317, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employees Tables";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Allowances_Program.Properties.Resources.icons8_person_100;
            this.pictureBox1.Location = new System.Drawing.Point(365, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Allowances_Program.Properties.Resources.Close;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(778, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvEmployees1
            // 
            this.dgvEmployees1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees1.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployees1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees1.ContextMenuStrip = this.cmsAllowancesUpdate;
            this.dgvEmployees1.Location = new System.Drawing.Point(13, 215);
            this.dgvEmployees1.Name = "dgvEmployees1";
            this.dgvEmployees1.RowTemplate.Height = 30;
            this.dgvEmployees1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees1.Size = new System.Drawing.Size(865, 223);
            this.dgvEmployees1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 505);
            this.Controls.Add(this.dgvEmployees1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCountOfEmplyees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("LBC", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsAllowancesUpdate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCountOfEmplyees;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip cmsAllowancesUpdate;
        private System.Windows.Forms.ToolStripMenuItem allowancesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvEmployees1;
    }
}

