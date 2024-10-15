namespace Flappy_Bird
{
    partial class FlappyBird
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyBird));
            gameTimer = new System.Windows.Forms.Timer(components);
            bird = new PictureBox();
            pipeDown = new PictureBox();
            pipeUp = new PictureBox();
            ground = new PictureBox();
            ScoreText = new Label();
            Restart = new Button();
            Exit = new Button();
            Help = new Button();
            ((System.ComponentModel.ISupportInitialize)bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            SuspendLayout();
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // bird
            // 
            bird.BackColor = Color.Transparent;
            bird.Image = Properties.Resources.bird;
            bird.Location = new Point(12, 270);
            bird.Name = "bird";
            bird.Size = new Size(57, 46);
            bird.SizeMode = PictureBoxSizeMode.StretchImage;
            bird.TabIndex = 0;
            bird.TabStop = false;
            // 
            // pipeDown
            // 
            pipeDown.BackColor = Color.Transparent;
            pipeDown.Image = Properties.Resources.pipe;
            pipeDown.Location = new Point(418, 309);
            pipeDown.Name = "pipeDown";
            pipeDown.Size = new Size(71, 206);
            pipeDown.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeDown.TabIndex = 1;
            pipeDown.TabStop = false;
            // 
            // pipeUp
            // 
            pipeUp.BackColor = Color.Transparent;
            pipeUp.Image = Properties.Resources.pipedown;
            pipeUp.Location = new Point(569, -5);
            pipeUp.Name = "pipeUp";
            pipeUp.Size = new Size(72, 175);
            pipeUp.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeUp.TabIndex = 2;
            pipeUp.TabStop = false;
            // 
            // ground
            // 
            ground.Image = Properties.Resources.ground;
            ground.Location = new Point(0, 511);
            ground.Name = "ground";
            ground.Size = new Size(813, 178);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // ScoreText
            // 
            ScoreText.AutoSize = true;
            ScoreText.BackColor = Color.LemonChiffon;
            ScoreText.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ScoreText.Location = new Point(12, 570);
            ScoreText.Name = "ScoreText";
            ScoreText.Size = new Size(101, 30);
            ScoreText.TabIndex = 4;
            ScoreText.Text = "Score : 0";
            // 
            // Restart
            // 
            Restart.BackColor = Color.Aqua;
            Restart.Font = new Font("Sitka Small", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Restart.Location = new Point(151, 199);
            Restart.Name = "Restart";
            Restart.Size = new Size(124, 100);
            Restart.TabIndex = 5;
            Restart.Text = "Restart";
            Restart.UseVisualStyleBackColor = false;
            Restart.Click += Restart_Click;
            // 
            // Exit
            // 
            Exit.BackColor = Color.Aqua;
            Exit.Font = new Font("Sitka Small", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Exit.Location = new Point(329, 199);
            Exit.Name = "Exit";
            Exit.Size = new Size(129, 100);
            Exit.TabIndex = 6;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // Help
            // 
            Help.BackColor = Color.Aqua;
            Help.Font = new Font("Sitka Small", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Help.Location = new Point(507, 199);
            Help.Name = "Help";
            Help.Size = new Size(134, 100);
            Help.TabIndex = 7;
            Help.Text = "Help";
            Help.UseVisualStyleBackColor = false;
            Help.Click += Help_Click;
            // 
            // FlappyBird
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(812, 688);
            Controls.Add(Help);
            Controls.Add(Exit);
            Controls.Add(Restart);
            Controls.Add(bird);
            Controls.Add(ScoreText);
            Controls.Add(ground);
            Controls.Add(pipeUp);
            Controls.Add(pipeDown);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FlappyBird";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flappy Bird";
            KeyDown += gameKeyDown;
            KeyUp += gameKeyUp;
            ((System.ComponentModel.ISupportInitialize)bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private PictureBox bird;
        private PictureBox pipeDown;
        private PictureBox pipeUp;
        private PictureBox ground;
        private Label ScoreText;
        private Button Restart;
        private Button Exit;
        private Button Help;
    }
}
