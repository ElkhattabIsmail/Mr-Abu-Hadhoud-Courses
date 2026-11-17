namespace Traffic_Light_Project_C20
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrlTraficLight_Horizonatl_West = new Traffic_Light_Project_C20.CtrlTraficLight();
            this.ctrlTraficLight_Horizonatl_East = new Traffic_Light_Project_C20.CtrlTraficLight();
            this.ctrlTraficLight_Vertical_North = new Traffic_Light_Project_C20.CtrlTraficLight();
            this.ctrlTraficLight_Vertical_South = new Traffic_Light_Project_C20.CtrlTraficLight();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(193, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "For Vertical Road ->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(678, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "<- For Vertical Road";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(201, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Horizontal Road ->";
            // 
            // ctrlTraficLight_Horizonatl_West
            // 
            this.ctrlTraficLight_Horizonatl_West.CurrentTraficColor = Traffic_Light_Project_C20.CtrlTraficLight.enTraficLightColors.Green;
            this.ctrlTraficLight_Horizonatl_West.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.ctrlTraficLight_Horizonatl_West.GreenTime = 7;
            this.ctrlTraficLight_Horizonatl_West.Location = new System.Drawing.Point(582, 522);
            this.ctrlTraficLight_Horizonatl_West.Name = "ctrlTraficLight_Horizonatl_West";
            this.ctrlTraficLight_Horizonatl_West.OrangeTime = 5;
            this.ctrlTraficLight_Horizonatl_West.RedTime = 7;
            this.ctrlTraficLight_Horizonatl_West.Size = new System.Drawing.Size(61, 138);
            this.ctrlTraficLight_Horizonatl_West.TabIndex = 3;
            // 
            // ctrlTraficLight_Horizonatl_East
            // 
            this.ctrlTraficLight_Horizonatl_East.CurrentTraficColor = Traffic_Light_Project_C20.CtrlTraficLight.enTraficLightColors.Green;
            this.ctrlTraficLight_Horizonatl_East.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.ctrlTraficLight_Horizonatl_East.GreenTime = 7;
            this.ctrlTraficLight_Horizonatl_East.Location = new System.Drawing.Point(413, 287);
            this.ctrlTraficLight_Horizonatl_East.Name = "ctrlTraficLight_Horizonatl_East";
            this.ctrlTraficLight_Horizonatl_East.OrangeTime = 5;
            this.ctrlTraficLight_Horizonatl_East.RedTime = 7;
            this.ctrlTraficLight_Horizonatl_East.Size = new System.Drawing.Size(61, 138);
            this.ctrlTraficLight_Horizonatl_East.TabIndex = 2;
            // 
            // ctrlTraficLight_Vertical_North
            // 
            this.ctrlTraficLight_Vertical_North.CurrentTraficColor = Traffic_Light_Project_C20.CtrlTraficLight.enTraficLightColors.Red;
            this.ctrlTraficLight_Vertical_North.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.ctrlTraficLight_Vertical_North.GreenTime = 5;
            this.ctrlTraficLight_Vertical_North.Location = new System.Drawing.Point(582, 287);
            this.ctrlTraficLight_Vertical_North.Name = "ctrlTraficLight_Vertical_North";
            this.ctrlTraficLight_Vertical_North.OrangeTime = 3;
            this.ctrlTraficLight_Vertical_North.RedTime = 10;
            this.ctrlTraficLight_Vertical_North.Size = new System.Drawing.Size(61, 138);
            this.ctrlTraficLight_Vertical_North.TabIndex = 1;
            // 
            // ctrlTraficLight_Vertical_South
            // 
            this.ctrlTraficLight_Vertical_South.CurrentTraficColor = Traffic_Light_Project_C20.CtrlTraficLight.enTraficLightColors.Red;
            this.ctrlTraficLight_Vertical_South.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.ctrlTraficLight_Vertical_South.GreenTime = 5;
            this.ctrlTraficLight_Vertical_South.Location = new System.Drawing.Point(413, 522);
            this.ctrlTraficLight_Vertical_South.Name = "ctrlTraficLight_Vertical_South";
            this.ctrlTraficLight_Vertical_South.OrangeTime = 3;
            this.ctrlTraficLight_Vertical_South.RedTime = 10;
            this.ctrlTraficLight_Vertical_South.Size = new System.Drawing.Size(61, 138);
            this.ctrlTraficLight_Vertical_South.TabIndex = 0;
            this.ctrlTraficLight_Vertical_South.RedLightOn += new System.EventHandler<Traffic_Light_Project_C20.CtrlTraficLight.TraficLightEventArgs>(this.ctrlTraficLight_Vertical_South_RedLightOn);
            this.ctrlTraficLight_Vertical_South.OrangeLightOn += new System.EventHandler<Traffic_Light_Project_C20.CtrlTraficLight.TraficLightEventArgs>(this.ctrlTraficLight_Vertical_South_OrangeLightOn);
            this.ctrlTraficLight_Vertical_South.GreenLightOn += new System.EventHandler<Traffic_Light_Project_C20.CtrlTraficLight.TraficLightEventArgs>(this.ctrlTraficLight_Vertical_South_GreenLightOn);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(678, 581);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "<- Horizontal Road";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 771);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlTraficLight_Horizonatl_West);
            this.Controls.Add(this.ctrlTraficLight_Horizonatl_East);
            this.Controls.Add(this.ctrlTraficLight_Vertical_North);
            this.Controls.Add(this.ctrlTraficLight_Vertical_South);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CtrlTraficLight ctrlTraficLight_Vertical_South;
        private CtrlTraficLight ctrlTraficLight_Vertical_North;
        private CtrlTraficLight ctrlTraficLight_Horizonatl_East;
        private CtrlTraficLight ctrlTraficLight_Horizonatl_West;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

