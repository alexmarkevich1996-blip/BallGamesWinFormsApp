using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardBalls_WinFormsApp
{

    public class BilliardBall : MoveBall
    {
        public event EventHandler<HitEventArgs> OnHitted; 

        public BilliardBall(Form form) : base(form)
        {

        }

        protected override void Go()
        {
            base.Go();

            if (CenterX <= LeftSide())
            {
                Vx = -Vx;
                OnHitted.Invoke(this, new HitEventArgs(Side.Left));
            }

            if (CenterX >= RightSide())
            {
                Vx = -Vx;
                OnHitted.Invoke(this, new HitEventArgs(Side.Right));
            }

            if (CenterY <= TopSide())
            {
                Vy = -Vy;
                OnHitted.Invoke(this, new HitEventArgs(Side.Top));
            }
            
            if (CenterY >= DownSide())
            {
                Vy = -Vy;
                OnHitted.Invoke(this, new HitEventArgs(Side.Down));
            }
        }
    }
}
