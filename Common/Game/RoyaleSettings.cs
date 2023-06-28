namespace Common.Game;

// "royale": {
//     "shrinkEveryNTurns": 0
// },

public class RoyaleSettings
{
    public int shrinkEveryNTurns { get; set; }

    public RoyaleSettings()
    {
    }
    
    public RoyaleSettings(int shrinkEveryNTurns)
    {
        this.shrinkEveryNTurns = shrinkEveryNTurns;
    }
}