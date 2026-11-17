namespace CRUD_Generator
{
    partial class MainForm
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
            this.txtProceduresPath = new System.Windows.Forms.TextBox();
            this.txtDataAccessPath = new System.Windows.Forms.TextBox();
            this.txtBusinessPath = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.richTxtContantLayers = new System.Windows.Forms.RichTextBox();
            this.cbDatabase = new System.Windows.Forms.ComboBox();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(53, 272);
            this.txtConnectionString.Multiline = true;
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(124, 38);
            this.txtConnectionString.TabIndex = 1;
            // 
            // txtProceduresPath
            // 
            this.txtProceduresPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProceduresPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProceduresPath.Location = new System.Drawing.Point(16, 524);
            this.txtProceduresPath.Multiline = true;
            this.txtProceduresPath.Name = "txtProceduresPath";
            this.txtProceduresPath.Size = new System.Drawing.Size(187, 41);
            this.txtProceduresPath.TabIndex = 7;
            // 
            // txtDataAccessPath
            // 
            this.txtDataAccessPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataAccessPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataAccessPath.Location = new System.Drawing.Point(16, 457);
            this.txtDataAccessPath.Multiline = true;
            this.txtDataAccessPath.Name = "txtDataAccessPath";
            this.txtDataAccessPath.Size = new System.Drawing.Size(187, 41);
            this.txtDataAccessPath.TabIndex = 6;
            // 
            // txtBusinessPath
            // 
            this.txtBusinessPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusinessPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusinessPath.Location = new System.Drawing.Point(16, 396);
            this.txtBusinessPath.Multiline = true;
            this.txtBusinessPath.Name = "txtBusinessPath";
            this.txtBusinessPath.Size = new System.Drawing.Size(187, 41);
            this.txtBusinessPath.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 327);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 41);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(492, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generic";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(492, 432);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 51);
            this.button2.TabIndex = 9;
            this.button2.Text = "Business";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(492, 532);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 69);
            this.button3.TabIndex = 10;
            this.button3.Text = "Data Access";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // richTxtContantLayers
            // 
            this.richTxtContantLayers.Location = new System.Drawing.Point(684, 26);
            this.richTxtContantLayers.Name = "richTxtContantLayers";
            this.richTxtContantLayers.Size = new System.Drawing.Size(505, 586);
            this.richTxtContantLayers.TabIndex = 11;
            this.richTxtContantLayers.Text = "";
            // 
            // cbDatabase
            // 
            this.cbDatabase.FormattingEnabled = true;
            this.cbDatabase.Location = new System.Drawing.Point(53, 41);
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Size = new System.Drawing.Size(150, 24);
            this.cbDatabase.TabIndex = 12;
            // 
            // cbTables
            // 
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(231, 41);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(141, 24);
            this.cbTables.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(591, 164);
            this.dataGridView1.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 638);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbTables);
            this.Controls.Add(this.cbDatabase);
            this.Controls.Add(this.richTxtContantLayers);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtProceduresPath);
            this.Controls.Add(this.txtDataAccessPath);
            this.Controls.Add(this.txtBusinessPath);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtConnectionString);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.TextBox txtProceduresPath;
        private System.Windows.Forms.TextBox txtDataAccessPath;
        private System.Windows.Forms.TextBox txtBusinessPath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTxtContantLayers;
        private System.Windows.Forms.ComboBox cbDatabase;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

