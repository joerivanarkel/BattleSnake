namespace Common.Game;

/// <summary>
/// Represents a coordinate in a two-dimensional space.
/// </summary>
public class Coordinate
{
    public int X { get; set; }
    public int Y { get; set; }

    public Coordinate()
    {
    }

    public Coordinate(int x, int y)
    {
        X = x;
        Y = y;
    }

    public double Distance(Coordinate coord)
    {
        return Math.Abs(coord.X - X) + Math.Abs(coord.Y - Y);
    }
}