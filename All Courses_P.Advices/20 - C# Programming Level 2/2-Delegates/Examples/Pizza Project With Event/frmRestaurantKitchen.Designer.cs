namespace PizzaArgs
{
    partial class frmRestaurantKitchen
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
            this.lblOrderDetails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDetails.Location = new System.Drawing.Point(114, 178);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(674, 38);
            this.lblOrderDetails.TabIndex = 0;
            this.lblOrderDetails.Text = "label1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(267, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pizza Basic Infos :";
            // 
            // frmRestaurantKitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOrderDetails);
            this.Name = "frmRestaurantKitchen";
            this.Text = "frmRestaurantKitchen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOrderDetails;
        private System.Windows.Forms.Label label1;
    }
}