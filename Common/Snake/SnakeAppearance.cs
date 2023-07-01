namespace Common.Snake;



/// <summary>
/// Represents the appearance of a snake in the BattleSnake game.
/// </summary>

/// <remarks>
/// This is the input JSON for a snake's appearance: <br/>
/// {<br/>
///  "apiversion": "1",<br/>
///  "author": "joerivanarkel",<br/>
///  "color": "#069420",<br/>
///  "head": "mlh-gene",<br/>
///  "tail": "mlh-gene",<br/>
///  "version": "0.0.1-beta"<br/>
/// }<br/>
/// </remarks>
public class SnakeAppearance
{
    public string Apiversion { get; set; }
    public string Author { get; set; }
    public string Color { get; set; }
    public string Head { get; set; }
    public string Tail { get; set; }
    public string Version { get; set; }

    public SnakeAppearance()
    {
    }

    public SnakeAppearance(string apiversion, string author, string color, string head, string tail, string version)
    {
        Apiversion = apiversion;
        Author = author;
        Color = color;
        Head = head;
        Tail = tail;
        Version = version;
    }
}