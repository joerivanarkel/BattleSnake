using Common.Game;
using Common.Board;
using Common.You;
using Common.Requests.Interfaces;

namespace Common.Requests;

public class RequestModel : IRequestModel
{
    public GameModel game { get; set; }
    public int turn { get; set; }
    public BoardModel board  { get; set; }
    public YouModel you { get; set; }

    public RequestModel(GameModel game, int turn, BoardModel board, YouModel you)
    {
        this.game = game;
        this.turn = turn;
        this.board = board;
        this.you = you;
    }
}