using Common.Board;
using Common.You;
using Common.Game;

namespace Common.Requests.Interfaces;

public interface IRequestModel
{
    GameModel game { get; set; }
    int turn { get; set; }
    BoardModel board { get; set; }
    YouModel you { get; set; }
}