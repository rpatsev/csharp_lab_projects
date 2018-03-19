using System;
using System.Linq;
using MoveStrategy.Strategies;
using MoveStrategy.SurfaceComputers;

namespace MoveStrategy
{
  public class MovableObject<T, C>
    where T : IMoveStrategy, new()
    where C : ICanComputeZ, new()
  {
    private readonly IMoveStrategy moveStrategy;
    private ICanComputeZ surfaceComputer;

    public MovableObject()
    {
      this.moveStrategy = new T();
      this.surfaceComputer = new C();
    }

    public string Move()
    {
      var points = this.moveStrategy
        .GetTrajectory()
        .Select(this.surfaceComputer.ComputeZ);

      return string.Join(";", points);
    }

    public void SetComputeStrategy<U>()
      where U : ICanComputeZ, new()
    {
      this.surfaceComputer = new U();
    }
  }
}
