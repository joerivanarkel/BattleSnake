using Common.You;

namespace Common.Board;

// {
//   "id": "totally-unique-snake-id",
//   "name": "Sneky McSnek Face",
//   "health": 54,
//   "body": [
//     {"x": 0, "y": 0}, 
//     {"x": 1, "y": 0}, 
//     {"x": 2, "y": 0}
//   ],
//   "latency": "123",
//   "head": {"x": 0, "y": 0},
//   "length": 3,
//   "shout": "why are we shouting??",
//   "squad": "1",
//   "customizations":{
//     "color":"#26CF04",
//     "head":"smile",
//     "tail":"bolt"
//   }
// }

public class Snake
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

    public Snake()
    {
        Body = new List<Coordinate>();
        Customizations = new Customizations();
    }

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