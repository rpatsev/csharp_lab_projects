using System;
using MoveStrategy.Points;

namespace MoveStrategy.SurfaceComputers
{
  public class SineSurfaceComputer : ICanComputeZ
  {
    public double ComputeZ(DoublePoint p)
      => Math.Sin(p.X + p.Y);
  }
}
