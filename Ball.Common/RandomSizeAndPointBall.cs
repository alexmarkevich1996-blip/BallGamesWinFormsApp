using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class RandomSizeAndPointBall : RandomPointBall
    {
        public RandomSizeAndPointBall(Form form) : base(form)
        {
            Radius = Random.Next(10, 40);
        }
    }
}
