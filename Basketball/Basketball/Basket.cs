using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Basketball
{
    public class Basket
    {
        public event EventHandler<PositionEventArgs> Scored;

        public void Score()
        {
            while (true)
            {
                Thread.Sleep(50);
                Random random = new Random();
                int position = random.Next(0, 2);
                var positionEventArgs = new PositionEventArgs((PlayerPosition)position);
                Scored?.Invoke(this, positionEventArgs);
            }
        }
    }
}
