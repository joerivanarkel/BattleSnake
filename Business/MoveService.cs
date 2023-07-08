using Common;
using Common.Game;
using Common.Requests;

namespace Business;

public class MoveService
{
    public RequestModel Request { get; set; }
    public CollisionService CollisionService { get; set; } = new();

    public MoveService(RequestModel request)
    {
        Request = request;
    }

    public async Task<MoveResponse> CalculateMove()
    {
        Coordinate head = Request.you.Head;
        Coordinate food = GetClosestFood(Request.board.Food, head);

        int xDiff = food.X - head.X;
        int yDiff = food.Y - head.Y;

        MoveResponse moveResponse = new MoveResponse("up", "I'm going up!");

        if (xDiff > 0)
        {
            moveResponse = new MoveResponse("right", "I'm going right!");
        }
        else if (xDiff < 0)
        {
            moveResponse = new MoveResponse("left", "I'm going left!");
        }
        else if (yDiff > 0)
        {
            moveResponse = new MoveResponse("up", "I'm going up!");
        }
        else if (yDiff < 0)
        {
            moveResponse = new MoveResponse("down", "I'm going down!");
        }
        
        return CollisionService.CheckCollision(moveResponse, Request) ? EmptyMove() : moveResponse;
    }

    private Coordinate GetClosestFood(List<Coordinate> foodList, Coordinate head)
    {
        Coordinate closestFood = foodList[0];
        double closestDistance = head.Distance(closestFood);

        foreach (Coordinate coordinate in foodList)
        {
            double distance = head.Distance(coordinate);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestFood = coordinate;
            }
        }

        return closestFood;
    }

    private MoveResponse EmptyMove()
    {
        MoveResponse moveResponse = new MoveResponse("up", "I'm going up!");

        if(!CollisionService.CheckCollision(moveResponse, Request))
        {
            return moveResponse;
        }

        moveResponse = new MoveResponse("right", "I'm going right!");
        if(!CollisionService.CheckCollision(moveResponse, Request))
        {
            return moveResponse;
        }

        moveResponse = new MoveResponse("left", "I'm going left!");
        if(!CollisionService.CheckCollision(moveResponse, Request))
        {
            return moveResponse;
        }

        moveResponse = new MoveResponse("down", "I'm going down!");
        if(!CollisionService.CheckCollision(moveResponse, Request))
        {
            return moveResponse;
        }

        return moveResponse;
    }



}