using Common.Board;
using Common.Board.Interfaces;
using Common.Game;
using Common.Game.Interfaces;
using Common.Requests;
using Common.You;

namespace Test.DummyData;

public static class RequestModelDummyData
{
    public static RequestModel CreateRequestModel()
    {
        var requestModel = new RequestModel(
            new GameModel(
                "gameId",
                new Ruleset(
                    "rulesetId",
                    "name",
                    new Settings(
                        1,
                        1,
                        1,
                        new RoyaleSettings(
                            1
                        ),
                        new SquadSettings(
                            false,
                            false,
                            false,
                            false
                        )
                    )
                ),
                "normal",
                1,
                "1"
            ),
            0,
            new BoardModel(
                10,
                10,
                new List<ICoordinate>() {
                    new Coordinate(1, 1),
                    new Coordinate(1, 2),
                    new Coordinate(1, 3),
                },
                new List<ICoordinate>() {
                    new Coordinate(10, 10),
                },
                new List<ISnake>() {
                    new Snake(
                        "snakeId",
                        "name",
                        100,
                        new List<ICoordinate> () {
                            new Coordinate(1, 1),
                            new Coordinate(1, 2),
                            new Coordinate(1, 3),
                        },
                        0,
                        new Coordinate(1, 1),
                        3,
                        "shout",
                        "squad",
                        new Customizations(
                            "#FFFFFF",
                            "default",
                            "default"
                        )
                    )
                }
            ),
            new YouModel(
                "snakeId",
                "name",
                100,
                new List<ICoordinate>() {
                    new Coordinate(1, 1),
                    new Coordinate(1, 2),
                    new Coordinate(1, 3),
                },
                0,
                new Coordinate(1, 1),
                3,
                "shout",
                "squad",
                new Customizations(
                    "#FFFFFF",
                    "default",
                    "default"
                )
            )
        );
        return requestModel;
    }
}