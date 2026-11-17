namespace Traffic_Light_Project_C20
{
    partial class CtrlTraficLight
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
            this.lblCountDown = new System.Windows.Forms.Label();
            this.pbTraficLight = new System.Windows.Forms.PictureBox();
            this.LightTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbTraficLight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCountDown
            // 
            this.lblCountDown.AutoSize = true;
            this.lblCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.Location = new System.Drawing.Point(17, 118);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(43, 22);
            this.lblCountDown.TabIndex = 1;
            this.lblCountDown.Text = "???";
            // 
            // pbTraficLight
            // 
            this.pbTraficLight.Image = global::Traffic_Light_Project_C20.Properties.Resources.Green;
            this.pbTraficLight.Location = new System.Drawing.Point(3, 3);
            this.pbTraficLight.Name = "pbTraficLight";
            this.pbTraficLight.Size = new System.Drawing.Size(61, 112);
            this.pbTraficLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTraficLight.TabIndex = 0;
            this.pbTraficLight.TabStop = false;
            // 
            // LightTimer
            // 
            this.LightTimer.Interval = 1000;
            this.LightTimer.Tick += new System.EventHandler(this.LightTimer_Tick_1);
            // 
            // CtrlTraficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.pbTraficLight);
            this.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.Name = "CtrlTraficLight";
            this.Size = new System.Drawing.Size(68, 149);
            ((System.ComponentModel.ISupportInitialize)(this.pbTraficLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTraficLight;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Timer LightTimer;
    }
}
