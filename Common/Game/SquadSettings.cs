namespace Common.Game;



/// <summary>
/// Represents the settings for a squad in a BattleSnake game.
/// </summary>
/// 
/// <remarks>
/// This is the input JSON for a squad: <br/>
/// "squad": {<br/>
///    "allowBodyCollisions": false,<br/>
///    "sharedElimination": false,<br/>
///    "sharedHealth": false,<br/>
///    "sharedLength": false<br/>
///}<br/>
/// </remarks>
public class SquadSettings
{
    public bool AllowBodyCollisions { get; set; }
    public bool SharedElimination { get; set; }
    public bool SharedHealth { get; set; }
    public bool SharedLength { get; set; }

    public SquadSettings()
    {
    }
    
    public SquadSettings(bool allowBodyCollisions, bool sharedElimination, bool sharedHealth, bool sharedLength)
    {
        AllowBodyCollisions = allowBodyCollisions;
        SharedElimination = sharedElimination;
        SharedHealth = sharedHealth;
        SharedLength = sharedLength;
    }
}