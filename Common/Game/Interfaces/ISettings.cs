namespace Common.Game.Interfaces;

public interface ISettings
{
    int FoodSpawnChance { get; set; }
    int MinimumFood { get; set; }
    int HazardDamagePerTurn { get; set; }
    RoyaleSettings Royale { get; set; }
    SquadSettings Squad { get; set; }
}