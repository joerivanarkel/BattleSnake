namespace Common.Game;

// "settings": {
//   "foodSpawnChance": 25,
//   "minimumFood": 1,
//   "hazardDamagePerTurn": 14,
//   "royale": {
//     "shrinkEveryNTurns": 5
//   },
//   "squad": {
//     "allowBodyCollisions": true,
//     "sharedElimination": true,
//     "sharedHealth": true,
//     "sharedLength": true
//   }
// }

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