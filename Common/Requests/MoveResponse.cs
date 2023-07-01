namespace Common.Requests;

/// <summary>
/// Represents a response from the server indicating the move to be made by the snake.
/// </summary>

/// <remarks>
/// This is the output JSON for a move response: <br/>
/// {<br/>
///   "move": "up",<br/>
///   "shout": "Moving up!"<br/>
/// }<br/>
/// </remarks>

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