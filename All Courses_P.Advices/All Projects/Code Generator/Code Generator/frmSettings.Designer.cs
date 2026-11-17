namespace Code_Generator
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangeBusinessPath = new System.Windows.Forms.Button();
            this.chkboxChangeConnectionString = new System.Windows.Forms.CheckBox();
            this.txtBusinessPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataAccessPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProceduresPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChangeDataAccessPath = new System.Windows.Forms.Button();
            this.btnChangeProceudresPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConnectionString.Location = new System.Drawing.Point(12, 55);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.ReadOnly = true;
            this.txtConnectionString.Size = new System.Drawing.Size(275, 24);
            this.txtConnectionString.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection String:";
            // 
            // btnChangeBusinessPath
            // 
            this.btnChangeBusinessPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeBusinessPath.Location = new System.Drawing.Point(297, 169);
            this.btnChangeBusinessPath.Name = "btnChangeBusinessPath";
            this.btnChangeBusinessPath.Size = new System.Drawing.Size(27, 24);
            this.btnChangeBusinessPath.TabIndex = 8;
            this.btnChangeBusinessPath.Tag = "Business";
            this.btnChangeBusinessPath.Text = "...";
            this.btnChangeBusinessPath.UseVisualStyleBackColor = true;
            this.btnChangeBusinessPath.Click += new System.EventHandler(this.ChangePath_Click);
            // 
            // chkboxChangeConnectionString
            // 
            this.chkboxChangeConnectionString.AutoSize = true;
            this.chkboxChangeConnectionString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxChangeConnectionString.Location = new System.Drawing.Point(293, 56);
            this.chkboxChangeConnectionString.Name = "chkboxChangeConnectionString";
            this.chkboxChangeConnectionString.Size = new System.Drawing.Size(84, 24);
            this.chkboxChangeConnectionString.TabIndex = 8;
            this.chkboxChangeConnectionString.Text = "Change";
            this.chkboxChangeConnectionString.UseVisualStyleBackColor = true;
            this.chkboxChangeConnectionString.CheckedChanged += new System.EventHandler(this.chkboxChangeConnectionString_CheckedChanged);
            // 
            // txtBusinessPath
            // 
            this.txtBusinessPath.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtBusinessPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusinessPath.Location = new System.Drawing.Point(16, 169);
            this.txtBusinessPath.Name = "txtBusinessPath";
            this.txtBusinessPath.Size = new System.Drawing.Size(275, 24);
            this.txtBusinessPath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Business Path:";
            // 
            // txtDataAccessPath
            // 
            this.txtDataAccessPath.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDataAccessPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataAccessPath.Location = new System.Drawing.Point(16, 243);
            this.txtDataAccessPath.Name = "txtDataAccessPath";
            this.txtDataAccessPath.Size = new System.Drawing.Size(275, 24);
            this.txtDataAccessPath.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "DataAccess Path:";
            // 
            // txtProceduresPath
            // 
            this.txtProceduresPath.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtProceduresPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProceduresPath.Location = new System.Drawing.Point(16, 314);
            this.txtProceduresPath.Name = "txtProceduresPath";
            this.txtProceduresPath.Size = new System.Drawing.Size(275, 24);
            this.txtProceduresPath.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Procedures Path:";
            // 
            // btnChangeDataAccessPath
            // 
            this.btnChangeDataAccessPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeDataAccessPath.Location = new System.Drawing.Point(297, 243);
            this.btnChangeDataAccessPath.Name = "btnChangeDataAccessPath";
            this.btnChangeDataAccessPath.Size = new System.Drawing.Size(27, 24);
            this.btnChangeDataAccessPath.TabIndex = 8;
            this.btnChangeDataAccessPath.Tag = "DataAccess";
            this.btnChangeDataAccessPath.Text = "...";
            this.btnChangeDataAccessPath.UseVisualStyleBackColor = true;
            this.btnChangeDataAccessPath.Click += new System.EventHandler(this.ChangePath_Click);
            // 
            // btnChangeProceudresPath
            // 
            this.btnChangeProceudresPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeProceudresPath.Location = new System.Drawing.Point(297, 315);
            this.btnChangeProceudresPath.Name = "btnChangeProceudresPath";
            this.btnChangeProceudresPath.Size = new System.Drawing.Size(27, 24);
            this.btnChangeProceudresPath.TabIndex = 8;
            this.btnChangeProceudresPath.Tag = "Procedures";
            this.btnChangeProceudresPath.Text = "...";
            this.btnChangeProceudresPath.UseVisualStyleBackColor = true;
            this.btnChangeProceudresPath.Click += new System.EventHandler(this.ChangePath_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::Code_Generator.Properties.Resources.SaveSettings42;
            this.btnSave.Location = new System.Drawing.Point(250, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 43);
            this.btnSave.TabIndex = 4;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSettings
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 406);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkboxChangeConnectionString);
            this.Controls.Add(this.btnChangeProceudresPath);
            this.Controls.Add(this.btnChangeDataAccessPath);
            this.Controls.Add(this.btnChangeBusinessPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProceduresPath);
            this.Controls.Add(this.txtDataAccessPath);
            this.Controls.Add(this.txtBusinessPath);
            this.Controls.Add(this.txtConnectionString);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangeBusinessPath;
        private System.Windows.Forms.CheckBox chkboxChangeConnectionString;
        private System.Windows.Forms.TextBox txtBusinessPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDataAccessPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProceduresPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChangeDataAccessPath;
        private System.Windows.Forms.Button btnChangeProceudresPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSave;
    }
}