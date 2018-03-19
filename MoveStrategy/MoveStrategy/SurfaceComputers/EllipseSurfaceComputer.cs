using System;
using MoveStrategy.Points;

namespace MoveStrategy.SurfaceComputers
{
  public class EllipseSurfaceComputer : ICanComputeZ
  {
    public double ComputeZ(DoublePoint p)
      => Math.Pow(p.X, 2) + Math.Pow(p.Y, 2);
  }
}
