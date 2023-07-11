using Common.You;
using Common.Game;
using Common.Board.Interfaces;

namespace Common.Board;

public class Snake : ISnake
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

    public Snake(string id, string name, int health, List<Coordinate> body, int latency, Coordinate head, int length, string shout, string squad, Customizations customizations)
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
