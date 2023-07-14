namespace Common.Game.Interfaces;

public interface IGameModel
{
    string Id { get; set; }
    IRuleset Ruleset { get; set; }
    string Map { get; set; }
    int Timeout { get; set; }
    string Source { get; set; }
}