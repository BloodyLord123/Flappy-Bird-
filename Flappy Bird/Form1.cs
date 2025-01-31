using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlappyBirdLibrary;

namespace Flappy_Bird
{   
    public partial class Form1 : Form
    {   
        private PlayerBird playerBird;
        public Form1()
        {
            InitializeComponent();
            playerBird = new PlayerBird(pictureBird);
            
            
        }

        private void InitializeGame()
        {
            timer1 = new Timer();
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            playerBird.Fall();
            if (playerBird.GameStop())
            {
                timer1.Stop();
            }
   
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            InitializeGame();
          
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Проверяем, что нажата левая кнопка мыши
            {
                playerBird.Jump(); // Вызываем метод Jump у объекта playerBird
            }
        }
    }
}