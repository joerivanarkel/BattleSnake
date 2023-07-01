namespace Common.You;

using Common.Game;

/// <summary>
/// Represents the player's snake in the game.
/// </summary>
/// 
/// <remarks>
/// This is the input JSON for a snake: <br/>
/// {<br/>
///  "id": "totally-unique-snake-id",<br/>
///  "name": "Sneky McSnek Face",<br/>
///  "health": 54,<br/>
///  "body": [<br/>
///    {"x": 0, "y": 0}, <br/>
///    {"x": 1, "y": 0}, <br/>
///    {"x": 2, "y": 0}<br/>
///  ],<br/>
///  "latency": "123",<br/>
///  "head": {"x": 0, "y": 0},<br/>
///  "length": 3,<br/>
///  "shout": "why are we shouting??",<br/>
///  "squad": "1",<br/>
///  "customizations":{<br/>
///    "color":"#26CF04",<br/>
///    "head":"smile",<br/>
///    "tail":"bolt"<br/>
///  }<br/>
/// }<br/>
/// </remarks>
public class YouModel

{
    public string Id { get; set; }
    public string Name { get; set; }
    public int Health { get; set; }
    public List<Coordinate> Body { get; set; }
    public int Latency { get; set; }
    public Coordinate Head { get; set; }
    public int Length { get; set; }
    public string Shout { get; set; }
    public string Squad { get; set; }
    public Customizations Customizations { get; set; }

    public YouModel()
    {
        Body = new List<Coordinate>();
        Customizations = new Customizations();
    }

    public YouModel(string id, string name, int health, List<Coordinate> body, int latency, Coordinate head, int length, string shout, string squad, Customizations customizations)
    {
        Id = id;
        Name = name;
        Health = health;
        Body = body;
        Latency = latency;
        Head = head;
        Length = length;
        Shout = shout;
        Squad = squad;
        Customizations = customizations;
    }

}