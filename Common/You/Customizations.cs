namespace Common.You;

//   "customizations":{
//     "color":"#26CF04",
//     "head":"smile",
//     "tail":"bolt"
//   }

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