namespace Contacts
{
    partial class SearchOnUsers
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.lblAllCountries = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(255, 143);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(296, 40);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSearch.Location = new System.Drawing.Point(0, 255);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.RowHeadersWidth = 51;
            this.dgvSearch.RowTemplate.Height = 24;
            this.dgvSearch.Size = new System.Drawing.Size(782, 237);
            this.dgvSearch.TabIndex = 1;
            // 
            // lblAllCountries
            // 
            this.lblAllCountries.AutoSize = true;
            this.lblAllCountries.Font = new System.Drawing.Font("Sitka Small", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllCountries.Location = new System.Drawing.Point(101, 35);
            this.lblAllCountries.Name = "lblAllCountries";
            this.lblAllCountries.Size = new System.Drawing.Size(545, 49);
            this.lblAllCountries.TabIndex = 3;
            this.lblAllCountries.Text = "Search for User by their Names";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search";
            // 
            // SearchOnUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAllCountries);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SearchOnUsers";
            this.Text = "SearchOnUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Label lblAllCountries;
        private System.Windows.Forms.Label label1;
    }
}