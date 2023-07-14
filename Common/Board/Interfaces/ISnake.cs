using Common.Game.Interfaces;
using Common.You.Interfaces;

namespace Common.Board.Interfaces;

public interface ISnake
{
    string Id { get; set; }
    string Name { get; set; }
    int Health { get; set; }
    List<ICoordinate> Body { get; set; }
    int Latency { get; set; }
    ICoordinate Head { get; set; }
    int Length { get; set; }
    string Shout { get; set; }
    string Squad { get; set; }
    ICustomizations Customizations { get; set; }
}