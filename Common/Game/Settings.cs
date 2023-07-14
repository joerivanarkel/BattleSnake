using Common.Game.Interfaces;

namespace Common.Game;

public class Settings : ISettings
{
    public int FoodSpawnChance { get; set; }
    public int MinimumFood { get; set; }
    public int HazardDamagePerTurn { get; set; }
    public IRoyaleSettings Royale { get; set; }
    public ISquadSettings Squad { get; set; }

    public Settings(int foodSpawnChance, int minimumFood, int hazardDamagePerTurn, RoyaleSettings royale, SquadSettings squad)
    {
        FoodSpawnChance = foodSpawnChance;
        MinimumFood = minimumFood;
        HazardDamagePerTurn = hazardDamagePerTurn;
        Royale = royale;
        Squad = squad;
    }
}