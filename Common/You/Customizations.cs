namespace Common.You;



/// <summary>
/// Represents the customizations for a BattleSnake.
/// </summary>

/// <remarks>
/// This is the input JSON for customizations: <br/>
/// "customizations":{<br/>
///     "color":"#26CF04",<br/>
///     "head":"smile",<br/>
///     "tail":"bolt"<br/>
/// }<br/>
/// </remarks>

public class Customizations
{
    public string Color { get; set; }
    public string Head { get; set; }
    public string Tail { get; set; }

    public Customizations()
    {
    }

    public Customizations(string color, string head, string tail)
    {
        Color = color;
        Head = head;
        Tail = tail;
    }

}