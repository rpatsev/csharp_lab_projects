using System;
using MoveStrategy.Points;

namespace MoveStrategy.SurfaceComputers
{
  public class CosineSurfaceComputer : ICanComputeZ
  {
    public double ComputeZ(DoublePoint p)
      => Math.Cos(p.X + p.Y);
  }
}
