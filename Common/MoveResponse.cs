namespace Common;

// {
//   "move": "up",
//   "shout": "Moving up!"
// }

public class MoveResponse
{
    public string Move { get; set; }
    public string Shout { get; set; }

    public MoveResponse()
    {
    }

    public MoveResponse(string move, string shout)
    {
        Move = move;
        Shout = shout;
    }
}