using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBirdLibrary
{
    public class Settings
    {
        public int Speed { get; set; }
        public bool GameActive { get; set; }
        public int Gravity { get; set; }
        public int JumpHeight { get; set; }
        public int MaxFallSpeed { get; set; }
        public int PipeSpeed { get; set; }
        public int PipeGapSize { get; set; }

        public Settings()
        {
            Speed = 0;
            GameActive = false;
            Gravity = 0;
            JumpHeight = 0;
            MaxFallSpeed = 0;
            PipeSpeed = 0;
            PipeGapSize = 140;
        }
        public void GameStart()
        {
            GameActive = true;
            Speed = 6;
            Gravity = 2;
            JumpHeight = -15;
            MaxFallSpeed =6;
            PipeSpeed = 5;
        }
        public void GameStop()
        {
            Speed = 0;
            Gravity = 0;
            JumpHeight = 0;
            MaxFallSpeed = 0;
            PipeSpeed = 0;
            GameActive = false;
        }
    }
}



