using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGamesWinFormsApp
{
    public interface IBallComponent
    {
        public void Update(Ball ball, Form form);
    }
}
