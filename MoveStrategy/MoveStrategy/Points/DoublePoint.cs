namespace MoveStrategy.Points
{
  public struct DoublePoint
  {
    public readonly double X;

    public readonly double Y;

    private DoublePoint(double x, double y)
    {
      this.X = x;
      this.Y = y;
    }

    public static DoublePoint Create(double x, double y)
      => new DoublePoint(x, y);
  }
}
