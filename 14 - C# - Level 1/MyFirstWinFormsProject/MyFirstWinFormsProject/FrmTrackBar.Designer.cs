namespace MyFirstWinFormsProject
{
    partial class FrmTrackBar
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblTrackBar = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.lblMixedColors = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTrackBar2 = new System.Windows.Forms.Label();
            this.lblTrackBar4 = new System.Windows.Forms.Label();
            this.lblTrackBar3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(37, 85);
            this.trackBar1.Maximum = 500;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(343, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblTrackBar
            // 
            this.lblTrackBar.AutoSize = true;
            this.lblTrackBar.Location = new System.Drawing.Point(184, 60);
            this.lblTrackBar.Name = "lblTrackBar";
            this.lblTrackBar.Size = new System.Drawing.Size(19, 13);
            this.lblTrackBar.TabIndex = 1;
            this.lblTrackBar.Text = " 0 ";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(461, 84);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(343, 45);
            this.trackBar2.TabIndex = 2;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(461, 148);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(343, 45);
            this.trackBar3.TabIndex = 3;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(461, 227);
            this.trackBar4.Maximum = 255;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(343, 45);
            this.trackBar4.TabIndex = 4;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // lblMixedColors
            // 
            this.lblMixedColors.Location = new System.Drawing.Point(520, 331);
            this.lblMixedColors.Name = "lblMixedColors";
            this.lblMixedColors.Size = new System.Drawing.Size(200, 50);
            this.lblMixedColors.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(560, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mixed Colors";
            // 
            // lblTrackBar2
            // 
            this.lblTrackBar2.Location = new System.Drawing.Point(414, 88);
            this.lblTrackBar2.Name = "lblTrackBar2";
            this.lblTrackBar2.Size = new System.Drawing.Size(40, 20);
            this.lblTrackBar2.TabIndex = 7;
            this.lblTrackBar2.Text = " 0 ";
            this.lblTrackBar2.Click += new System.EventHandler(this.lblTrackBar2_Click);
            // 
            // lblTrackBar4
            // 
            this.lblTrackBar4.Location = new System.Drawing.Point(414, 238);
            this.lblTrackBar4.Name = "lblTrackBar4";
            this.lblTrackBar4.Size = new System.Drawing.Size(40, 20);
            this.lblTrackBar4.TabIndex = 8;
            this.lblTrackBar4.Text = " 0 ";
            // 
            // lblTrackBar3
            // 
            this.lblTrackBar3.Location = new System.Drawing.Point(414, 155);
            this.lblTrackBar3.Name = "lblTrackBar3";
            this.lblTrackBar3.Size = new System.Drawing.Size(40, 20);
            this.lblTrackBar3.TabIndex = 9;
            this.lblTrackBar3.Text = " 0 ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyFirstWinFormsProject.Properties.Resources.Boy;
            this.pictureBox1.Location = new System.Drawing.Point(56, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(508, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Change Background of image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(120, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "change Size of image";
            // 
            // FrmTrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 438);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTrackBar3);
            this.Controls.Add(this.lblTrackBar4);
            this.Controls.Add(this.lblTrackBar2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMixedColors);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.lblTrackBar);
            this.Controls.Add(this.trackBar1);
            this.Name = "FrmTrackBar";
            this.Text = "FrmTrackBar";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblTrackBar;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label lblMixedColors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTrackBar2;
        private System.Windows.Forms.Label lblTrackBar4;
        private System.Windows.Forms.Label lblTrackBar3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}