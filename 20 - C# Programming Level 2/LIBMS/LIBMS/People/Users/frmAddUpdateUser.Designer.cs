namespace LIBMS.People.Users.Controls
{
    partial class frmAddUpdateUser
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tpLoginInfoAndPermission = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkRoomResevation = new System.Windows.Forms.CheckBox();
            this.chkRooms = new System.Windows.Forms.CheckBox();
            this.chkSalesAndReturns = new System.Windows.Forms.CheckBox();
            this.chkCategoriesAndBooks = new System.Windows.Forms.CheckBox();
            this.chkBorrowingRecords = new System.Windows.Forms.CheckBox();
            this.chkMembers = new System.Windows.Forms.CheckBox();
            this.chkLibraryAccessLog = new System.Windows.Forms.CheckBox();
            this.chkUsers = new System.Windows.Forms.CheckBox();
            this.chkReadingSession = new System.Windows.Forms.CheckBox();
            this.chkPeople = new System.Windows.Forms.CheckBox();
            this.rdbUser = new System.Windows.Forms.RadioButton();
            this.rdbManager = new System.Windows.Forms.RadioButton();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.ctrlPersonCardWithFilter1 = new LIBMS.People.Controls.ctrlPersonCardWithFilter();
            this.btnPersonInfoNext = new System.Windows.Forms.Button();
            this.tcUserInfo = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpLoginInfoAndPermission.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tpPersonInfo.SuspendLayout();
            this.tcUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("LBC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(313, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(292, 35);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Edit Application Type";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::LIBMS.Properties.Resources.diskette__2_;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(787, 590);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 52);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::LIBMS.Properties.Resources.Close;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(654, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 52);
            this.button1.TabIndex = 13;
            this.button1.Text = "Close";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tpLoginInfoAndPermission
            // 
            this.tpLoginInfoAndPermission.BackColor = System.Drawing.SystemColors.Control;
            this.tpLoginInfoAndPermission.Controls.Add(this.label2);
            this.tpLoginInfoAndPermission.Controls.Add(this.groupBox1);
            this.tpLoginInfoAndPermission.Controls.Add(this.rdbUser);
            this.tpLoginInfoAndPermission.Controls.Add(this.rdbManager);
            this.tpLoginInfoAndPermission.Controls.Add(this.chkIsActive);
            this.tpLoginInfoAndPermission.Controls.Add(this.txtConfirmPassword);
            this.tpLoginInfoAndPermission.Controls.Add(this.txtPassword);
            this.tpLoginInfoAndPermission.Controls.Add(this.txtUserName);
            this.tpLoginInfoAndPermission.Controls.Add(this.pictureBox4);
            this.tpLoginInfoAndPermission.Controls.Add(this.pictureBox3);
            this.tpLoginInfoAndPermission.Controls.Add(this.pictureBox1);
            this.tpLoginInfoAndPermission.Controls.Add(this.label9);
            this.tpLoginInfoAndPermission.Controls.Add(this.label7);
            this.tpLoginInfoAndPermission.Controls.Add(this.pictureBox2);
            this.tpLoginInfoAndPermission.Controls.Add(this.label5);
            this.tpLoginInfoAndPermission.Controls.Add(this.lblUserID);
            this.tpLoginInfoAndPermission.Controls.Add(this.label3);
            this.tpLoginInfoAndPermission.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpLoginInfoAndPermission.Location = new System.Drawing.Point(4, 30);
            this.tpLoginInfoAndPermission.Name = "tpLoginInfoAndPermission";
            this.tpLoginInfoAndPermission.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoginInfoAndPermission.Size = new System.Drawing.Size(902, 459);
            this.tpLoginInfoAndPermission.TabIndex = 1;
            this.tpLoginInfoAndPermission.Text = "Login Info & Permissions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(11, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Define user permission.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkRoomResevation);
            this.groupBox1.Controls.Add(this.chkRooms);
            this.groupBox1.Controls.Add(this.chkSalesAndReturns);
            this.groupBox1.Controls.Add(this.chkCategoriesAndBooks);
            this.groupBox1.Controls.Add(this.chkBorrowingRecords);
            this.groupBox1.Controls.Add(this.chkMembers);
            this.groupBox1.Controls.Add(this.chkLibraryAccessLog);
            this.groupBox1.Controls.Add(this.chkUsers);
            this.groupBox1.Controls.Add(this.chkReadingSession);
            this.groupBox1.Controls.Add(this.chkPeople);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(9, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 128);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissions";
            // 
            // chkRoomResevation
            // 
            this.chkRoomResevation.AutoSize = true;
            this.chkRoomResevation.ForeColor = System.Drawing.Color.Black;
            this.chkRoomResevation.Location = new System.Drawing.Point(437, 59);
            this.chkRoomResevation.Name = "chkRoomResevation";
            this.chkRoomResevation.Size = new System.Drawing.Size(205, 29);
            this.chkRoomResevation.TabIndex = 3;
            this.chkRoomResevation.Text = "Room Reservation";
            this.chkRoomResevation.UseVisualStyleBackColor = true;
            // 
            // chkRooms
            // 
            this.chkRooms.AutoSize = true;
            this.chkRooms.ForeColor = System.Drawing.Color.Black;
            this.chkRooms.Location = new System.Drawing.Point(695, 25);
            this.chkRooms.Name = "chkRooms";
            this.chkRooms.Size = new System.Drawing.Size(96, 29);
            this.chkRooms.TabIndex = 3;
            this.chkRooms.Text = "Rooms";
            this.chkRooms.UseVisualStyleBackColor = true;
            // 
            // chkSalesAndReturns
            // 
            this.chkSalesAndReturns.AutoSize = true;
            this.chkSalesAndReturns.ForeColor = System.Drawing.Color.Black;
            this.chkSalesAndReturns.Location = new System.Drawing.Point(286, 94);
            this.chkSalesAndReturns.Name = "chkSalesAndReturns";
            this.chkSalesAndReturns.Size = new System.Drawing.Size(182, 29);
            this.chkSalesAndReturns.TabIndex = 3;
            this.chkSalesAndReturns.Text = "Sales && Returns";
            this.chkSalesAndReturns.UseVisualStyleBackColor = true;
            // 
            // chkCategoriesAndBooks
            // 
            this.chkCategoriesAndBooks.AutoSize = true;
            this.chkCategoriesAndBooks.ForeColor = System.Drawing.Color.Black;
            this.chkCategoriesAndBooks.Location = new System.Drawing.Point(437, 25);
            this.chkCategoriesAndBooks.Name = "chkCategoriesAndBooks";
            this.chkCategoriesAndBooks.Size = new System.Drawing.Size(218, 29);
            this.chkCategoriesAndBooks.TabIndex = 3;
            this.chkCategoriesAndBooks.Text = "Categories && Books";
            this.chkCategoriesAndBooks.UseVisualStyleBackColor = true;
            // 
            // chkBorrowingRecords
            // 
            this.chkBorrowingRecords.AutoSize = true;
            this.chkBorrowingRecords.ForeColor = System.Drawing.Color.Black;
            this.chkBorrowingRecords.Location = new System.Drawing.Point(6, 59);
            this.chkBorrowingRecords.Name = "chkBorrowingRecords";
            this.chkBorrowingRecords.Size = new System.Drawing.Size(211, 29);
            this.chkBorrowingRecords.TabIndex = 2;
            this.chkBorrowingRecords.Text = "Borrowing Records";
            this.chkBorrowingRecords.UseVisualStyleBackColor = true;
            // 
            // chkMembers
            // 
            this.chkMembers.AutoSize = true;
            this.chkMembers.ForeColor = System.Drawing.Color.Black;
            this.chkMembers.Location = new System.Drawing.Point(286, 59);
            this.chkMembers.Name = "chkMembers";
            this.chkMembers.Size = new System.Drawing.Size(120, 29);
            this.chkMembers.TabIndex = 2;
            this.chkMembers.Text = "Members";
            this.chkMembers.UseVisualStyleBackColor = true;
            // 
            // chkLibraryAccessLog
            // 
            this.chkLibraryAccessLog.AutoSize = true;
            this.chkLibraryAccessLog.ForeColor = System.Drawing.Color.Black;
            this.chkLibraryAccessLog.Location = new System.Drawing.Point(6, 94);
            this.chkLibraryAccessLog.Name = "chkLibraryAccessLog";
            this.chkLibraryAccessLog.Size = new System.Drawing.Size(216, 29);
            this.chkLibraryAccessLog.TabIndex = 1;
            this.chkLibraryAccessLog.Text = "Library Access Log";
            this.chkLibraryAccessLog.UseVisualStyleBackColor = true;
            // 
            // chkUsers
            // 
            this.chkUsers.AutoSize = true;
            this.chkUsers.ForeColor = System.Drawing.Color.Black;
            this.chkUsers.Location = new System.Drawing.Point(695, 59);
            this.chkUsers.Name = "chkUsers";
            this.chkUsers.Size = new System.Drawing.Size(87, 29);
            this.chkUsers.TabIndex = 1;
            this.chkUsers.Text = "Users";
            this.chkUsers.UseVisualStyleBackColor = true;
            // 
            // chkReadingSession
            // 
            this.chkReadingSession.AutoSize = true;
            this.chkReadingSession.ForeColor = System.Drawing.Color.Black;
            this.chkReadingSession.Location = new System.Drawing.Point(6, 24);
            this.chkReadingSession.Name = "chkReadingSession";
            this.chkReadingSession.Size = new System.Drawing.Size(189, 29);
            this.chkReadingSession.TabIndex = 0;
            this.chkReadingSession.Text = "Reading Session";
            this.chkReadingSession.UseVisualStyleBackColor = true;
            // 
            // chkPeople
            // 
            this.chkPeople.AutoSize = true;
            this.chkPeople.ForeColor = System.Drawing.Color.Black;
            this.chkPeople.Location = new System.Drawing.Point(286, 24);
            this.chkPeople.Name = "chkPeople";
            this.chkPeople.Size = new System.Drawing.Size(96, 29);
            this.chkPeople.TabIndex = 0;
            this.chkPeople.Text = "People";
            this.chkPeople.UseVisualStyleBackColor = true;
            // 
            // rdbUser
            // 
            this.rdbUser.AutoSize = true;
            this.rdbUser.Location = new System.Drawing.Point(301, 278);
            this.rdbUser.Name = "rdbUser";
            this.rdbUser.Size = new System.Drawing.Size(75, 29);
            this.rdbUser.TabIndex = 12;
            this.rdbUser.TabStop = true;
            this.rdbUser.Text = "User";
            this.rdbUser.UseVisualStyleBackColor = true;
            this.rdbUser.CheckedChanged += new System.EventHandler(this.rdbUser_CheckedChanged);
            // 
            // rdbManager
            // 
            this.rdbManager.AutoSize = true;
            this.rdbManager.Location = new System.Drawing.Point(9, 278);
            this.rdbManager.Name = "rdbManager";
            this.rdbManager.Size = new System.Drawing.Size(113, 29);
            this.rdbManager.TabIndex = 13;
            this.rdbManager.TabStop = true;
            this.rdbManager.Text = "Manager";
            this.rdbManager.UseVisualStyleBackColor = true;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(268, 199);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(115, 29);
            this.chkIsActive.TabIndex = 11;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(268, 145);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(162, 32);
            this.txtConfirmPassword.TabIndex = 10;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(268, 97);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(162, 32);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(268, 53);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(162, 32);
            this.txtUserName.TabIndex = 10;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LIBMS.Properties.Resources.at_sign;
            this.pictureBox4.Location = new System.Drawing.Point(199, 141);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LIBMS.Properties.Resources.Customer;
            this.pictureBox3.Location = new System.Drawing.Point(199, 97);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LIBMS.Properties.Resources.page_number;
            this.pictureBox1.Location = new System.Drawing.Point(199, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Confirm Password: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Password: ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LIBMS.Properties.Resources.icons8_person_48;
            this.pictureBox2.Location = new System.Drawing.Point(199, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "UserName: ";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(269, 22);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(45, 25);
            this.lblUserID.TabIndex = 5;
            this.lblUserID.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "UserId :";
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
            // tcUserInfo
            // 
            this.tcUserInfo.Controls.Add(this.tpPersonInfo);
            this.tcUserInfo.Controls.Add(this.tpLoginInfoAndPermission);
            this.tcUserInfo.Location = new System.Drawing.Point(5, 91);
            this.tcUserInfo.Name = "tcUserInfo";
            this.tcUserInfo.SelectedIndex = 0;
            this.tcUserInfo.Size = new System.Drawing.Size(910, 493);
            this.tcUserInfo.TabIndex = 12;
            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 653);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tcUserInfo);
            this.Font = new System.Drawing.Font("LBC", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddUpdateUser";
            this.Activated += new System.EventHandler(this.frmAddUpdateUser_Activated);
            this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpLoginInfoAndPermission.ResumeLayout(false);
            this.tpLoginInfoAndPermission.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tpPersonInfo.ResumeLayout(false);
            this.tcUserInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tcUserInfo;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Button btnPersonInfoNext;
        private System.Windows.Forms.TabPage tpLoginInfoAndPermission;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkRoomResevation;
        private System.Windows.Forms.CheckBox chkRooms;
        private System.Windows.Forms.CheckBox chkSalesAndReturns;
        private System.Windows.Forms.CheckBox chkCategoriesAndBooks;
        private System.Windows.Forms.CheckBox chkBorrowingRecords;
        private System.Windows.Forms.CheckBox chkMembers;
        private System.Windows.Forms.CheckBox chkLibraryAccessLog;
        private System.Windows.Forms.CheckBox chkUsers;
        private System.Windows.Forms.CheckBox chkReadingSession;
        private System.Windows.Forms.CheckBox chkPeople;
        private System.Windows.Forms.RadioButton rdbUser;
        private System.Windows.Forms.RadioButton rdbManager;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label3;
    }
}