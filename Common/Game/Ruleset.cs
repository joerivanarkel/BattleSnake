using Common.Game.Interfaces;

namespace Common.Game;

public class Ruleset : IRuleset
{
    public string Name { get; set; }
    public string Version { get; set; }
    public Settings Settings { get; set; }

    public Ruleset(string name, string version, Settings settings)
    {
        Name = name;
        Version = version;
        Settings = settings;
    }
}

