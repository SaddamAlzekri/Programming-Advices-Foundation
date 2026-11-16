namespace Trafic_light_project
{
    partial class ctrlTraficLight
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
            this.components = new System.ComponentModel.Container();
            this.pbTraficLight = new System.Windows.Forms.PictureBox();
            this.lblCountTrafic = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbTraficLight)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTraficLight
            // 
            this.pbTraficLight.Image = global::Trafic_light_project.Properties.Resources.Red;
            this.pbTraficLight.Location = new System.Drawing.Point(10, 12);
            this.pbTraficLight.Name = "pbTraficLight";
            this.pbTraficLight.Size = new System.Drawing.Size(100, 160);
            this.pbTraficLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTraficLight.TabIndex = 0;
            this.pbTraficLight.TabStop = false;
            // 
            // lblCountTrafic
            // 
            this.lblCountTrafic.AutoSize = true;
            this.lblCountTrafic.BackColor = System.Drawing.SystemColors.Control;
            this.lblCountTrafic.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblCountTrafic.ForeColor = System.Drawing.Color.Red;
            this.lblCountTrafic.Location = new System.Drawing.Point(40, 180);
            this.lblCountTrafic.Name = "lblCountTrafic";
            this.lblCountTrafic.Size = new System.Drawing.Size(37, 23);
            this.lblCountTrafic.TabIndex = 1;
            this.lblCountTrafic.Text = "???";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // ctrlTraficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCountTrafic);
            this.Controls.Add(this.pbTraficLight);
            this.Name = "ctrlTraficLight";
            this.Size = new System.Drawing.Size(120, 212);
            ((System.ComponentModel.ISupportInitialize)(this.pbTraficLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTraficLight;
        private System.Windows.Forms.Label lblCountTrafic;
        private System.Windows.Forms.Timer timer1;
    }
}
