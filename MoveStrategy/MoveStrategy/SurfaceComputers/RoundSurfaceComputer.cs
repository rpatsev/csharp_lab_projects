using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoveStrategy.Points;

namespace MoveStrategy.SurfaceComputers
{
    class RoundSurfaceComputer : ICanComputeZ
    {
        public double ComputeZ(DoublePoint point)
            => 2 * Math.Pow(point.X, 2);

    }
}
