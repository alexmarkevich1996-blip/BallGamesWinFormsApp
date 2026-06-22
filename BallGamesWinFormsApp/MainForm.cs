using Core;

namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<Ball> balls { get; set; }
        public MainForm()
        {

            InitializeComponent();
        }



        private void DrawRandomBallButton_Click(object sender, EventArgs e)
        {
            stopAllBallsButton.Enabled = true;
            createRandomBallButton.Enabled = false;

            balls = new List<Ball>();
            for (int i = 0; i < 5; i++)
            {
                var randomBall = new MoveBall(this);
                balls.Add(randomBall);
                randomBall.Show();
                randomBall.Start();
            }
        }

        private void StopAllBallsButton_Click(object sender, EventArgs e)
        {
            var countBalls = 0;

            foreach (var randomBall in balls)
            {
                randomBall.Stop();

                if (randomBall.OnForm())
                    countBalls++;
            }

            MessageBox.Show($"Number of balls within frame is {countBalls}");
            stopAllBallsButton.Enabled = false;
            clearButton.Enabled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            stopAllBallsButton.Enabled = false;
            clearButton.Enabled = false;
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            foreach (var randomBall in balls)
            {
                randomBall.Clear();
            }
            createRandomBallButton.Enabled = true;
            clearButton.Enabled = false;
        }

        
    }
}
