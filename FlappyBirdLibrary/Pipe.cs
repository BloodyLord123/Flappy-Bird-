using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdLibrary
{
    public class Pipe :Settings
    {
        public PictureBox PipeDownBox { get; set; }
        public PictureBox PipeUpBox { get; set; }
        public PictureBox ScoreBox { get; set; }
        public Pipe(PictureBox pipeDownBox, PictureBox pipeUpBox, PictureBox scorebox)
        {
            ScoreBox = scorebox;
            PipeDownBox = pipeDownBox;
            PipeUpBox = pipeUpBox;
            PipeDownBox.Location = new Point(0, 0);
            PipeUpBox.Location = new Point(0, 0);
        }
        public bool Move()
        {
            if (GameActive)
            {
                PipeDownBox.Left -= PipeSpeed;
                PipeUpBox.Left -= PipeSpeed;
                ScoreBox.Left -= PipeSpeed;

                if (PipeDownBox.Right < 0)
                {
                    ResetPosition();
                }
                return true;
            }
            return false;
        }
        public void ResetPosition()
        {
            PipeDownBox.Left = PipeDownBox.Parent.ClientSize.Width;
            PipeUpBox.Left = PipeDownBox.Left;
            int minY = 0;
            int maxY = PipeDownBox.Parent.ClientSize.Height - PipeGapSize;
            Random rand = new Random();
            int newY = rand.Next(minY, maxY);
            PipeDownBox.Top = newY + PipeGapSize;
            PipeUpBox.Top = newY - PipeUpBox.Height;
            ScoreBox.Left = PipeDownBox.Left + PipeDownBox.Width / 2 - ScoreBox.Width / 2;
        }
        public bool CheckCollision(PlayerBird playerBird)
        {
            Rectangle birdBounds = new Rectangle(playerBird.BirdBox.Location, playerBird.BirdBox.Size);

            foreach (var pipeBounds in new[] { PipeDownBox.Bounds, PipeUpBox.Bounds })
            {
                if (birdBounds.IntersectsWith(pipeBounds))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
