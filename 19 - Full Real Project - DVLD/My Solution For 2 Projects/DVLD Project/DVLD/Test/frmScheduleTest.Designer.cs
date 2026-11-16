namespace DVLD.Test
{
    partial class frmScheduleTest
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
            this.crlScheduleTest1 = new DVLD.Test.Controls.crlScheduleTest();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crlScheduleTest1
            // 
            this.crlScheduleTest1.Font = new System.Drawing.Font("LBC", 12F);
            this.crlScheduleTest1.Location = new System.Drawing.Point(3, 5);
            this.crlScheduleTest1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.crlScheduleTest1.Name = "crlScheduleTest1";
            this.crlScheduleTest1.Size = new System.Drawing.Size(533, 699);
            this.crlScheduleTest1.TabIndex = 0;
            this.crlScheduleTest1.TestTypeID = DVLD_Business.clsTestType.enTestType.StreetTest;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::DVLD.Properties.Resources.Close;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(285, 635);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 51);
            this.button1.TabIndex = 18;
            this.button1.Text = "Close";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 697);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.crlScheduleTest1);
            this.Font = new System.Drawing.Font("LBC", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmScheduleTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Test";
            this.Load += new System.EventHandler(this.frmScheduleTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.crlScheduleTest crlScheduleTest1;
        private System.Windows.Forms.Button button1;

    }
}