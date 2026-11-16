namespace AtudentApiClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.cmsStudent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rdbAllStudent = new System.Windows.Forms.RadioButton();
            this.rdbPassStudent = new System.Windows.Forms.RadioButton();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAverageOfStudents = new System.Windows.Forms.Label();
            this.lblSearchStudent = new System.Windows.Forms.PictureBox();
            this.pbPersonalImage = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.cmsStudent.SuspendLayout();
            this.gbStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblSearchStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.ContextMenuStrip = this.cmsStudent;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudents.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvStudents.Location = new System.Drawing.Point(12, 406);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowTemplate.Height = 30;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(779, 223);
            this.dgvStudents.TabIndex = 0;
            // 
            // cmsStudent
            // 
            this.cmsStudent.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.updateStudentToolStripMenuItem,
            this.deleteStudentToolStripMenuItem});
            this.cmsStudent.Name = "cmsStudent";
            this.cmsStudent.Size = new System.Drawing.Size(173, 118);
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Image = global::AtudentApiClient.Properties.Resources.icons8_add_user_male_48;
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(172, 38);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // updateStudentToolStripMenuItem
            // 
            this.updateStudentToolStripMenuItem.Image = global::AtudentApiClient.Properties.Resources.delete_delete_deleteusers_delete_male_user_maleclient_2348;
            this.updateStudentToolStripMenuItem.Name = "updateStudentToolStripMenuItem";
            this.updateStudentToolStripMenuItem.Size = new System.Drawing.Size(172, 38);
            this.updateStudentToolStripMenuItem.Text = "Update Student";
            this.updateStudentToolStripMenuItem.Click += new System.EventHandler(this.updateStudentToolStripMenuItem_Click);
            // 
            // deleteStudentToolStripMenuItem
            // 
            this.deleteStudentToolStripMenuItem.Image = global::AtudentApiClient.Properties.Resources.Close;
            this.deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            this.deleteStudentToolStripMenuItem.Size = new System.Drawing.Size(172, 38);
            this.deleteStudentToolStripMenuItem.Text = "Delete Student";
            this.deleteStudentToolStripMenuItem.Click += new System.EventHandler(this.deleteStudentToolStripMenuItem_Click);
            // 
            // rdbAllStudent
            // 
            this.rdbAllStudent.AutoSize = true;
            this.rdbAllStudent.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAllStudent.Location = new System.Drawing.Point(14, 355);
            this.rdbAllStudent.Name = "rdbAllStudent";
            this.rdbAllStudent.Size = new System.Drawing.Size(129, 34);
            this.rdbAllStudent.TabIndex = 1;
            this.rdbAllStudent.TabStop = true;
            this.rdbAllStudent.Text = "All Student";
            this.rdbAllStudent.UseVisualStyleBackColor = true;
            this.rdbAllStudent.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbPassStudent
            // 
            this.rdbPassStudent.AutoSize = true;
            this.rdbPassStudent.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPassStudent.Location = new System.Drawing.Point(168, 355);
            this.rdbPassStudent.Name = "rdbPassStudent";
            this.rdbPassStudent.Size = new System.Drawing.Size(141, 34);
            this.rdbPassStudent.TabIndex = 2;
            this.rdbPassStudent.TabStop = true;
            this.rdbPassStudent.Text = "Pass Student";
            this.rdbPassStudent.UseVisualStyleBackColor = true;
            this.rdbPassStudent.CheckedChanged += new System.EventHandler(this.rdbPassStudent_CheckedChanged);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(655, 355);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(134, 34);
            this.btnAddStudent.TabIndex = 3;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.Controls.Add(this.label8);
            this.gbStudentInfo.Controls.Add(this.pbPersonalImage);
            this.gbStudentInfo.Controls.Add(this.lblName);
            this.gbStudentInfo.Controls.Add(this.lblAge);
            this.gbStudentInfo.Controls.Add(this.lblGrade);
            this.gbStudentInfo.Controls.Add(this.label7);
            this.gbStudentInfo.Controls.Add(this.label5);
            this.gbStudentInfo.Controls.Add(this.label2);
            this.gbStudentInfo.Controls.Add(this.lblId);
            this.gbStudentInfo.Controls.Add(this.label1);
            this.gbStudentInfo.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStudentInfo.ForeColor = System.Drawing.Color.Black;
            this.gbStudentInfo.Location = new System.Drawing.Point(12, 136);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Size = new System.Drawing.Size(775, 204);
            this.gbStudentInfo.TabIndex = 4;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "Student Info";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(93, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 30);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "????";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(96, 123);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(49, 30);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "????";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(96, 167);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(49, 30);
            this.lblGrade.TabIndex = 0;
            this.lblGrade.Text = "????";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Grade :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Age :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(96, 38);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 30);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Andalus", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.Red;
            this.lbltitle.Location = new System.Drawing.Point(213, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(318, 48);
            this.lbltitle.TabIndex = 5;
            this.lbltitle.Text = "Student Management";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name :";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(120, 74);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(211, 32);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(103, 648);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(28, 21);
            this.lblRecordsCount.TabIndex = 16;
            this.lblRecordsCount.Text = "??";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 648);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "# Record: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(514, 648);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "# Average Of Students :";
            // 
            // lblAverageOfStudents
            // 
            this.lblAverageOfStudents.AutoSize = true;
            this.lblAverageOfStudents.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageOfStudents.Location = new System.Drawing.Point(735, 648);
            this.lblAverageOfStudents.Name = "lblAverageOfStudents";
            this.lblAverageOfStudents.Size = new System.Drawing.Size(28, 21);
            this.lblAverageOfStudents.TabIndex = 16;
            this.lblAverageOfStudents.Text = "??";
            // 
            // lblSearchStudent
            // 
            this.lblSearchStudent.BackColor = System.Drawing.SystemColors.Control;
            this.lblSearchStudent.Image = global::AtudentApiClient.Properties.Resources.search__1_;
            this.lblSearchStudent.Location = new System.Drawing.Point(375, 60);
            this.lblSearchStudent.Name = "lblSearchStudent";
            this.lblSearchStudent.Size = new System.Drawing.Size(71, 70);
            this.lblSearchStudent.TabIndex = 19;
            this.lblSearchStudent.TabStop = false;
            this.lblSearchStudent.Click += new System.EventHandler(this.lblSearchStudent_Click);
            // 
            // pbPersonalImage
            // 
            this.pbPersonalImage.Image = global::AtudentApiClient.Properties.Resources.icons8_person_100;
            this.pbPersonalImage.Location = new System.Drawing.Point(532, 27);
            this.pbPersonalImage.Name = "pbPersonalImage";
            this.pbPersonalImage.Size = new System.Drawing.Size(219, 126);
            this.pbPersonalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonalImage.TabIndex = 10;
            this.pbPersonalImage.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(574, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 30);
            this.label8.TabIndex = 11;
            this.label8.Text = "Personal Image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 682);
            this.Controls.Add(this.lblSearchStudent);
            this.Controls.Add(this.lblAverageOfStudents);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.gbStudentInfo);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.rdbPassStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbAllStudent);
            this.Controls.Add(this.dgvStudents);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.cmsStudent.ResumeLayout(false);
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblSearchStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.RadioButton rdbAllStudent;
        private System.Windows.Forms.RadioButton rdbPassStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAverageOfStudents;
        private System.Windows.Forms.ContextMenuStrip cmsStudent;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentToolStripMenuItem;
        private System.Windows.Forms.PictureBox lblSearchStudent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbPersonalImage;
    }
}

