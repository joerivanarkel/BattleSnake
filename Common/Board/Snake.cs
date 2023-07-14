using Common.You.Interfaces;
using Common.Game.Interfaces;
using Common.Board.Interfaces;
using Common.You;
using Common.Game;

namespace Common.Board;

public class Snake : ISnake
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int Health { get; set; }
    public List<ICoordinate> Body { get; set; }
    public int Latency { get; set; }
    public ICoordinate Head { get; set; }
    public int Length { get; set; }
    public string Shout { get; set; }
    public string Squad { get; set; }
    public ICustomizations Customizations { get; set; }

    public Snake(string id, string name, int health, List<ICoordinate> body, int latency, Coordinate head, int length, string shout, string squad, Customizations customizations)
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
