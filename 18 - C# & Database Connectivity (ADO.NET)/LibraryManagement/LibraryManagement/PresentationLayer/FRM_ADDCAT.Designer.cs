namespace LibraryManagement.PresentationLayer
{
    partial class FRM_ADDCAT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADDCAT));
            this.lblTitle = new System.Windows.Forms.Label();
            this.bmtxtCategoryName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BnfImgBtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.BnfImgBtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("LBC", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(115, 63);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(341, 85);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "اسم الصنف";
            // 
            // bmtxtCategoryName
            // 
            this.bmtxtCategoryName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bmtxtCategoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmtxtCategoryName.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmtxtCategoryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmtxtCategoryName.HintForeColor = System.Drawing.Color.Empty;
            this.bmtxtCategoryName.HintText = "اسم الصنف";
            this.bmtxtCategoryName.isPassword = false;
            this.bmtxtCategoryName.LineFocusedColor = System.Drawing.Color.Blue;
            this.bmtxtCategoryName.LineIdleColor = System.Drawing.Color.Gray;
            this.bmtxtCategoryName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bmtxtCategoryName.LineThickness = 5;
            this.bmtxtCategoryName.Location = new System.Drawing.Point(43, 165);
            this.bmtxtCategoryName.Margin = new System.Windows.Forms.Padding(4);
            this.bmtxtCategoryName.Name = "bmtxtCategoryName";
            this.bmtxtCategoryName.Size = new System.Drawing.Size(495, 41);
            this.bmtxtCategoryName.TabIndex = 3;
            this.bmtxtCategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Teal;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "اضافة";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("LBC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(63, 283);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(451, 44);
            this.bunifuThinButton21.TabIndex = 4;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // BnfImgBtnClose
            // 
            this.BnfImgBtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BnfImgBtnClose.Image = global::LibraryManagement.Properties.Resources.Close;
            this.BnfImgBtnClose.ImageActive = null;
            this.BnfImgBtnClose.Location = new System.Drawing.Point(6, 6);
            this.BnfImgBtnClose.Margin = new System.Windows.Forms.Padding(2);
            this.BnfImgBtnClose.Name = "BnfImgBtnClose";
            this.BnfImgBtnClose.Size = new System.Drawing.Size(39, 29);
            this.BnfImgBtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BnfImgBtnClose.TabIndex = 1;
            this.BnfImgBtnClose.TabStop = false;
            this.BnfImgBtnClose.Zoom = 10;
            this.BnfImgBtnClose.Click += new System.EventHandler(this.BnfImgBtnClose_Click);
            // 
            // FRM_ADDCAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(568, 373);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.bmtxtCategoryName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.BnfImgBtnClose);
            this.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FRM_ADDCAT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_ADDCAT";
            ((System.ComponentModel.ISupportInitialize)(this.BnfImgBtnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton BnfImgBtnClose;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox bmtxtCategoryName;
        public Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}