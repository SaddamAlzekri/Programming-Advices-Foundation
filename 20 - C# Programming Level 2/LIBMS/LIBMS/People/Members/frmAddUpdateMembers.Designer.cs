namespace LIBMS.People.Members
{
    partial class frmAddUpdateMembers
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
            this.tcMemberlog = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.ctrlPersonCardWithFilter1 = new LIBMS.People.Controls.ctrlPersonCardWithFilter();
            this.btnPersonInfoNext = new System.Windows.Forms.Button();
            this.tcMemberInfo = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbPremium = new System.Windows.Forms.RadioButton();
            this.rdbGold = new System.Windows.Forms.RadioButton();
            this.rdbBasic = new System.Windows.Forms.RadioButton();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.tcMemberlog.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tcMemberInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMemberlog
            // 
            this.tcMemberlog.Controls.Add(this.tpPersonInfo);
            this.tcMemberlog.Controls.Add(this.tcMemberInfo);
            this.tcMemberlog.Location = new System.Drawing.Point(8, 85);
            this.tcMemberlog.Name = "tcMemberlog";
            this.tcMemberlog.SelectedIndex = 0;
            this.tcMemberlog.Size = new System.Drawing.Size(910, 493);
            this.tcMemberlog.TabIndex = 16;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tpPersonInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tpPersonInfo.Controls.Add(this.btnPersonInfoNext);
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 30);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(902, 459);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person Info";
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Font = new System.Drawing.Font("LBC", 12F);
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(16, 8);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(879, 399);
            this.ctrlPersonCardWithFilter1.TabIndex = 7;
            // 
            // btnPersonInfoNext
            // 
            this.btnPersonInfoNext.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonInfoNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonInfoNext.Location = new System.Drawing.Point(753, 408);
            this.btnPersonInfoNext.Name = "btnPersonInfoNext";
            this.btnPersonInfoNext.Size = new System.Drawing.Size(127, 45);
            this.btnPersonInfoNext.TabIndex = 6;
            this.btnPersonInfoNext.Text = "Next---->";
            this.btnPersonInfoNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonInfoNext.UseVisualStyleBackColor = true;
            this.btnPersonInfoNext.Click += new System.EventHandler(this.btnPersonInfoNext_Click);
            // 
            // tcMemberInfo
            // 
            this.tcMemberInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tcMemberInfo.Controls.Add(this.button1);
            this.tcMemberInfo.Controls.Add(this.dtpStartDate);
            this.tcMemberInfo.Controls.Add(this.dtpEndDate);
            this.tcMemberInfo.Controls.Add(this.label3);
            this.tcMemberInfo.Controls.Add(this.label1);
            this.tcMemberInfo.Controls.Add(this.label2);
            this.tcMemberInfo.Controls.Add(this.rdbPremium);
            this.tcMemberInfo.Controls.Add(this.rdbGold);
            this.tcMemberInfo.Controls.Add(this.rdbBasic);
            this.tcMemberInfo.Controls.Add(this.chkIsActive);
            this.tcMemberInfo.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMemberInfo.Location = new System.Drawing.Point(4, 30);
            this.tcMemberInfo.Name = "tcMemberInfo";
            this.tcMemberInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tcMemberInfo.Size = new System.Drawing.Size(902, 459);
            this.tcMemberInfo.TabIndex = 1;
            this.tcMemberInfo.Text = "Member Info";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(753, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 45);
            this.button1.TabIndex = 17;
            this.button1.Text = "<---- Return";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(139, 150);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 32);
            this.dtpStartDate.TabIndex = 16;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(489, 150);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 32);
            this.dtpEndDate.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(18, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Start Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(380, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "End Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Choose One of the following Package :";
            // 
            // rdbPremium
            // 
            this.rdbPremium.AutoSize = true;
            this.rdbPremium.Location = new System.Drawing.Point(234, 86);
            this.rdbPremium.Name = "rdbPremium";
            this.rdbPremium.Size = new System.Drawing.Size(113, 29);
            this.rdbPremium.TabIndex = 12;
            this.rdbPremium.TabStop = true;
            this.rdbPremium.Text = "Premium";
            this.rdbPremium.UseVisualStyleBackColor = true;
            this.rdbPremium.CheckedChanged += new System.EventHandler(this.rdbPremium_CheckedChanged);
            // 
            // rdbGold
            // 
            this.rdbGold.AutoSize = true;
            this.rdbGold.Location = new System.Drawing.Point(481, 86);
            this.rdbGold.Name = "rdbGold";
            this.rdbGold.Size = new System.Drawing.Size(74, 29);
            this.rdbGold.TabIndex = 12;
            this.rdbGold.TabStop = true;
            this.rdbGold.Text = "Gold";
            this.rdbGold.UseVisualStyleBackColor = true;
            this.rdbGold.CheckedChanged += new System.EventHandler(this.rdbGold_CheckedChanged);
            // 
            // rdbBasic
            // 
            this.rdbBasic.AutoSize = true;
            this.rdbBasic.Location = new System.Drawing.Point(18, 86);
            this.rdbBasic.Name = "rdbBasic";
            this.rdbBasic.Size = new System.Drawing.Size(82, 29);
            this.rdbBasic.TabIndex = 13;
            this.rdbBasic.TabStop = true;
            this.rdbBasic.Text = "Basic";
            this.rdbBasic.UseVisualStyleBackColor = true;
            this.rdbBasic.CheckedChanged += new System.EventHandler(this.rdbBasic_CheckedChanged);
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(18, 209);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(115, 29);
            this.chkIsActive.TabIndex = 11;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("LBC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(316, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(292, 35);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Edit Application Type";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::LIBMS.Properties.Resources.diskette__2_;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(790, 584);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 52);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::LIBMS.Properties.Resources.Close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(657, 584);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 52);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddUpdateMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(927, 653);
            this.Controls.Add(this.tcMemberlog);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("LBC", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddUpdateMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddUpdateMembers";
            this.Load += new System.EventHandler(this.frmAddUpdateMembers_Load);
            this.tcMemberlog.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.tcMemberInfo.ResumeLayout(false);
            this.tcMemberInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMemberlog;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Button btnPersonInfoNext;
        private System.Windows.Forms.TabPage tcMemberInfo;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbPremium;
        private System.Windows.Forms.RadioButton rdbGold;
        private System.Windows.Forms.RadioButton rdbBasic;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
    }
}