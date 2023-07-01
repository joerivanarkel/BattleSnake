namespace Common.Game;



/// <summary>
/// Represents the game settings for a BattleSnake game.
/// </summary>

/// <remarks>
/// This is the input JSON for a game: <br/>
/// "settings": {<br/>
///  "foodSpawnChance": 25,<br/>
///  "minimumFood": 1,<br/>
///  "hazardDamagePerTurn": 14,<br/>
///  "royale": {<br/>
///    "shrinkEveryNTurns": 5<br/>
///  },<br/>
///  "squad": {<br/>
///    "allowBodyCollisions": true,<br/>
///    "sharedElimination": true,<br/>
///    "sharedHealth": true,<br/>
///    "sharedLength": true<br/>
///  }<br/>
///}<br/>
/// </remarks>

public class Settings
{
    public int FoodSpawnChance { get; set; }
    public int MinimumFood { get; set; }
    public int HazardDamagePerTurn { get; set; }
    public RoyaleSettings Royale { get; set; }
    public SquadSettings Squad { get; set; }

    public Settings()
    {
    }

    public Settings(int foodSpawnChance, int minimumFood, int hazardDamagePerTurn, RoyaleSettings royale, SquadSettings squad)
    {
        FoodSpawnChance = foodSpawnChance;
        MinimumFood = minimumFood;
        HazardDamagePerTurn = hazardDamagePerTurn;
        Royale = royale;
        Squad = squad;
    }
}