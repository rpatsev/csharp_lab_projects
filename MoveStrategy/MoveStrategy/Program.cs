using System;
using MoveStrategy.Strategies;
using MoveStrategy.SurfaceComputers;

namespace MoveStrategy
{
  class Program
  {
    static void Main(string[] args)
    {
      var movableObject 
        = new MovableObject<
            RectangleMoveStrategy,
            SineSurfaceComputer>();

      Console.WriteLine(
        $"Sine trajectory is: {movableObject.Move()}");

      movableObject
        .SetComputeStrategy<CosineSurfaceComputer>();

      Console.WriteLine(
        $"Cosine trajectory is: {movableObject.Move()}");

      movableObject
        .SetComputeStrategy<EllipseSurfaceComputer>();

      Console.WriteLine(
        $"Ellipse trajectory is: {movableObject.Move()}");

      Console.ReadKey();
    }
  }
}
