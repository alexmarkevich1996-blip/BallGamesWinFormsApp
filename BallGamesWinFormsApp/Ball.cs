using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGamesWinFormsApp
{
    public class Ball
    {
        protected Form Form { get; set; }
        private Graphics Graphics { get; set; }
        protected int X { get; set; }
        protected int Y { get; set; }
        protected int Vx { get; set; }
        protected int Vy { get; set; }
        protected int Size { get; set; }
        protected static Random Random = new Random();
        public Ball(Form form)
        {
            Form = form;
            Graphics = form.CreateGraphics();
            X = 150;
            Y = 150;
            Vx = 5;
            Vy = -5;
            Size = 60;
        }
        public void Move()
        {
            Clear();
            Go();
            Show();
        }

        public void Show()
        {
            var rectangle = new Rectangle(X - Size / 2, Y - Size / 2, Size, Size);
            var brush = Brushes.Aqua;
            Graphics.FillEllipse(brush, rectangle);
        }

        public void Clear()
        {
            var rectangle = new Rectangle(X - Size / 2, Y - Size / 2, Size, Size);
            var brush = new SolidBrush(Form.BackColor);
            Graphics.FillEllipse(brush, rectangle);
        }

        private void Go()
        {
            X += Vx;
            Y += Vy;
        }
    }
}
