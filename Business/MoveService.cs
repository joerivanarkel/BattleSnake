using Common;
using Common.Pathfinding;

namespace Business;

public class MoveService
{
    public RequestModel Request { get; set; }
    public PathfindingService PathfindingService { get; set; }

    public MoveService(RequestModel request)
    {
        Request = request;
        PathfindingService = new PathfindingService(Request.you.Head, Request.board.Food, GetObstacles(), Request.board.Width, Request.board.Height);
    }

    public async Task<MoveResponse> Move()
    {
        // Get path to food
        // Check if path is safe
        // If not, get path which is safe
        // If no path is safe, get path which is least dangerous

        var pathToFood = await GetPathToFood();

        if (pathToFood == null) return new MoveResponse("up", "No food found");

        var direction = GetDirection(pathToFood);

        return new MoveResponse(direction, "Moving to food");

    }
    private async Task<List<Coordinate>> GetPathToFood()
    {
        var food = Request.board.Food;
        var head = Request.you.Head;
        var obstacles = GetObstacles();

        var nearestFood = food.OrderBy(f => f.Distance(head)).FirstOrDefault();

        if (nearestFood == null) return null;
        
        var pathToFood = PathfindingService.GetPathToFood();

        return pathToFood;
    }

    private List<Coordinate> GetObstacles()
    {
        List<Coordinate> obstacles = new List<Coordinate>();
        obstacles.AddRange(Request.board.Hazards);
        obstacles.AddRange(Request.board.Snakes.SelectMany(s => s.Body));

        return obstacles;
    }

    private string GetDirection(List<Coordinate> path)
    {
        var head = Request.you.Head;
        var next = path[1];

        if (head.X == next.X)
        {
            if (head.Y < next.Y) return "up";
            else return "down";
        }
        else
        {
            if (head.X > next.X) return "left";
            else return "right";
        }
    }


}