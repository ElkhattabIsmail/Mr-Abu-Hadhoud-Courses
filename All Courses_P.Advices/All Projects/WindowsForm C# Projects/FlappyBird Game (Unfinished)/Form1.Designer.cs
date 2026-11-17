namespace FlappyBird_Game
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
            this.components = new System.ComponentModel.Container();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.just = new System.Windows.Forms.Label();
            this.lblFinalScore = new System.Windows.Forms.Label();
            this.lblRestart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::FlappyBird_Game.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(140, 300);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(48, 47);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::FlappyBird_Game.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(530, 406);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(83, 184);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 1;
            this.pipeBottom.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::FlappyBird_Game.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(476, 1);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(83, 204);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 2;
            this.pipeTop.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::FlappyBird_Game.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-11, 582);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(941, 94);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.LemonChiffon;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.scoreText.Location = new System.Drawing.Point(12, 611);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(135, 32);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score : 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Wide Latin", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(231, 237);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(610, 74);
            this.lblGameOver.TabIndex = 5;
            this.lblGameOver.Text = "Game Over";
            this.lblGameOver.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.just);
            this.panel1.Controls.Add(this.lblFinalScore);
            this.panel1.Location = new System.Drawing.Point(390, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 334);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(84, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 47);
            this.button2.TabIndex = 10;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(84, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Play Again";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // just
            // 
            this.just.AutoSize = true;
            this.just.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.just.Location = new System.Drawing.Point(26, 55);
            this.just.Name = "just";
            this.just.Size = new System.Drawing.Size(182, 32);
            this.just.TabIndex = 7;
            this.just.Text = "Your Score :";
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.AutoSize = true;
            this.lblFinalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalScore.Location = new System.Drawing.Point(229, 55);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(31, 32);
            this.lblFinalScore.TabIndex = 8;
            this.lblFinalScore.Text = "0";
            // 
            // lblRestart
            // 
            this.lblRestart.AutoSize = true;
            this.lblRestart.BackColor = System.Drawing.Color.Transparent;
            this.lblRestart.Font = new System.Drawing.Font("Ravie", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestart.ForeColor = System.Drawing.Color.Indigo;
            this.lblRestart.Location = new System.Drawing.Point(416, 240);
            this.lblRestart.Name = "lblRestart";
            this.lblRestart.Size = new System.Drawing.Size(106, 107);
            this.lblRestart.TabIndex = 11;
            this.lblRestart.Text = "0";
            this.lblRestart.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(925, 677);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.lblRestart);
            this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "flappybird Game";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label just;
        private System.Windows.Forms.Label lblFinalScore;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRestart;
    }
}

