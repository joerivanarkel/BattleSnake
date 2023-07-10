namespace Common.Board.Interfaces;

using Common.Game;

public interface IBoardModel
{
    int Height { get; set; }
    int Width { get; set; }
    List<Coordinate> Food { get; set; }
    List<Coordinate> Hazards { get; set; }
    List<Snake> Snakes { get; set; }
}