namespace TimerApp_Project_04
{
    partial class frmCountDown
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
            this.components = new System.ComponentModel.Container();
            this.H = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCapt = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Min = new System.Windows.Forms.Label();
            this.Sec = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Ms = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // H
            // 
            this.H.AutoSize = true;
            this.H.BackColor = System.Drawing.Color.Transparent;
            this.H.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.H.Location = new System.Drawing.Point(185, 312);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(68, 52);
            this.H.TabIndex = 10;
            this.H.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(59, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Timer ";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Khaki;
            this.btnStart.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(39, 380);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 53);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCapt
            // 
            this.btnCapt.BackColor = System.Drawing.Color.Khaki;
            this.btnCapt.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapt.Location = new System.Drawing.Point(171, 380);
            this.btnCapt.Name = "btnCapt";
            this.btnCapt.Size = new System.Drawing.Size(104, 53);
            this.btnCapt.TabIndex = 13;
            this.btnCapt.Text = "Capture";
            this.btnCapt.UseVisualStyleBackColor = false;
            this.btnCapt.Click += new System.EventHandler(this.btnCapt_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Khaki;
            this.btnStop.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(303, 380);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(104, 53);
            this.btnStop.TabIndex = 14;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Khaki;
            this.btnReset.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(435, 380);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 53);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // listView1
            // 
            this.listView1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(39, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(499, 251);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "All Timer Captures";
            this.columnHeader1.Width = 400;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.BackColor = System.Drawing.Color.Transparent;
            this.Min.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Min.Location = new System.Drawing.Point(259, 312);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(68, 52);
            this.Min.TabIndex = 17;
            this.Min.Text = "00";
            // 
            // Sec
            // 
            this.Sec.AutoSize = true;
            this.Sec.BackColor = System.Drawing.Color.Transparent;
            this.Sec.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Sec.Location = new System.Drawing.Point(333, 312);
            this.Sec.Name = "Sec";
            this.Sec.Size = new System.Drawing.Size(68, 52);
            this.Sec.TabIndex = 18;
            this.Sec.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(318, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 36);
            this.label4.TabIndex = 19;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(244, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 36);
            this.label5.TabIndex = 20;
            this.label5.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(390, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 36);
            this.label7.TabIndex = 21;
            this.label7.Text = ".";
            // 
            // Ms
            // 
            this.Ms.AutoSize = true;
            this.Ms.BackColor = System.Drawing.Color.Transparent;
            this.Ms.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Ms.Location = new System.Drawing.Point(407, 312);
            this.Ms.Name = "Ms";
            this.Ms.Size = new System.Drawing.Size(91, 52);
            this.Ms.TabIndex = 22;
            this.Ms.Text = "000";
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.Red;
            this.btnClearAll.Location = new System.Drawing.Point(504, 280);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(34, 24);
            this.btnClearAll.TabIndex = 23;
            this.btnClearAll.Text = "X";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(412, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Clear All";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(35, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Clear Selected Capture";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(260, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 24);
            this.button1.TabIndex = 25;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmCountDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(568, 470);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.Ms);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Sec);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnCapt);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.H);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCountDown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Counter";
            this.Load += new System.EventHandler(this.frmCountDown_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label H;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCapt;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Label Sec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Ms;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}