using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGamesWinFormsApp
{
    public class RandomSizeComponent : IBallComponent
    {

        public void Update(Ball ball, Form form)
        {
            Random random = new Random();
            ball.Size = random.Next(20, 60);
        }
    }
}
