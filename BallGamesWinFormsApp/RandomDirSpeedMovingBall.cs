using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace BallGamesWinFormsApp
{
    public class RandomDirSpeedMovingBall : MovingBall
    {
        Random random { get; set; }
        public RandomDirSpeedMovingBall(Form form, Timer timer) : base(form, timer)
        {
            random = new Random();
            var randomDirection = (Direction)random.Next(0, 4);
            Direction = randomDirection;
            VX = random.Next(1, 3);
            VY = random.Next(1, 3);
        }
    }
}
