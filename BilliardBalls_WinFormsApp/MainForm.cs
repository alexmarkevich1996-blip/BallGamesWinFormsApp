using Core;

namespace BilliardBalls_WinFormsApp
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                var ball = new BilliardBall(this);
                ball.OnHitted += Ball_OnHitted;
                ball.Start();
                
            }
        }

        private void Ball_OnHitted(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftLabel.Text = (int.Parse(leftLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightLabel.Text = (int.Parse(rightLabel.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topLabel.Text = (int.Parse(topLabel.Text) + 1).ToString();
                    break;
                case Side.Down:
                    downLabel.Text = (int.Parse(downLabel.Text) + 1).ToString();
                    break;
                default:
                    throw new Exception("Unhandled side");
            }
        }
    }
}
