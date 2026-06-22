using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class RandomPointBall : Ball
    {
       
        public RandomPointBall(Form form) : base(form)
        {
            CenterX = Random.Next(LeftSide(), RightSide());
            CenterY = Random.Next(TopSide(), DownSide());
        }
    }
}
