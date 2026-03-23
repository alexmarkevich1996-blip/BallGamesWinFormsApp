using Ball.Common;

namespace CatchMe2_WinFormsApp
{
    public partial class MainForm : Form
    {
        private List<RandomMoveBall> moveBalls;
        private int countBalls = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            clearButton.Enabled = false;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            createButton.Enabled = false;
            clearButton.Enabled = true;

            moveBalls = new List<RandomMoveBall>();
            for (int i = 0; i < 5; i++)
            {
                var moveBall = new RandomMoveBall(this);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            foreach (var moveBall in moveBalls)
            {
                moveBall.Stop();
                moveBall.Clear();
            }
            countBalls = 0;
            countBallsLabel.Text = countBalls.ToString();
            createButton.Enabled = true;
            clearButton.Enabled = false;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {

            if (moveBalls != null)
            {
                foreach (var ball in moveBalls)
                {
                    if (ball.IsMovable() && ball.Contains(e.X, e.Y))
                    {
                        ball.Stop();
                        countBalls++;
                    }
                }

                countBallsLabel.Text = countBalls.ToString();
            }
            
        }
    }
}
