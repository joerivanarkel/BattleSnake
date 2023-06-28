namespace Common;

using Common.Board;
using Common.Game;
using Common.You;

public class RequestModel
{
    public GameModel game { get; set; }
    public int turn { get; set; }
    public BoardModel board  { get; set; }
    public YouModel you { get; set; }

}