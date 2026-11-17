namespace Rgb_Color
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
            this.lblSetCol = new System.Windows.Forms.Label();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSetCol
            // 
            this.lblSetCol.AutoSize = true;
            this.lblSetCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetCol.ForeColor = System.Drawing.Color.Blue;
            this.lblSetCol.Location = new System.Drawing.Point(384, 22);
            this.lblSetCol.Name = "lblSetCol";
            this.lblSetCol.Size = new System.Drawing.Size(253, 38);
            this.lblSetCol.TabIndex = 0;
            this.lblSetCol.Text = "Set Rgp Colors";
            // 
            // pbColor
            // 
            this.pbColor.Location = new System.Drawing.Point(811, 64);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(231, 141);
            this.pbColor.TabIndex = 1;
            this.pbColor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(873, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Color :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "A: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "R: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(36, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "G: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(36, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "B: ";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(69, 232);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(973, 56);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 10;
            this.trackBar2.Location = new System.Drawing.Point(69, 322);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(973, 56);
            this.trackBar2.SmallChange = 5;
            this.trackBar2.TabIndex = 8;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.LargeChange = 10;
            this.trackBar3.Location = new System.Drawing.Point(69, 402);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(973, 56);
            this.trackBar3.SmallChange = 5;
            this.trackBar3.TabIndex = 9;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar4
            // 
            this.trackBar4.LargeChange = 10;
            this.trackBar4.Location = new System.Drawing.Point(69, 493);
            this.trackBar4.Maximum = 255;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(973, 56);
            this.trackBar4.SmallChange = 5;
            this.trackBar4.TabIndex = 10;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "B: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(417, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "G: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(213, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "R: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(213, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 29);
            this.label9.TabIndex = 11;
            this.label9.Text = "A: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(466, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(259, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(259, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(464, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 25);
            this.label13.TabIndex = 18;
            this.label13.Text = "0";
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(585, 130);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(135, 45);
            this.btnCopy.TabIndex = 19;
            this.btnCopy.Text = "Copy Color";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 583);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbColor);
            this.Controls.Add(this.lblSetCol);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Rgb Colors";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSetCol;
        private System.Windows.Forms.PictureBox pbColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCopy;
    }
}

