namespace Common.Game;

/// <summary>
/// Represents a game model in the BattleSnake game.
/// </summary>

/// <remarks>
/// This is the input JSON for a game: <br/>
/// { <br/>
///   "id": "totally-unique-game-id", <br/>
///   "ruleset": { <br/>
///     "name": "standard", <br/>
///     "version": "v1.2.3" <br/>
///   }, <br/>
///   "map": "standard", <br/>
///   "timeout": 500, <br/>
///   "source": "league" <br/>
/// } <br/>
/// </remarks>
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