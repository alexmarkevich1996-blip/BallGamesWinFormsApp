using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace BallGamesWinFormsApp
{
    public enum Direction
    {
        TopRight,
        BottomRight,
        BottomLeft,
        TopLeft
    }
    public class MovingBall : Ball
    {
        private Timer timer { get; set; }
        protected Direction Direction { get; set; }
        protected int VX { get; set; }
        protected int VY { get; set; }
        public MovingBall(Form form, Timer timer) : base(form)
        {
            this.timer = timer;
            VX = 1;
            VY = 1;
        }
        public void Start()
        {
            timer.Enabled = true;
        }

        public void Stop()
        {
            timer.Enabled = false;
        }

        public void Move()
        {
            Clear();
            Go(Direction);
            Draw();
        }

        private void Go(Direction direction)
        {
            switch (direction)
            {
                case Direction.BottomRight:
                    X += VX;
                    Y += VY;
                    break;
                case Direction.TopRight:
                    X += VX;
                    Y -= VY;
                    break;
                case Direction.TopLeft:
                    X -= VX;
                    Y -= VY;
                    break;
                case Direction.BottomLeft:
                    X -= VX;
                    Y += VY;
                    break;
                default: throw new Exception("Not right code number for Direction");
            }
            
        }

        private void Clear()
        {
            var graphics = Form.CreateGraphics();
            var brush = Brushes.White;
            var rectangle = new Rectangle(X - Size / 2, Y - Size / 2, Size, Size);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}
