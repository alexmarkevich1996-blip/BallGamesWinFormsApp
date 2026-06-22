using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace Core
{
    public class Ball
    {
        protected Form Form { get; set; }
        private Graphics Graphics { get; set; }
        protected int CenterX { get; set; }
        protected int CenterY { get; set; }
        protected int Vx { get; set; }
        protected int Vy { get; set; }
        protected int Radius { get; set; }
        private Timer timer;
        protected static Random Random = new Random();
        public Ball(Form form)
        {
            Form = form;
            Graphics = form.CreateGraphics();
            CenterX = 150;
            CenterY = 150;
            Vx = 5;
            Vy = -5;
            Radius = 25;
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Move();
        }
        public void Move()
        {
            Clear();
            Go();
            Show();
        }
        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public bool IsMovable()
        {
            return timer.Enabled;
        }

        public int LeftSide()
        {
            return Radius;
        }

        public int RightSide()
        {
            return Form.ClientSize.Width - Radius;
        }

        public int TopSide()
        {
            return Radius;
        }
        public int DownSide()
        {
            return Form.ClientSize.Height - Radius;
        }

        public bool OnForm()
        {
            if (CenterX >= LeftSide() && CenterX <= RightSide() && CenterY >= TopSide() && CenterY <= DownSide())
            {
                return true;
            }
            return false;
        }

        public bool Exists(int pointX, int pointY)
        {
            var dx = pointX - CenterX;
            var dy = pointY - CenterY;

            return dx * dx + dy * dy <= Radius * Radius;

        }

        public void Show()
        {
            var brush = Brushes.Red;
            Draw(brush);
        }

        public void Clear()
        {
            var brush = new SolidBrush(Form.BackColor);
            Draw(brush);
        }

        protected virtual void Go()
        {
            CenterX += Vx;
            CenterY += Vy;
        }

        public bool Contains(int pointX, int pointY)
        {
            var radius = Radius / 2;
            var centerX = CenterX + radius;
            var centerY = CenterY + radius;

            return (centerX - pointX) * (centerX - pointX) + (centerY - pointY) * (centerY - pointY) <= radius * radius;
        }

        private void Draw(Brush brush)
        {
            var rectangle = new Rectangle(CenterX - Radius, CenterY - Radius, 2 * Radius, 2 * Radius);
            Graphics.FillEllipse(brush, rectangle);
        }
    }
}
