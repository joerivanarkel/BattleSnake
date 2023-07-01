namespace Common.Board;

using Common.Game;

/// <summary>
/// Represents the game board model, including its dimensions, food locations, hazards, and snakes.
/// </summary>

/// <remarks>
/// This is the input JSON for a board: <br/>
/// <code>
/// {<br/>
///  "height": 11,<br/>
///  "width": 11,<br/>
///  "food": [<br/>
///    {"x": 5, "y": 5}, <br/>
///    {"x": 9, "y": 0}, <br/>
///    {"x": 2, "y": 6}<br/>
///  ],<br/>
///  "hazards": [<br/>
///    {"x": 0, "y": 0}, <br/>
///    {"x": 0, "y": 1}, <br/>
///    {"x": 0, "y": 2}<br/>
///  ],<br/>
///  "snakes": [<br/>
///    {"id": "snake-one", ... },<br/>
///    {"id": "snake-two", ... },<br/>
///    {"id": "snake-three", ... }<br/>
///  ]<br/>
/// }<br/>
/// </code>
/// </remarks>
public class BoardModel
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