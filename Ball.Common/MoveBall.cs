using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace Core
{
    public class MoveBall : RandomPointBall
    {

        public MoveBall(Form form) : base(form)
        {

            Vx = GeneratRandomProjection();
            Vy = GeneratRandomProjection();
        }
        private int GeneratRandomProjection()
        {
            var randomDouble = Random.NextDouble();
            var sign = 1;
            if (randomDouble < 0.5)
                sign = -1;
            return Random.Next(2, 5) * sign;
        }
    }
}
