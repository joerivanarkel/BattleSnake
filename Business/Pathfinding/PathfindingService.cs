namespace Common.Pathfinding;

public class PathfindingService
{
    public Coordinate Head { get; set; }
    public List<Coordinate> Food { get; set; }
    public List<Coordinate> Obstacles { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public PathfindingService(Coordinate head, List<Coordinate> food, List<Coordinate> obstacles, int width, int height)
    {
        Head = head;
        Food = food;
        Obstacles = obstacles;
        Width = width;
        Height = height;
    }

    public List<Coordinate> GetPathToFood()
    {
        Coordinate closestFood = GetClosestFood();
        var path = GetPath(closestFood);
        return path;
    }

    private Coordinate GetClosestFood()
    {
        Coordinate closestFood = new Coordinate();
        double closestDistance = 1000000;
        foreach (Coordinate foodCoordinate in Food)
        {
            double distance = foodCoordinate.Distance(Head);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestFood = foodCoordinate;
            }
        }
        return closestFood;
    }

    private List<Coordinate> GetPath(Coordinate closestFood)
    {
        List<Coordinate> path = new List<Coordinate>();
        while (Head.X != closestFood.X || Head.Y != closestFood.Y)
        {
            Coordinate next = GetNextMove(closestFood);
            path.Add(next);
            Head = new Coordinate(Head.X + next.X, Head.Y + next.Y);
        }
        return path;
    }

    private Coordinate GetNextMove(Coordinate target)
    {
        // Calculate the Manhattan distance between the head and the food
        int dx = Math.Abs(Head.X - target.X);
        int dy = Math.Abs(Head.Y - target.Y);
        int distance = dx + dy;

        // Calculate the moves that go closest to the food
        List<Coordinate> moves = new List<Coordinate>();
        if (Head.X < target.X) moves.Add(new Coordinate(1, 0));
        if (Head.X > target.X) moves.Add(new Coordinate(-1, 0));
        if (Head.Y < target.Y) moves.Add(new Coordinate(0, 1));
        if (Head.Y > target.Y) moves.Add(new Coordinate(0, -1));

        // Sort the moves by their distance to the food
        moves.Sort((a, b) =>
        {
            int adx = Math.Abs(Head.X + a.X - target.X);
            int ady = Math.Abs(Head.Y + a.Y - target.Y);
            int bdx = Math.Abs(Head.X + b.X - target.X);
            int bdy = Math.Abs(Head.Y + b.Y - target.Y);
            int adistance = adx + ady;
            int bdistance = bdx + bdy;
            return adistance.CompareTo(bdistance);
        });

        // Check for collisions and return the next best move if necessary
        foreach (Coordinate move in moves)
        {
            Coordinate next = new Coordinate(Head.X + move.X, Head.Y + move.Y);
            if (next.X < 0 || next.X >= Width || next.Y < 0 || next.Y >= Height || Obstacles.Contains(next))
            {
                continue;
            }
            return move;
        }

        // If all moves result in a collision, return null
        return null;
    }
}