using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class RandomMoveBall : MoveBall
    {

        public RandomMoveBall(Form form) : base(form)
        {
            Vx = Random.Next(-5, 3);
            Vy = Random.Next(-5, 3);
            CenterX = Random.Next(0, form.ClientSize.Width);
            CenterY = Random.Next(0, form.ClientSize.Height);
        }

        
    }
}
