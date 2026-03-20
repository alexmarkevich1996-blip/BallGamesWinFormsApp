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
        protected Graphics Graphics { get; set; }
        internal int X { get; set; }
        internal int Y { get; set; }
        internal int Size { get; set; }

        private List<IBallComponent> components { get; set; }

        public Ball(Form form)
        {
            components = new List<IBallComponent>();
            Form = form;
            Graphics = form.CreateGraphics();
            X = Form.ClientSize.Width / 2;
            Y = Form.ClientSize.Height / 2;
            Size = 60;
        }

        public void Update()
        {
            foreach (var component in components)
            {
                component.Update(this, Form);
            }
        }

        public void AddComponent(IBallComponent component)
        {
            components.Add(component);
        }

        public void Draw()
        {
            var brush = Brushes.Aqua;
            var rectangle = new Rectangle(X - Size/2, Y - Size/2, Size, Size);
            Graphics.FillEllipse(brush, rectangle);
        }
    }
}
