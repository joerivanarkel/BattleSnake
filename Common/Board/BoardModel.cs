namespace Common.Board;

// {
//   "height": 11,
//   "width": 11,
//   "food": [
//     {"x": 5, "y": 5}, 
//     {"x": 9, "y": 0}, 
//     {"x": 2, "y": 6}
//   ],
//   "hazards": [
//     {"x": 0, "y": 0}, 
//     {"x": 0, "y": 1}, 
//     {"x": 0, "y": 2}
//   ],
//   "snakes": [
//     {"id": "snake-one", ... },
//     {"id": "snake-two", ... },
//     {"id": "snake-three", ... }
//   ]
// }

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