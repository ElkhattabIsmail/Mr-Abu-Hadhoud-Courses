namespace TimerApp_Project_04
{
    partial class CounterForm
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
            this.ud1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBar = new CircularProgressBar.CircularProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ud1
            // 
            this.ud1.BackColor = System.Drawing.SystemColors.Info;
            this.ud1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ud1.Location = new System.Drawing.Point(109, 78);
            this.ud1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.ud1.Name = "ud1";
            this.ud1.Size = new System.Drawing.Size(74, 42);
            this.ud1.TabIndex = 0;
            this.ud1.ValueChanged += new System.EventHandler(this.ud1_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.Info;
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDown1.Location = new System.Drawing.Point(479, 78);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 42);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.SystemColors.Info;
            this.numericUpDown2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(295, 78);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(74, 42);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(94, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(274, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(460, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seconds";
            // 
            // cBar
            // 
            this.cBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cBar.AnimationSpeed = 300;
            this.cBar.BackColor = System.Drawing.Color.Transparent;
            this.cBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.cBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cBar.InnerMargin = 2;
            this.cBar.InnerWidth = -1;
            this.cBar.Location = new System.Drawing.Point(140, 167);
            this.cBar.MarqueeAnimationSpeed = 2000;
            this.cBar.Name = "cBar";
            this.cBar.OuterColor = System.Drawing.Color.Gray;
            this.cBar.OuterMargin = -25;
            this.cBar.OuterWidth = 30;
            this.cBar.ProgressColor = System.Drawing.Color.Lime;
            this.cBar.ProgressWidth = 25;
            this.cBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBar.Size = new System.Drawing.Size(387, 376);
            this.cBar.StartAngle = 270;
            this.cBar.Step = 20;
            this.cBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cBar.SubscriptText = "";
            this.cBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cBar.SuperscriptText = "";
            this.cBar.TabIndex = 6;
            this.cBar.Tag = "";
            this.cBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cBar.Value = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 46);
            this.label4.TabIndex = 7;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(410, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 46);
            this.label5.TabIndex = 8;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(236, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 52);
            this.label6.TabIndex = 9;
            this.label6.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Image = global::TimerApp_Project_04.Properties.Resources.Play_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(295, 399);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Play";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            // 
            // CounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 585);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ud1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CounterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Counter Down";
            this.Load += new System.EventHandler(this.CounterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ud1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CircularProgressBar.CircularProgressBar cBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}