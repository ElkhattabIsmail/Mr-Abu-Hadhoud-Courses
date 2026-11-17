using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class FlappyBirdGame : Form
    {
        private List<PictureBox> pipes;
        private PictureBox bird;
        private int score = 0;
        private Timer gameTimer;
        private bool gameOver = false;

        public FlappyBirdGame()
        {
            InitializeComponent();
            SetupGame();
        }

        private void SetupGame()
        {
            // Create the bird
            bird = new PictureBox
            {
                Size = new Size(50, 50),
                BackColor = Color.Orange,
                Location = new Point(50, ClientSize.Height / 2 - 25)
            };
            Controls.Add(bird);

            // Create the pipes
            pipes = new List<PictureBox>();
            for (int i = 0; i < 3; i++)
            {
                PictureBox pipe = new PictureBox
                {
                    Size = new Size(80, 300),
                    BackColor = Color.Green,
                    Location = new Point(ClientSize.Width + i * 200, ClientSize.Height / 2 - 150)
                };
                pipes.Add(pipe);
                Controls.Add(pipe);
            }

            // Set up the game timer
            gameTimer = new Timer { Interval = 20 };
            gameTimer.Tick += GameTimerTick;
            gameTimer.Start();
        }

        private void GameTimerTick(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                // Move the bird
                bird.Top += 5;

                // Move the pipes
                foreach (PictureBox pipe in pipes)
                {
                    pipe.Left -= 3;
                    if (pipe.Left < -80)
                    {
                        pipe.Left = ClientSize.Width;
                        score++;
                        scoreLabel.Text = $"Score: {score}";
                    }
                }

                // Check for collisions
                if (bird.Top < 0 || bird.Bottom > ClientSize.Height || pipes.Exists(p => bird.Bounds.IntersectsWith(p.Bounds)))
                {
                    gameOver = true;
                    gameTimer.Stop();
                    MessageBox.Show($"Game Over! Your score is {score}.");
                    RestartGame();
                }
            }
        }

        private void FlappyBirdGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !gameOver)
            {
                bird.Top -= 50;
            }
        }

        private void RestartGame()
        {
            score = 0;
            scoreLabel.Text = $"Score: {score}";
            gameOver = false;
            bird.Location = new Point(50, ClientSize.Height / 2 - 25);
            foreach (PictureBox pipe in pipes)
            {
                pipe.Left = ClientSize.Width;
            }
            gameTimer.Start();
        }

        private void InitializeComponent()
        {
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(12, 12);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(65, 20);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Score: 0";
            // 
            // FlappyBirdGame
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.scoreLabel);
            this.Name = "FlappyBirdGame";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlappyBirdGame_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label scoreLabel;
    }
}