namespace Common.Game.Interfaces;

public interface IRuleset
{
    string Name { get; set; }
    string Version { get; set; }
    ISettings Settings { get; set; }
}