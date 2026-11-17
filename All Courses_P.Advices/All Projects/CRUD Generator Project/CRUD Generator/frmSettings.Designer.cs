namespace CRUD_Generator
{
    partial class frmSettings
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
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.txtBusinessPath = new System.Windows.Forms.TextBox();
            this.txtDataAccessPath = new System.Windows.Forms.TextBox();
            this.txtProceduresPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConnectionString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConnectionString.Location = new System.Drawing.Point(205, 112);
            this.txtConnectionString.Multiline = true;
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(187, 41);
            this.txtConnectionString.TabIndex = 0;
            // 
            // txtBusinessPath
            // 
            this.txtBusinessPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusinessPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusinessPath.Location = new System.Drawing.Point(205, 181);
            this.txtBusinessPath.Multiline = true;
            this.txtBusinessPath.Name = "txtBusinessPath";
            this.txtBusinessPath.Size = new System.Drawing.Size(187, 41);
            this.txtBusinessPath.TabIndex = 1;
            // 
            // txtDataAccessPath
            // 
            this.txtDataAccessPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataAccessPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataAccessPath.Location = new System.Drawing.Point(205, 242);
            this.txtDataAccessPath.Multiline = true;
            this.txtDataAccessPath.Name = "txtDataAccessPath";
            this.txtDataAccessPath.Size = new System.Drawing.Size(187, 41);
            this.txtDataAccessPath.TabIndex = 2;
            // 
            // txtProceduresPath
            // 
            this.txtProceduresPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProceduresPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProceduresPath.Location = new System.Drawing.Point(205, 309);
            this.txtProceduresPath.Multiline = true;
            this.txtProceduresPath.Name = "txtProceduresPath";
            this.txtProceduresPath.Size = new System.Drawing.Size(187, 41);
            this.txtProceduresPath.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(622, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(603, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "ChangePath";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtProceduresPath);
            this.Controls.Add(this.txtDataAccessPath);
            this.Controls.Add(this.txtBusinessPath);
            this.Controls.Add(this.txtConnectionString);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.TextBox txtBusinessPath;
        private System.Windows.Forms.TextBox txtDataAccessPath;
        private System.Windows.Forms.TextBox txtProceduresPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button2;
    }
}