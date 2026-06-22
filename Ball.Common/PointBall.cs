using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class PointBall : Ball
    {
        public PointBall(Form form, int x, int y) : base(form)
        {
            CenterX = x;
            CenterY = y;
        }
    }
}
