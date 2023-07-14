using Common.Game.Interfaces;

namespace Common.Board.Interfaces;

public interface IBoardModel
{
    int Height { get; set; }
    int Width { get; set; }
    List<ICoordinate> Food { get; set; }
    List<ICoordinate> Hazards { get; set; }
    List<ISnake> Snakes { get; set; }
}