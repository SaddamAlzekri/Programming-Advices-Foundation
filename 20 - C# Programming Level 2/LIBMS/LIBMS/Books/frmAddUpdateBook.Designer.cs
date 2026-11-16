namespace LIBMS.Books
{
    partial class frmAddUpdateBook
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbCoverOfBook = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtPublicationYear = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAvailableName = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCategoryName = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.llSetImgee = new System.Windows.Forms.LinkLabel();
            this.llRemoveImage = new System.Windows.Forms.LinkLabel();
            this.ctrlPersonCardWithFilter1 = new LIBMS.People.Controls.ctrlPersonCardWithFilter();
            this.gbBookInfo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoverOfBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbBookInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("LBC", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(286, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(239, 42);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Add Category";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::LIBMS.Properties.Resources.Close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(794, 635);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 52);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::LIBMS.Properties.Resources.diskette__2_;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(927, 635);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 52);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbCoverOfBook
            // 
            this.pbCoverOfBook.Image = global::LIBMS.Properties.Resources.book__1_;
            this.pbCoverOfBook.Location = new System.Drawing.Point(868, 57);
            this.pbCoverOfBook.Name = "pbCoverOfBook";
            this.pbCoverOfBook.Size = new System.Drawing.Size(171, 139);
            this.pbCoverOfBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoverOfBook.TabIndex = 59;
            this.pbCoverOfBook.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 61;
            this.label2.Text = "ISBN :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 21);
            this.label4.TabIndex = 60;
            this.label4.Text = "Publication Year :";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(216, 87);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(211, 28);
            this.txtISBN.TabIndex = 63;
            // 
            // txtPublicationYear
            // 
            this.txtPublicationYear.Location = new System.Drawing.Point(217, 138);
            this.txtPublicationYear.Name = "txtPublicationYear";
            this.txtPublicationYear.Size = new System.Drawing.Size(211, 28);
            this.txtPublicationYear.TabIndex = 62;
            this.txtPublicationYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPublicationYear_KeyPress);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LIBMS.Properties.Resources.contract;
            this.pictureBox4.Location = new System.Drawing.Point(152, 85);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 64;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LIBMS.Properties.Resources.calendar;
            this.pictureBox3.Location = new System.Drawing.Point(153, 136);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 65;
            this.pictureBox3.TabStop = false;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(160, 39);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(34, 21);
            this.lblBookID.TabIndex = 68;
            this.lblBookID.Text = "#ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 21);
            this.label6.TabIndex = 66;
            this.label6.Text = "BookID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(892, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 21);
            this.label7.TabIndex = 67;
            this.label7.Text = "Cover of book";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::LIBMS.Properties.Resources.page_number;
            this.pictureBox5.Location = new System.Drawing.Point(95, 31);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(51, 34);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 69;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::LIBMS.Properties.Resources.page_number;
            this.pictureBox8.Location = new System.Drawing.Point(587, 128);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(51, 34);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 70;
            this.pictureBox8.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 72;
            this.label3.Text = "Title :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 71;
            this.label1.Text = "Category Name :";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(217, 183);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(211, 28);
            this.txtTitle.TabIndex = 74;
            // 
            // txtAvailableName
            // 
            this.txtAvailableName.Location = new System.Drawing.Point(651, 130);
            this.txtAvailableName.Name = "txtAvailableName";
            this.txtAvailableName.Size = new System.Drawing.Size(211, 28);
            this.txtAvailableName.TabIndex = 74;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::LIBMS.Properties.Resources.browser;
            this.pictureBox6.Location = new System.Drawing.Point(153, 181);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(51, 34);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 75;
            this.pictureBox6.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 76;
            this.label5.Text = "Available Copy :";
            // 
            // cbCategoryName
            // 
            this.cbCategoryName.FormattingEnabled = true;
            this.cbCategoryName.Location = new System.Drawing.Point(651, 88);
            this.cbCategoryName.Name = "cbCategoryName";
            this.cbCategoryName.Size = new System.Drawing.Size(211, 29);
            this.cbCategoryName.TabIndex = 77;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LIBMS.Properties.Resources.contract;
            this.pictureBox2.Location = new System.Drawing.Point(588, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 78;
            this.pictureBox2.TabStop = false;
            // 
            // llSetImgee
            // 
            this.llSetImgee.AutoSize = true;
            this.llSetImgee.Location = new System.Drawing.Point(912, 201);
            this.llSetImgee.Name = "llSetImgee";
            this.llSetImgee.Size = new System.Drawing.Size(85, 21);
            this.llSetImgee.TabIndex = 80;
            this.llSetImgee.TabStop = true;
            this.llSetImgee.Text = "Set Image";
            this.llSetImgee.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetImgee_LinkClicked);
            // 
            // llRemoveImage
            // 
            this.llRemoveImage.AutoSize = true;
            this.llRemoveImage.Location = new System.Drawing.Point(940, 881);
            this.llRemoveImage.Name = "llRemoveImage";
            this.llRemoveImage.Size = new System.Drawing.Size(70, 21);
            this.llRemoveImage.TabIndex = 79;
            this.llRemoveImage.TabStop = true;
            this.llRemoveImage.Text = "Remove";
            this.llRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemoveImage_LinkClicked);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Font = new System.Drawing.Font("LBC", 12F);
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(116, -10);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(876, 399);
            this.ctrlPersonCardWithFilter1.TabIndex = 59;
            // 
            // gbBookInfo
            // 
            this.gbBookInfo.Controls.Add(this.txtPublicationYear);
            this.gbBookInfo.Controls.Add(this.label6);
            this.gbBookInfo.Controls.Add(this.llSetImgee);
            this.gbBookInfo.Controls.Add(this.lblBookID);
            this.gbBookInfo.Controls.Add(this.label7);
            this.gbBookInfo.Controls.Add(this.pictureBox2);
            this.gbBookInfo.Controls.Add(this.pictureBox3);
            this.gbBookInfo.Controls.Add(this.pictureBox5);
            this.gbBookInfo.Controls.Add(this.cbCategoryName);
            this.gbBookInfo.Controls.Add(this.pictureBox4);
            this.gbBookInfo.Controls.Add(this.pictureBox8);
            this.gbBookInfo.Controls.Add(this.label5);
            this.gbBookInfo.Controls.Add(this.txtISBN);
            this.gbBookInfo.Controls.Add(this.label3);
            this.gbBookInfo.Controls.Add(this.pictureBox6);
            this.gbBookInfo.Controls.Add(this.label4);
            this.gbBookInfo.Controls.Add(this.label1);
            this.gbBookInfo.Controls.Add(this.txtAvailableName);
            this.gbBookInfo.Controls.Add(this.label2);
            this.gbBookInfo.Controls.Add(this.pbCoverOfBook);
            this.gbBookInfo.Controls.Add(this.txtTitle);
            this.gbBookInfo.Location = new System.Drawing.Point(13, 381);
            this.gbBookInfo.Name = "gbBookInfo";
            this.gbBookInfo.Size = new System.Drawing.Size(1042, 248);
            this.gbBookInfo.TabIndex = 81;
            this.gbBookInfo.TabStop = false;
            this.gbBookInfo.Text = "Book Info";
            // 
            // frmAddUpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1066, 692);
            this.Controls.Add(this.gbBookInfo);
            this.Controls.Add(this.llRemoveImage);
            this.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("LBC", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddUpdateBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddUpdateBook";
            this.Load += new System.EventHandler(this.frmAddUpdateBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCoverOfBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbBookInfo.ResumeLayout(false);
            this.gbBookInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblTitle;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.PictureBox pbCoverOfBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtPublicationYear;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAvailableName;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCategoryName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel llSetImgee;
        private System.Windows.Forms.LinkLabel llRemoveImage;
        private System.Windows.Forms.GroupBox gbBookInfo;
    }
}