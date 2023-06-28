namespace Common.Game;

// {
//   "id": "totally-unique-game-id",
//   "ruleset": {
//     "name": "standard",
//     "version": "v1.2.3"
//   },
//   "map": "standard",
//   "timeout": 500,
//   "source": "league"
// }

public class GameModel
{
    public string Id { get; set; }
    public Ruleset Ruleset { get; set; }
    public string Map { get; set; }
    public int Timeout { get; set; }
    public string Source { get; set; }

    public GameModel()
    {
    }

    public GameModel(string id, Ruleset ruleset, string map, int timeout, string source)
    {
        Id = id;
        Ruleset = ruleset;
        Map = map;
        Timeout = timeout;
        Source = source;
    }

}