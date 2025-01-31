using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlappyBirdLibrary;

namespace Flappy_Bird
{   
    public partial class Form1 : Form
    {
        
        private PlayerBird playerBird;
        private Pipe pipe;
        private int score;
        public int scorechek;
        private int bestScore = 0;
        private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "best_score.txt");
        private ScoreManager scoreManager;
        public Form1()
        {
            InitializeComponent();
            playerBird = new PlayerBird(pictureBird);
            pipe = new Pipe(picturepipedown, picturepipeup, Scoreline);
            buttoncontinue.Visible = false;
            buttonmenu.Visible = false;
            picturepipedown.Visible = false;
            picturepipeup.Visible = false;
            Best.Visible = false;
            Score.Visible = false;
            scoreManager = new ScoreManager(FilePath);
            bestScore = scoreManager.LoadBestScore();
            Best.Text = "Best: " + bestScore;
        }

        private void InitializeGame()
        {
            timer1 = new Timer();
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                playerBird.Jump();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            playerBird.Fall();
            pipe.Move();

            if (playerBird.CheckCollision(Scoreline))
            {
                scorechek++;
                if (scorechek % 28 == 0)
                {
                    score++;
                    Score.Text = "Score: " + score;
                    if (score > bestScore)
                    {
                        bestScore = score;
                        Best.Text = "Best: " + bestScore;
                        scoreManager.SaveBestScore(bestScore);
                    }
                }
            }

            if (pipe.CheckCollision(playerBird) || playerBird.GameDefeat())
            {
                pipe.GameStop();
                playerBird.GameStop();
                timer1.Tick -= timer1_Tick;
                timer1.Stop();
                buttonstart.Visible = true;
                score = 0;
                Score.Text = "Score: 0 ";
                buttonmenu.Visible = false;
            }
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            InitializeGame();
            playerBird.GameStart();
            pipe.ResetPosition();
            pipe.GameStart();
            FlappyBox1.Visible = false;
            Best.Visible = true;
            Score.Visible = true;
            buttonstart.Visible = false;
            buttonmenu.Visible = true;
            picturepipedown.Visible = true;
            picturepipeup.Visible = true;
            pictureBird.Location = new Point(190, 230);
            score = 0;
            Score.Text = "Score: 0 ";
        }

        private void buttonmenu_Click(object sender, EventArgs e)
        {
            playerBird.GameStop();
            pipe.GameStop();
            buttoncontinue.Visible = true;
        }

        private void buttoncontinue_Click(object sender, EventArgs e)
        {
            playerBird.GameStart();
            pipe.GameStart();
            buttoncontinue.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}