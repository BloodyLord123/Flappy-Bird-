namespace Flappy_Bird
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonstart = new System.Windows.Forms.Button();
            this.buttonmenu = new System.Windows.Forms.Button();
            this.buttoncontinue = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Label();
            this.Best = new System.Windows.Forms.Label();
            this.picturepipedown = new System.Windows.Forms.PictureBox();
            this.picturepipeup = new System.Windows.Forms.PictureBox();
            this.pictureBird = new System.Windows.Forms.PictureBox();
            this.Scoreline = new System.Windows.Forms.PictureBox();
            this.FlappyBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturepipedown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturepipeup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scoreline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonstart
            // 
            this.buttonstart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonstart.Location = new System.Drawing.Point(309, 413);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(129, 50);
            this.buttonstart.TabIndex = 3;
            this.buttonstart.Text = "Почати";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // buttonmenu
            // 
            this.buttonmenu.Location = new System.Drawing.Point(0, 0);
            this.buttonmenu.Name = "buttonmenu";
            this.buttonmenu.Size = new System.Drawing.Size(103, 49);
            this.buttonmenu.TabIndex = 4;
            this.buttonmenu.Text = "Пауза";
            this.buttonmenu.UseVisualStyleBackColor = true;
            this.buttonmenu.Click += new System.EventHandler(this.buttonmenu_Click);
            // 
            // buttoncontinue
            // 
            this.buttoncontinue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttoncontinue.Location = new System.Drawing.Point(309, 413);
            this.buttoncontinue.Name = "buttoncontinue";
            this.buttoncontinue.Size = new System.Drawing.Size(129, 50);
            this.buttoncontinue.TabIndex = 5;
            this.buttoncontinue.Text = "Продовжити";
            this.buttoncontinue.UseVisualStyleBackColor = true;
            this.buttoncontinue.Click += new System.EventHandler(this.buttoncontinue_Click);
            // 
            // Score
            // 
            this.Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Score.Location = new System.Drawing.Point(668, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(102, 29);
            this.Score.TabIndex = 6;
            this.Score.Text = "Score: 0";
            // 
            // Best
            // 
            this.Best.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Best.AutoSize = true;
            this.Best.BackColor = System.Drawing.Color.Transparent;
            this.Best.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Best.Location = new System.Drawing.Point(668, 29);
            this.Best.Name = "Best";
            this.Best.Size = new System.Drawing.Size(86, 29);
            this.Best.TabIndex = 9;
            this.Best.Text = "Best: 0";
            // 
            // picturepipedown
            // 
            this.picturepipedown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picturepipedown.Image = global::Flappy_Bird.Properties.Resources.pipe2;
            this.picturepipedown.Location = new System.Drawing.Point(570, 542);
            this.picturepipedown.Name = "picturepipedown";
            this.picturepipedown.Size = new System.Drawing.Size(108, 866);
            this.picturepipedown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturepipedown.TabIndex = 2;
            this.picturepipedown.TabStop = false;
            this.picturepipedown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            // 
            // picturepipeup
            // 
            this.picturepipeup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picturepipeup.Image = global::Flappy_Bird.Properties.Resources.pipe;
            this.picturepipeup.Location = new System.Drawing.Point(570, -411);
            this.picturepipeup.Name = "picturepipeup";
            this.picturepipeup.Size = new System.Drawing.Size(108, 797);
            this.picturepipeup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturepipeup.TabIndex = 1;
            this.picturepipeup.TabStop = false;
            this.picturepipeup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            // 
            // pictureBird
            // 
            this.pictureBird.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBird.Image = global::Flappy_Bird.Properties.Resources.Bird;
            this.pictureBird.Location = new System.Drawing.Point(187, 413);
            this.pictureBird.Name = "pictureBird";
            this.pictureBird.Size = new System.Drawing.Size(81, 50);
            this.pictureBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBird.TabIndex = 0;
            this.pictureBird.TabStop = false;
            this.pictureBird.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            // 
            // Scoreline
            // 
            this.Scoreline.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Scoreline.Location = new System.Drawing.Point(570, -266);
            this.Scoreline.Name = "Scoreline";
            this.Scoreline.Size = new System.Drawing.Size(108, 3979);
            this.Scoreline.TabIndex = 8;
            this.Scoreline.TabStop = false;
            this.Scoreline.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            // 
            // FlappyBox1
            // 
            this.FlappyBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FlappyBox1.BackColor = System.Drawing.Color.Transparent;
            this.FlappyBox1.Image = global::Flappy_Bird.Properties.Resources.pngwing_com__4_;
            this.FlappyBox1.Location = new System.Drawing.Point(187, 102);
            this.FlappyBox1.Name = "FlappyBox1";
            this.FlappyBox1.Size = new System.Drawing.Size(396, 305);
            this.FlappyBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlappyBox1.TabIndex = 10;
            this.FlappyBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(782, 971);
            this.Controls.Add(this.buttoncontinue);
            this.Controls.Add(this.buttonmenu);
            this.Controls.Add(this.buttonstart);
            this.Controls.Add(this.picturepipedown);
            this.Controls.Add(this.picturepipeup);
            this.Controls.Add(this.pictureBird);
            this.Controls.Add(this.Scoreline);
            this.Controls.Add(this.FlappyBox1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Best);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "FlappyBird";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.picturepipedown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturepipeup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scoreline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBird;
        private System.Windows.Forms.PictureBox picturepipeup;
        private System.Windows.Forms.PictureBox picturepipedown;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonstart;
        private System.Windows.Forms.Button buttonmenu;
        private System.Windows.Forms.Button buttoncontinue;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox Scoreline;
        private System.Windows.Forms.Label Best;
        private System.Windows.Forms.PictureBox FlappyBox1;
    }
}

