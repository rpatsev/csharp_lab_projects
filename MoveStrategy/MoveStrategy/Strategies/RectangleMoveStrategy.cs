using System.Collections.Generic;
using MoveStrategy.Points;

namespace MoveStrategy.Strategies
{
  public class RectangleMoveStrategy: IMoveStrategy
  {
    public List<DoublePoint> GetTrajectory()
      => new List<DoublePoint>
      {
        DoublePoint.Create(0, 0),
        DoublePoint.Create(10, 0),
        DoublePoint.Create(10, 5),
        DoublePoint.Create(0, 5)
      };
  }
}
