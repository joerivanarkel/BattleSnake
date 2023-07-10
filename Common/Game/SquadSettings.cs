namespace Common.Game;

using Common.Game.Interfaces;

public class SquadSettings : ISquadSettings
{
    public bool AllowBodyCollisions { get; set; }
    public bool SharedElimination { get; set; }
    public bool SharedHealth { get; set; }
    public bool SharedLength { get; set; }
    
    public SquadSettings(bool allowBodyCollisions, bool sharedElimination, bool sharedHealth, bool sharedLength)
    {
        AllowBodyCollisions = allowBodyCollisions;
        SharedElimination = sharedElimination;
        SharedHealth = sharedHealth;
        SharedLength = sharedLength;
    }
}

