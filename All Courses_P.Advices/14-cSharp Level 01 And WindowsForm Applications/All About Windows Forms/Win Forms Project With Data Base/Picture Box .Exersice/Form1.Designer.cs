namespace Picture_Box.Exersice
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbBoy = new System.Windows.Forms.RadioButton();
            this.rbGirl = new System.Windows.Forms.RadioButton();
            this.rbBook = new System.Windows.Forms.RadioButton();
            this.rbPen = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(445, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Picture_Box.Exersice.Properties.Resources.Boy;
            this.pictureBox1.Location = new System.Drawing.Point(236, 59);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(532, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // rbBoy
            // 
            this.rbBoy.AutoSize = true;
            this.rbBoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBoy.Location = new System.Drawing.Point(236, 478);
            this.rbBoy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbBoy.Name = "rbBoy";
            this.rbBoy.Size = new System.Drawing.Size(58, 22);
            this.rbBoy.TabIndex = 0;
            this.rbBoy.TabStop = true;
            this.rbBoy.Text = "Boy";
            this.rbBoy.UseVisualStyleBackColor = true;
            // 
            // rbGirl
            // 
            this.rbGirl.AutoSize = true;
            this.rbGirl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGirl.Location = new System.Drawing.Point(391, 478);
            this.rbGirl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbGirl.Name = "rbGirl";
            this.rbGirl.Size = new System.Drawing.Size(56, 22);
            this.rbGirl.TabIndex = 1;
            this.rbGirl.TabStop = true;
            this.rbGirl.Text = "Girl";
            this.rbGirl.UseVisualStyleBackColor = true;
            // 
            // rbBook
            // 
            this.rbBook.AutoSize = true;
            this.rbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBook.Location = new System.Drawing.Point(544, 478);
            this.rbBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbBook.Name = "rbBook";
            this.rbBook.Size = new System.Drawing.Size(69, 22);
            this.rbBook.TabIndex = 2;
            this.rbBook.TabStop = true;
            this.rbBook.Text = "Book";
            this.rbBook.UseVisualStyleBackColor = true;
            // 
            // rbPen
            // 
            this.rbPen.AutoSize = true;
            this.rbPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPen.Location = new System.Drawing.Point(710, 478);
            this.rbPen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbPen.Name = "rbPen";
            this.rbPen.Size = new System.Drawing.Size(58, 22);
            this.rbPen.TabIndex = 3;
            this.rbPen.TabStop = true;
            this.rbPen.Text = "Pen";
            this.rbPen.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Book",
            "Boy",
            "Girl",
            "Pen"});
            this.comboBox1.Location = new System.Drawing.Point(808, 229);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 26);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 534);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rbBoy);
            this.Controls.Add(this.rbGirl);
            this.Controls.Add(this.rbBook);
            this.Controls.Add(this.rbPen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbPen;
        private System.Windows.Forms.RadioButton rbBook;
        private System.Windows.Forms.RadioButton rbGirl;
        private System.Windows.Forms.RadioButton rbBoy;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

