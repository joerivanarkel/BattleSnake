using Common.Board;
using Common.Game;
using Common.Game.Interfaces;
using Common.Requests;
using Common.Requests.Interfaces;

namespace Application;

public class CollisionService
{
    private ICoordinate NextMove { get; set; }
    private IRequestModel Request { get; set; }

    public bool CheckCollision(IMoveResponse moveResponse, IRequestModel request)
    {
        NextMove = GetNextMove(moveResponse);
        Request = request;

        return CheckWallCollision() || CheckSelfCollision() || CheckOtherSnakeCollision();
    }

    private ICoordinate GetNextMove(IMoveResponse moveResponse)
    {
        ICoordinate head = Request.you.Head;
        ICoordinate next = head;

        switch (moveResponse.Move)
        {
            case "up":
                next = new Coordinate(head.X, head.Y + 1);
                break;
            case "down":
                next = new Coordinate(head.X, head.Y - 1);
                break;
            case "left":
                next = new Coordinate(head.X - 1, head.Y);
                break;
            case "right":
                next = new Coordinate(head.X + 1, head.Y);
                break;
        }

        return next;
    }

    private bool CheckWallCollision()
    {
        if (NextMove.X < 0 || NextMove.X >= Request.board.Width || NextMove.Y < 0 || NextMove.Y >= Request.board.Height)
        {
            return true;
        }

        return false;
    }

    private bool CheckSelfCollision()
    {
        foreach (Coordinate coordinate in Request.you.Body)
        {
            if (coordinate.X == NextMove.X && coordinate.Y == NextMove.Y)
            {
                return true;
            }
        }

        return false;
    }

    private bool CheckOtherSnakeCollision()
    {
        foreach (Snake snake in Request.board.Snakes)
        {
            if (snake.Id == Request.you.Id)
            {
                continue;
            }

            foreach (Coordinate coordinate in snake.Body)
            {
                if (coordinate.X == NextMove.X && coordinate.Y == NextMove.Y)
                {
                    return true;
                }
            }
        }

        return false;
    }
}