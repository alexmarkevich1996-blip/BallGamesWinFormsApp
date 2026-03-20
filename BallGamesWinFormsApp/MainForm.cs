namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
        BallsStorage ballsStorage { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateBallsButton_Click(object sender, EventArgs e)
        {
            ballsStorage = new BallsStorage(this, timerForBall);
            ballsStorage.Start();
        }

        private void timerForBall_Tick(object sender, EventArgs e)
        {
            ballsStorage.Move();
        }

        private void stopBallsButton_Click(object sender, EventArgs e)
        {
            ballsStorage.Stop();
        }
    }
}
