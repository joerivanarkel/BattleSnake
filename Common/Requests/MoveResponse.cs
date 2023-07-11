using Common.Requests.Interfaces;

namespace Common.Requests;

public class MoveResponse : IMoveResponse
{
    public string Move { get; set; }
    public string Shout { get; set; }

    public MoveResponse(string move, string shout)
    {
        Move = move;
        Shout = shout;
    }
}