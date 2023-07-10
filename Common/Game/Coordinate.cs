namespace Common.Game;

using Common.Game.Interfaces;

public class Coordinate : ICoordinate
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
