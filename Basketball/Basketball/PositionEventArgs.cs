using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball
{
    public class PositionEventArgs : EventArgs
    {
        public PlayerPosition Position { get; private set; }

        public PositionEventArgs(PlayerPosition playerPosition)
        {
            Position = playerPosition;
        }
    }
}
