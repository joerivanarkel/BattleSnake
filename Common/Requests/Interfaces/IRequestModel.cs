using Common.Board.Interfaces;
using Common.You.Interfaces;
using Common.Game.Interfaces;

namespace Common.Requests.Interfaces;

public interface IRequestModel
{
    IGameModel game { get; set; }
    int turn { get; set; }
    IBoardModel board { get; set; }
    IYouModel you { get; set; }
}