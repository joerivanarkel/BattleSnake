namespace Common.Board;

using Common.Game;
using Common.Board.Interfaces;

public class BoardModel : IBoardModel
{
    public int Height { get; set; }
    public int Width { get; set; }
    public List<Coordinate> Food { get; set; }
    public List<Coordinate> Hazards { get; set; }
    public List<Snake> Snakes { get; set; }

    public BoardModel()
    {
        Food = new List<Coordinate>();
        Hazards = new List<Coordinate>();
        Snakes = new List<Snake>();
    }

    public BoardModel(int height, int width, List<Coordinate> food, List<Coordinate> hazards, List<Snake> snakes)
    {
        Height = height;
        Width = width;
        Food = food;
        Hazards = hazards;
        Snakes = snakes;
    }
}

