namespace Common.Game;



/// <summary>
/// Represents the settings for a BattleSnake Royale game.
/// </summary>

/// <remarks>
/// This is the input JSON for a Royale game: <br/>
///"royale": {<br/>
///     "shrinkEveryNTurns": 0 <br/>
/// }, <br/>
/// </remarks>

public class RoyaleSettings

{
    public int shrinkEveryNTurns { get; set; }

    public RoyaleSettings()
    {
    }
    
    public RoyaleSettings(int shrinkEveryNTurns)
    {
        this.shrinkEveryNTurns = shrinkEveryNTurns;
    }
}