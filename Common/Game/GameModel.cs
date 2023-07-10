namespace Common.Game;

using Common.Game.Interfaces;

public class GameModel : IGameModel
{
    public string Id { get; set; }
    public Ruleset Ruleset { get; set; }
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

