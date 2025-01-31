using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FlappyBirdLibrary
{
    public class PlayerBird : Settings
    {
        public PictureBox BirdBox { get; set; }

        public PlayerBird(PictureBox birdBox)
        {
            BirdBox = birdBox;
        }

        public void Fall()
        {
            if (GameActive)
            {
                Speed += Gravity;
                if (Speed > MaxFallSpeed)
                {
                    Speed = MaxFallSpeed;
                }
                MoveBird();
            }
        }
        public void Jump()
        {
            if (GameActive)
            {
                Speed = JumpHeight;
                MoveBird();
            }
        }
        private void MoveBird()
        {
            BirdBox.Top += Speed;
            CheckBounds();
        }
        private void CheckBounds()
        {
            if (BirdBox.Top < 0)
            {
                BirdBox.Top = 0;
            }
            if (BirdBox.Top + BirdBox.Height > BirdBox.Parent.ClientSize.Height)
            {
                BirdBox.Top = BirdBox.Parent.ClientSize.Height - BirdBox.Height;
            }
        }
        public bool GameDefeat()
        {
            if (BirdBox.Top + BirdBox.Height >= BirdBox.Parent.ClientSize.Height)
            {
                GameStop();
                return true;
            }
            return false;
        }
        public bool CheckCollision(PictureBox scoreline)
        {
            if (GameActive)
            {
                Rectangle birdBounds = new Rectangle(BirdBox.Location, BirdBox.Size);
                Rectangle scorelineBounds = new Rectangle(scoreline.Location, scoreline.Size);

                bool intersects = birdBounds.Left < scorelineBounds.Right &&
                           birdBounds.Right > scorelineBounds.Left &&
                           birdBounds.Top < scorelineBounds.Bottom &&
                           birdBounds.Bottom > scorelineBounds.Top;

                return intersects;
            }
            return false;
        }
    }
}