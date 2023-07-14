using Common.Game;
using Common.Board;
using Common.You;
using Common.Requests.Interfaces;
using Common.You.Interfaces;
using Common.Board.Interfaces;
using Common.Game.Interfaces;

namespace Common.Requests;

public class RequestModel : IRequestModel
{
    public IGameModel game { get; set; }
    public int turn { get; set; }
    public IBoardModel board  { get; set; }
    public IYouModel you { get; set; }

    public RequestModel(GameModel game, int turn, BoardModel board, YouModel you)
    {
        this.game = game;
        this.turn = turn;
        this.board = board;
        this.you = you;
    }
}