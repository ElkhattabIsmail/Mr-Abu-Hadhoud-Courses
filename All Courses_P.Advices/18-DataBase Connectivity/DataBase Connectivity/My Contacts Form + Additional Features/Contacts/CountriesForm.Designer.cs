namespace Contacts
{
    partial class CountriesForm
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
            this.lblAllCountries = new System.Windows.Forms.Label();
            this.dgvAllCountries = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCountries)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAllCountries
            // 
            this.lblAllCountries.AutoSize = true;
            this.lblAllCountries.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllCountries.Location = new System.Drawing.Point(12, 23);
            this.lblAllCountries.Name = "lblAllCountries";
            this.lblAllCountries.Size = new System.Drawing.Size(574, 52);
            this.lblAllCountries.TabIndex = 0;
            this.lblAllCountries.Text = "All  Countries In System";
            this.lblAllCountries.Click += new System.EventHandler(this.lblAllCountries_Click);
            // 
            // dgvAllCountries
            // 
            this.dgvAllCountries.AllowUserToAddRows = false;
            this.dgvAllCountries.AllowUserToDeleteRows = false;
            this.dgvAllCountries.AllowUserToOrderColumns = true;
            this.dgvAllCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllCountries.Location = new System.Drawing.Point(0, 105);
            this.dgvAllCountries.Name = "dgvAllCountries";
            this.dgvAllCountries.RowHeadersWidth = 51;
            this.dgvAllCountries.RowTemplate.Height = 24;
            this.dgvAllCountries.Size = new System.Drawing.Size(610, 338);
            this.dgvAllCountries.TabIndex = 1;
            // 
            // CountriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 517);
            this.Controls.Add(this.dgvAllCountries);
            this.Controls.Add(this.lblAllCountries);
            this.Name = "CountriesForm";
            this.Text = "CountriesForm";
            this.Load += new System.EventHandler(this.CountriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCountries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAllCountries;
        private System.Windows.Forms.DataGridView dgvAllCountries;
    }
}