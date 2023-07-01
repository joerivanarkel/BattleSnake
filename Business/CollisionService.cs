using Common.Board;
using Common.Game;
using Common.Requests;

namespace Business;

public class CollisionService
{
    public Coordinate NextMove { get; set; }

    public RequestModel Request { get; set; }

    public CollisionService(RequestModel request, MoveResponse moveResponse)
    {
        Request = request;
        NextMove = GetNextMove(moveResponse);
    }

    private Coordinate GetNextMove(MoveResponse moveResponse)
    {
        Coordinate head = Request.you.Head;
        Coordinate next = head;

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

    public bool CheckCollision()
    {
        return CheckWallCollision() || CheckSelfCollision() || CheckOtherSnakeCollision();
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