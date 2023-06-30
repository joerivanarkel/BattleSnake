namespace Common;

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

    public double Distance(Coordinate head)
    {
        return Math.Abs(head.X - X) + Math.Abs(head.Y - Y);
    }
}