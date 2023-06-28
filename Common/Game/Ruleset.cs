namespace Common.Game;

//   "ruleset": {
//     "name": "standard",
//     "version": "v1.2.3",
//      "settings": {},
//   },

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