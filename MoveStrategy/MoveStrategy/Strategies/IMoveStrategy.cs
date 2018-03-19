using System.Collections.Generic;
using MoveStrategy.Points;

namespace MoveStrategy.Strategies
{
  public interface IMoveStrategy
  {
    List<DoublePoint> GetTrajectory();
  }
}
