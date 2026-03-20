using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace BallGamesWinFormsApp
{
    public class BallsStorage
    {
        private List<RandomDirSpeedMovingBall> balls { get; set; }
        public BallsStorage(Form form, Timer timer)
        {
            balls = new List<RandomDirSpeedMovingBall>();
            CreateBalls(form, timer);
        }

        private void CreateBalls(Form form, Timer timer)
        {
            for (int i = 0; i < 6; i++)
            {
                var newBall = new RandomDirSpeedMovingBall(form, timer);
                newBall.AddComponent(new RandomPointComponent());
                newBall.Update();
                balls.Add(newBall);
            }
        }

        public void Start()
        {
            foreach(var ball in balls)
            {
                ball.Draw();
                ball.Start();
            }
        }

        public void Move()
        {
            foreach(var ball in balls)
            {
                ball.Move();
            }
        }

        public void Stop()
        {
            foreach(var ball in balls)
            {
                ball.Stop();
            }
        }
    }
}
