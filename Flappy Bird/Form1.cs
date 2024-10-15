namespace Flappy_Bird
{
    public partial class FlappyBird : Form
    {
        int gravity = 8;
        int score = 0;
        int pipeSpeed = 5;
        int maxGravity = 12;
        int initialPipeUpPosition = 800;
        int initialPipeDownPosition = 950;

        public FlappyBird()
        {
            InitializeComponent();
            KeyPreview = true;
            Restart.Visible = false;
            Exit.Visible = false;
            Help.Visible = false;

            pipeUp.Left = initialPipeUpPosition;
            pipeDown.Left = initialPipeDownPosition;
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            if (gravity < maxGravity)
            {
                gravity += 1;
            }

            bird.Top += gravity;
            pipeUp.Left -= pipeSpeed;
            pipeDown.Left -= pipeSpeed;

            if (pipeUp.Left < -130)
            {
                pipeUp.Left = initialPipeUpPosition;
                score++;
                ScoreText.Text = $" Score : {score} ";
            }

            if (pipeDown.Left < -80)
            {
                pipeDown.Left = initialPipeDownPosition;
                score++;
                ScoreText.Text = $" Score : {score} ";
            }

            if (score > 0 && score % 5 == 0 && pipeUp.Left == initialPipeUpPosition)
            {
                pipeSpeed++;
            }

            if
            (
                bird.Bounds.IntersectsWith(ground.Bounds) ||
                bird.Bounds.IntersectsWith(pipeUp.Bounds) ||
                bird.Bounds.IntersectsWith(pipeDown.Bounds) ||
                bird.Top < 5
            )
            {
                endGame();
                Restart.Visible = true;
                Exit.Visible = true;
                Help.Visible = true;
            }
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -8;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 8;
            }
        }

        private void endGame()
        {
            gameTimer.Stop(); 
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void RestartGame()
        {
            bird.Location = new Point(100, 200);
            pipeUp.Left = initialPipeUpPosition;
            pipeDown.Left = initialPipeDownPosition;
            score = 0;
            ScoreText.Text = "Score: 0";
            gravity = 8;
            pipeSpeed = 5;
            gameTimer.Start();
         
            Restart.Visible = false;
            Exit.Visible = false;
            Help.Visible = false;

            this.Focus();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press Space to fly");
        }
    }
}
