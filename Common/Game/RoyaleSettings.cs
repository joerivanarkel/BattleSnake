using Common.Game.Interfaces;

namespace Common.Game;

public class RoyaleSettings : IRoyaleSettings
{
    public int shrinkEveryNTurns { get; set; }

    public RoyaleSettings(int shrinkEveryNTurns)
    {
        this.shrinkEveryNTurns = shrinkEveryNTurns;
    }
}

