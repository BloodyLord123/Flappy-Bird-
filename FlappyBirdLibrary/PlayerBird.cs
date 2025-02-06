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
            CheckActivityGame();
        }

        public void Jump()
        {
            MakeBirdJump();
        }

        private void MoveBird()
        {
            BirdBox.Top += Speed;
            CheckBounds();
        }

        private void CheckBounds()
        {
            LimitBirdPosition();
        }

        public bool GameDefeat()
        {
            return CheckGroundCollision();
        }

        public bool CheckCollision(PictureBox scoreline)
        {
            return CheckScorelineCross(scoreline);
        }

        private bool CheckScorelineCross(PictureBox scoreline)
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

        private void CheckActivityGame()
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

        private void MakeBirdJump()
        {
            if (GameActive)
            {
                Speed = JumpHeight;
                MoveBird();
            }
        }

        private void LimitBirdPosition()
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

        private bool CheckGroundCollision()
        {
            if (BirdBox.Top + BirdBox.Height >= BirdBox.Parent.ClientSize.Height)
            {
                GameStop();
                return true;
            }
            return false;
        }
    }
}