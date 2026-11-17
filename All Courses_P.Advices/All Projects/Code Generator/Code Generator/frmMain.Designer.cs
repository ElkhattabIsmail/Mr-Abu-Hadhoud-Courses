namespace Code_Generator
{
    partial class frmMain
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
            this.chkboxTables = new System.Windows.Forms.CheckedListBox();
            this.cbDatabases = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.gpMethodsType = new System.Windows.Forms.GroupBox();
            this.rdioAsync = new System.Windows.Forms.RadioButton();
            this.rdioSync = new System.Windows.Forms.RadioButton();
            this.chkBusinessLayer = new System.Windows.Forms.CheckBox();
            this.chkDataAccessLayer = new System.Windows.Forms.CheckBox();
            this.chkProcedures = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpMethodsType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkboxTables
            // 
            this.chkboxTables.BackColor = System.Drawing.Color.White;
            this.chkboxTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxTables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.chkboxTables.FormattingEnabled = true;
            this.chkboxTables.Location = new System.Drawing.Point(12, 151);
            this.chkboxTables.Name = "chkboxTables";
            this.chkboxTables.Size = new System.Drawing.Size(472, 364);
            this.chkboxTables.TabIndex = 2;
            // 
            // cbDatabases
            // 
            this.cbDatabases.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbDatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatabases.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDatabases.ForeColor = System.Drawing.Color.Black;
            this.cbDatabases.FormattingEnabled = true;
            this.cbDatabases.Location = new System.Drawing.Point(12, 87);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(259, 28);
            this.cbDatabases.TabIndex = 3;
            this.cbDatabases.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.checkBox1.Location = new System.Drawing.Point(12, 125);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Select All";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(582, 443);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(195, 69);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Image = global::Code_Generator.Properties.Resources.Settings36;
            this.btnSettings.Location = new System.Drawing.Point(-1, -1);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(52, 42);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // gpMethodsType
            // 
            this.gpMethodsType.Controls.Add(this.rdioAsync);
            this.gpMethodsType.Controls.Add(this.rdioSync);
            this.gpMethodsType.Enabled = false;
            this.gpMethodsType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpMethodsType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gpMethodsType.Location = new System.Drawing.Point(582, 362);
            this.gpMethodsType.Name = "gpMethodsType";
            this.gpMethodsType.Size = new System.Drawing.Size(195, 75);
            this.gpMethodsType.TabIndex = 6;
            this.gpMethodsType.TabStop = false;
            this.gpMethodsType.Text = "Methods Type";
            // 
            // rdioAsync
            // 
            this.rdioAsync.AutoSize = true;
            this.rdioAsync.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdioAsync.Location = new System.Drawing.Point(123, 20);
            this.rdioAsync.Name = "rdioAsync";
            this.rdioAsync.Size = new System.Drawing.Size(67, 20);
            this.rdioAsync.TabIndex = 8;
            this.rdioAsync.Text = "Async";
            this.rdioAsync.UseVisualStyleBackColor = true;
            // 
            // rdioSync
            // 
            this.rdioSync.AutoSize = true;
            this.rdioSync.Checked = true;
            this.rdioSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdioSync.Location = new System.Drawing.Point(6, 20);
            this.rdioSync.Name = "rdioSync";
            this.rdioSync.Size = new System.Drawing.Size(59, 20);
            this.rdioSync.TabIndex = 8;
            this.rdioSync.TabStop = true;
            this.rdioSync.Text = "Sync";
            this.rdioSync.UseVisualStyleBackColor = true;
            // 
            // chkBusinessLayer
            // 
            this.chkBusinessLayer.AutoSize = true;
            this.chkBusinessLayer.BackColor = System.Drawing.Color.White;
            this.chkBusinessLayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBusinessLayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.chkBusinessLayer.Location = new System.Drawing.Point(13, 41);
            this.chkBusinessLayer.Name = "chkBusinessLayer";
            this.chkBusinessLayer.Size = new System.Drawing.Size(132, 20);
            this.chkBusinessLayer.TabIndex = 4;
            this.chkBusinessLayer.Text = "Business Layer";
            this.chkBusinessLayer.UseVisualStyleBackColor = false;
            this.chkBusinessLayer.CheckedChanged += new System.EventHandler(this.chkBusinessLayer_CheckedChanged);
            // 
            // chkDataAccessLayer
            // 
            this.chkDataAccessLayer.AutoSize = true;
            this.chkDataAccessLayer.BackColor = System.Drawing.Color.White;
            this.chkDataAccessLayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDataAccessLayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.chkDataAccessLayer.Location = new System.Drawing.Point(13, 82);
            this.chkDataAccessLayer.Name = "chkDataAccessLayer";
            this.chkDataAccessLayer.Size = new System.Drawing.Size(157, 20);
            this.chkDataAccessLayer.TabIndex = 4;
            this.chkDataAccessLayer.Text = "Data Access Layer";
            this.chkDataAccessLayer.UseVisualStyleBackColor = false;
            this.chkDataAccessLayer.CheckedChanged += new System.EventHandler(this.chkDataAccessLayer_CheckedChanged);
            // 
            // chkProcedures
            // 
            this.chkProcedures.AutoSize = true;
            this.chkProcedures.BackColor = System.Drawing.Color.White;
            this.chkProcedures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProcedures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.chkProcedures.Location = new System.Drawing.Point(13, 125);
            this.chkProcedures.Name = "chkProcedures";
            this.chkProcedures.Size = new System.Drawing.Size(156, 20);
            this.chkProcedures.TabIndex = 4;
            this.chkProcedures.Text = "Stored Procedures";
            this.chkProcedures.UseVisualStyleBackColor = false;
            this.chkProcedures.CheckedChanged += new System.EventHandler(this.chkProcedures_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(15, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "DataBases";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBusinessLayer);
            this.groupBox1.Controls.Add(this.chkDataAccessLayer);
            this.groupBox1.Controls.Add(this.chkProcedures);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(582, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 171);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Layers";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 542);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpMethodsType);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cbDatabases);
            this.Controls.Add(this.chkboxTables);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gpMethodsType.ResumeLayout(false);
            this.gpMethodsType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkboxTables;
        private System.Windows.Forms.ComboBox cbDatabases;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.GroupBox gpMethodsType;
        private System.Windows.Forms.CheckBox chkBusinessLayer;
        private System.Windows.Forms.CheckBox chkDataAccessLayer;
        private System.Windows.Forms.CheckBox chkProcedures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdioSync;
        private System.Windows.Forms.RadioButton rdioAsync;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

