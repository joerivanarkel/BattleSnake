namespace Common;

using Common.Board;
using Common.Game;
using Common.You;

public class RequestModel
{
    public GameModel game { get; set; } = default!;
    public int turn { get; set; } = default!;
    public BoardModel board  { get; set; } = default!;
    public YouModel you { get; set; } = default!;

}