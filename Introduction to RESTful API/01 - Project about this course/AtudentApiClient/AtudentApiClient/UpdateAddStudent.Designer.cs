namespace AtudentApiClient
{
    partial class UpdateAddStudent
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
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.pbPersonalImage = new System.Windows.Forms.PictureBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.llRemoveImage = new System.Windows.Forms.LinkLabel();
            this.llSetImgee = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.Controls.Add(this.llRemoveImage);
            this.gbStudentInfo.Controls.Add(this.llSetImgee);
            this.gbStudentInfo.Controls.Add(this.pbPersonalImage);
            this.gbStudentInfo.Controls.Add(this.lblId);
            this.gbStudentInfo.Controls.Add(this.txtGrade);
            this.gbStudentInfo.Controls.Add(this.txtAge);
            this.gbStudentInfo.Controls.Add(this.txtName);
            this.gbStudentInfo.Controls.Add(this.label7);
            this.gbStudentInfo.Controls.Add(this.label5);
            this.gbStudentInfo.Controls.Add(this.label2);
            this.gbStudentInfo.Controls.Add(this.label1);
            this.gbStudentInfo.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStudentInfo.ForeColor = System.Drawing.Color.Black;
            this.gbStudentInfo.Location = new System.Drawing.Point(12, 70);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Size = new System.Drawing.Size(775, 306);
            this.gbStudentInfo.TabIndex = 5;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "Student Info";
            // 
            // pbPersonalImage
            // 
            this.pbPersonalImage.Image = global::AtudentApiClient.Properties.Resources.icons8_person_100;
            this.pbPersonalImage.Location = new System.Drawing.Point(538, 48);
            this.pbPersonalImage.Name = "pbPersonalImage";
            this.pbPersonalImage.Size = new System.Drawing.Size(219, 126);
            this.pbPersonalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonalImage.TabIndex = 9;
            this.pbPersonalImage.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(85, 80);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 30);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "#";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(90, 240);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(219, 37);
            this.txtGrade.TabIndex = 7;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(90, 183);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(219, 37);
            this.txtAge.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 125);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 37);
            this.txtName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Grade :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Age :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 80);
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
            this.lbltitle.Location = new System.Drawing.Point(288, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(191, 48);
            this.lbltitle.TabIndex = 6;
            this.lbltitle.Text = "Add Student";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(653, 421);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(134, 34);
            this.btnAddStudent.TabIndex = 7;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // llRemoveImage
            // 
            this.llRemoveImage.AutoSize = true;
            this.llRemoveImage.Location = new System.Drawing.Point(616, 212);
            this.llRemoveImage.Name = "llRemoveImage";
            this.llRemoveImage.Size = new System.Drawing.Size(72, 30);
            this.llRemoveImage.TabIndex = 10;
            this.llRemoveImage.TabStop = true;
            this.llRemoveImage.Text = "Remove";
            this.llRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemoveImage_LinkClicked);
            // 
            // llSetImgee
            // 
            this.llSetImgee.AutoSize = true;
            this.llSetImgee.Location = new System.Drawing.Point(609, 183);
            this.llSetImgee.Name = "llSetImgee";
            this.llSetImgee.Size = new System.Drawing.Size(89, 30);
            this.llSetImgee.TabIndex = 11;
            this.llSetImgee.TabStop = true;
            this.llSetImgee.Text = "Set Image";
            this.llSetImgee.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetImgee_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UpdateAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.gbStudentInfo);
            this.Name = "UpdateAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUpdateStudent";
            this.Load += new System.EventHandler(this.UpdateAddStudent_Load);
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.PictureBox pbPersonalImage;
        private System.Windows.Forms.LinkLabel llRemoveImage;
        private System.Windows.Forms.LinkLabel llSetImgee;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}