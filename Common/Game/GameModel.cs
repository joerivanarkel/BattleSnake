using Common.Game.Interfaces;

namespace Common.Game;

public class GameModel : IGameModel
{
    public string Id { get; set; }
    public IRuleset Ruleset { get; set; }
    public string Map { get; set; }
    public int Timeout { get; set; }
    public string Source { get; set; }

    public GameModel(string id, Ruleset ruleset, string map, int timeout, string source)
    {
        Id = id;
        Ruleset = ruleset;
        Map = map;
        Timeout = timeout;
        Source = source;
    }

}

