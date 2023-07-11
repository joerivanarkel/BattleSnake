namespace Common.Requests.Interfaces;

public interface ISnakeAppearance
{
    string Apiversion { get; set; }
    string Author { get; set; }
    string Color { get; set; }
    string Head { get; set; }
    string Tail { get; set; }
    string Version { get; set; }
}