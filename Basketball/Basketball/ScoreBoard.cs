using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball
{
    class ScoreBoard
    {
        public int Score { get; private set; }

        public event EventHandler ScoreAdded;

        public void AddScore(object sender, PositionEventArgs e)
        {
            switch (e.Position)
            {
                case PlayerPosition._1:
                    Score += 2;
                    break;
                case PlayerPosition._2:
                    Score += 3;
                    break;
                default:
                    throw new NotImplementedException();
            }

            ScoreAdded?.Invoke(this, new EventArgs());
        }
    }
}
