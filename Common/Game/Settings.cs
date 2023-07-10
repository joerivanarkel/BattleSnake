using Common.Game.Interfaces;

namespace Common.Game;

public class Settings : ISettings
{
    public int FoodSpawnChance { get; set; }
    public int MinimumFood { get; set; }
    public int HazardDamagePerTurn { get; set; }
    public RoyaleSettings Royale { get; set; }
    public SquadSettings Squad { get; set; }

    public Settings(int foodSpawnChance, int minimumFood, int hazardDamagePerTurn, RoyaleSettings royale, SquadSettings squad)
    {
        FoodSpawnChance = foodSpawnChance;
        MinimumFood = minimumFood;
        HazardDamagePerTurn = hazardDamagePerTurn;
        Royale = royale;
        Squad = squad;
    }
}