using Common.You.Interfaces;

namespace Common.You;

public class Customizations : ICustomizations
{
    public string Color { get; set; }
    public string Head { get; set; }
    public string Tail { get; set; }

    public Customizations(string color, string head, string tail)
    {
        Color = color;
        Head = head;
        Tail = tail;
    }
}