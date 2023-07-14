namespace Common.Game.Interfaces;

public interface ICoordinate
{
    int X { get; set; }
    int Y { get; set; }
    double Distance(ICoordinate coord);
}