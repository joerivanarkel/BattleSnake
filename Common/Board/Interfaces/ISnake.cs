using Common.Game;
using Common.You;

namespace Common.Board.Interfaces;

public interface ISnake
{
    string Id { get; set; }
    string Name { get; set; }
    int Health { get; set; }
    List<Coordinate> Body { get; set; }
    int Latency { get; set; }
    Coordinate Head { get; set; }
    int Length { get; set; }
    string Shout { get; set; }
    string Squad { get; set; }
    Customizations Customizations { get; set; }
}