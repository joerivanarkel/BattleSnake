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

public class Board
{
    public int Height { get; set; }
    public int Width { get; set; }
    public List<Coordinate> Food { get; set; }
    public List<Coordinate> Hazards { get; set; }
    public List<Snake> Snakes { get; set; }

    public Board()
    {
        Food = new List<Food>();
        Hazards = new List<Hazard>();
        Snakes = new List<Snake>();
    }

    public Board(int height, int width, List<Food> food, List<Hazard> hazards, List<Snake> snakes)
    {
        Height = height;
        Width = width;
        Food = food;
        Hazards = hazards;
        Snakes = snakes;
    }
}