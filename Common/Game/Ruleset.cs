namespace Common.Game;

/// <summary>
/// Represents a set of rules for a game.
/// </summary>

/// <remarks>
/// This is the input JSON for a ruleset: <br/>
/// "ruleset": {<br/>
///     "name": "standard",<br/>
///     "version": "v1.2.3",<br/>
///     "settings": {},<br/>
///  },<br/>
/// </remarks>

public class Ruleset
{
    public string Name { get; set; }
    public string Version { get; set; }
    public Settings Settings { get; set; }

    public Ruleset()
    {
    }

    public Ruleset(string name, string version, Settings settings)
    {
        Name = name;
        Version = version;
        Settings = settings;
    }
}