using Common.Game.Interfaces;
using Common.Game;
using Common.You.Interfaces;

namespace Common.You;

public class YouModel : IYouModel
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

    public YouModel(string id, string name, int health, List<ICoordinate> body, int latency, Coordinate head, int length, string shout, string squad, Customizations customizations)
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