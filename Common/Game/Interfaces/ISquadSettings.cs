namespace Common.Game.Interfaces;

public interface ISquadSettings
{
    bool AllowBodyCollisions { get; set; }
    bool SharedElimination { get; set; }
    bool SharedHealth { get; set; }
    bool SharedLength { get; set; }
}