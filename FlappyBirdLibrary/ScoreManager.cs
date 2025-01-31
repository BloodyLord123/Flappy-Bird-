using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FlappyBirdLibrary
{
    public class ScoreManager
    {
        private readonly string filePath;

        public ScoreManager(string FilePath)
        {
            filePath = FilePath;
        }

        public void SaveBestScore(int bestScore)
        {
            File.WriteAllText(filePath, bestScore.ToString());
        }

        public int LoadBestScore()
        {
            if (File.Exists(filePath))
            {
                string bestScoreText = File.ReadAllText(filePath);
                int.TryParse(bestScoreText, out int bestScore);
                return bestScore;
            }
            return 0;
        }
    }
}
