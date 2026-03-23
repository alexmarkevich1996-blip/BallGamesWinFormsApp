using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball.Common
{
    public class RandomMoveBall : MoveBall
    {

        public RandomMoveBall(Form form) : base(form)
        {
            Vx = Random.Next(-5, 3);
            Vy = Random.Next(-5, 3);
            X = Random.Next(0, form.ClientSize.Width);
            Y = Random.Next(0, form.ClientSize.Height);
        }

        public bool OnForm()
        {
            if (X >= 0 && Y >= 0 && X+Size <= Form.ClientSize.Width && Y+Size <= Form.ClientSize.Height)
            {
                return true;
            }
            return false;
        }
    }
}
