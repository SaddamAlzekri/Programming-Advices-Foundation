namespace frmPractice
{
    partial class sendMessage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMassege = new System.Windows.Forms.TextBox();
            this.btnMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMassege
            // 
            this.txtMassege.Location = new System.Drawing.Point(79, 25);
            this.txtMassege.Multiline = true;
            this.txtMassege.Name = "txtMassege";
            this.txtMassege.Size = new System.Drawing.Size(158, 27);
            this.txtMassege.TabIndex = 0;
            this.txtMassege.TextChanged += new System.EventHandler(this.txtMassege_TextChanged);
            // 
            // btnMessage
            // 
            this.btnMessage.Font = new System.Drawing.Font("LBC", 14F);
            this.btnMessage.Location = new System.Drawing.Point(116, 83);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(93, 35);
            this.btnMessage.TabIndex = 1;
            this.btnMessage.Text = "Send";
            this.btnMessage.UseVisualStyleBackColor = true;
            // 
            // sendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.txtMassege);
            this.Name = "sendMessage";
            this.Size = new System.Drawing.Size(313, 150);
            this.Load += new System.EventHandler(this.sendMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMassege;
        private System.Windows.Forms.Button btnMessage;
    }
}
