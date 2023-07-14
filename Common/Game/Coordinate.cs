using Common.Game.Interfaces;

namespace Common.Game;

public class Coordinate : ICoordinate
{
    public int X { get; set; }
    public int Y { get; set; }

    public Coordinate(int x, int y)
    {
        X = x;
        Y = y;
    }

    public double Distance(ICoordinate coord)
    {
        return Math.Abs(coord.X - X) + Math.Abs(coord.Y - Y);
    }
}
