namespace Common.Game.Interfaces;

public interface ISettings
{
    int FoodSpawnChance { get; set; }
    int MinimumFood { get; set; }
    int HazardDamagePerTurn { get; set; }
    IRoyaleSettings Royale { get; set; }
    ISquadSettings Squad { get; set; }
}