using Common.Game.Interfaces;
using Common.Board.Interfaces;

namespace Common.Board;

public class BoardModel : IBoardModel
{
    public int Height { get; set; }
    public int Width { get; set; }
    public List<ICoordinate> Food { get; set; }
    public List<ICoordinate> Hazards { get; set; }
    public List<ISnake> Snakes { get; set; }

    public BoardModel(int height, int width, List<ICoordinate> food, List<ICoordinate> hazards, List<ISnake> snakes)
    {
        Height = height;
        Width = width;
        Food = food;
        Hazards = hazards;
        Snakes = snakes;
    }
}

