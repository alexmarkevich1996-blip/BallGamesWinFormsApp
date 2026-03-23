namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<RandomMoveBall> randomBalls { get; set; }
        public MainForm()
        {

            InitializeComponent();
        }



        private void DrawRandomBallButton_Click(object sender, EventArgs e)
        {
            stopAllBallsButton.Enabled = true;
            createRandomBallButton.Enabled = false;

            randomBalls = new List<RandomMoveBall>();
            for (int i = 0; i < 10; i++)
            {
                var randomBall = new RandomMoveBall(this);
                randomBalls.Add(randomBall);
                randomBall.Show();
                randomBall.Start();
            }
        }

        private void StopAllBallsButton_Click(object sender, EventArgs e)
        {
            var countBalls = 0;

            foreach (var randomBall in randomBalls)
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
            foreach (var randomBall in randomBalls)
            {
                randomBall.Clear();
            }
            createRandomBallButton.Enabled = true;
            clearButton.Enabled = false;
        }
    }
}
