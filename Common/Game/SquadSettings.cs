namespace Common.Game;

// "squad": {
//     "allowBodyCollisions": false,
//     "sharedElimination": false,
//     "sharedHealth": false,
//     "sharedLength": false
// }

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