namespace Build_Your_Own_Control
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
            this.simpleCalculator1 = new Build_Your_Own_Control.SimpleCalculator();
            this.simpleCalculator2 = new Build_Your_Own_Control.SimpleCalculator();
            this.simpleCalculator3 = new Build_Your_Own_Control.SimpleCalculator();
            this.SuspendLayout();
            // 
            // simpleCalculator1
            // 
            this.simpleCalculator1.Location = new System.Drawing.Point(38, 60);
            this.simpleCalculator1.Name = "simpleCalculator1";
            this.simpleCalculator1.Size = new System.Drawing.Size(363, 265);
            this.simpleCalculator1.TabIndex = 0;
            this.simpleCalculator1.Load += new System.EventHandler(this.simpleCalculator1_Load);
            // 
            // simpleCalculator2
            // 
            this.simpleCalculator2.Location = new System.Drawing.Point(662, 60);
            this.simpleCalculator2.Name = "simpleCalculator2";
            this.simpleCalculator2.Size = new System.Drawing.Size(363, 265);
            this.simpleCalculator2.TabIndex = 1;
            // 
            // simpleCalculator3
            // 
            this.simpleCalculator3.Location = new System.Drawing.Point(375, 195);
            this.simpleCalculator3.Name = "simpleCalculator3";
            this.simpleCalculator3.Size = new System.Drawing.Size(363, 265);
            this.simpleCalculator3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 450);
            this.Controls.Add(this.simpleCalculator3);
            this.Controls.Add(this.simpleCalculator2);
            this.Controls.Add(this.simpleCalculator1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SimpleCalculator simpleCalculator1;
        private SimpleCalculator simpleCalculator2;
        private SimpleCalculator simpleCalculator3;
    }
}

