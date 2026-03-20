using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGamesWinFormsApp
{
    public class SpecificPointComponent : IBallComponent
    {
        private int X { get; set; }
        private int Y { get; set; }
        public SpecificPointComponent(Form form, int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Update(Ball ball, Form form)
        {
            ball.X = X;
            ball.Y = Y;
        }
    }
}
