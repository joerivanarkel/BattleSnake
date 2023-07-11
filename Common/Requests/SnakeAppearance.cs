using Common.Requests.Interfaces;

namespace Common.Requests;

public class SnakeAppearance : ISnakeAppearance
{
    public string Apiversion { get; set; }
    public string Author { get; set; }
    public string Color { get; set; }
    public string Head { get; set; }
    public string Tail { get; set; }
    public string Version { get; set; }

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