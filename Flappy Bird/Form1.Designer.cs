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
            this.picturepipedown = new System.Windows.Forms.PictureBox();
            this.picturepipeup = new System.Windows.Forms.PictureBox();
            this.pictureBird = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonstart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturepipedown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturepipeup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBird)).BeginInit();
            this.SuspendLayout();
            // 
            // picturepipedown
            // 
            this.picturepipedown.Image = global::Flappy_Bird.Properties.Resources.pipe2;
            this.picturepipedown.Location = new System.Drawing.Point(588, 290);
            this.picturepipedown.Name = "picturepipedown";
            this.picturepipedown.Size = new System.Drawing.Size(111, 830);
            this.picturepipedown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturepipedown.TabIndex = 2;
            this.picturepipedown.TabStop = false;
            this.picturepipedown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            // 
            // picturepipeup
            // 
            this.picturepipeup.Image = global::Flappy_Bird.Properties.Resources.pipe;
            this.picturepipeup.Location = new System.Drawing.Point(588, -632);
            this.picturepipeup.Name = "picturepipeup";
            this.picturepipeup.Size = new System.Drawing.Size(111, 764);
            this.picturepipeup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturepipeup.TabIndex = 1;
            this.picturepipeup.TabStop = false;
            this.picturepipeup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            // 
            // pictureBird
            // 
            this.pictureBird.Image = global::Flappy_Bird.Properties.Resources.Bird;
            this.pictureBird.Location = new System.Drawing.Point(169, 161);
            this.pictureBird.Name = "pictureBird";
            this.pictureBird.Size = new System.Drawing.Size(100, 50);
            this.pictureBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBird.TabIndex = 0;
            this.pictureBird.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonstart
            // 
            this.buttonstart.Location = new System.Drawing.Point(302, 171);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(129, 50);
            this.buttonstart.TabIndex = 3;
            this.buttonstart.Text = "Почати";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonstart);
            this.Controls.Add(this.picturepipedown);
            this.Controls.Add(this.picturepipeup);
            this.Controls.Add(this.pictureBird);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.picturepipedown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturepipeup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBird)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBird;
        private System.Windows.Forms.PictureBox picturepipeup;
        private System.Windows.Forms.PictureBox picturepipedown;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonstart;
    }
}

