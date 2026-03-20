using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGamesWinFormsApp
{
    public class RandomPointComponent : IBallComponent
    {
        public void Update(Ball ball, Form form)
        {
            Random random = new Random();
            ball.X = random.Next(0, form.ClientSize.Width);
            ball.Y = random.Next(0, form.ClientSize.Height);
        }
    }
}
