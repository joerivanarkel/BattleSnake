using Business;
using Common.Requests;
using Common.Snake;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

/// <summary>
/// Controller for handling requests related to the snake in the BattleSnake game.
/// </summary>
[ApiController]
[Route("[controller]")]
public class SnakeController : ControllerBase
{
    /// <summary> Returns the appearance of the snake. </summary>
    /// <returns> A SnakeAppearance object containing the appearance of the snake. </returns>
    [HttpGet]
    public SnakeAppearance GetAppearance()
    {
        return new SnakeAppearance(
            "1", 
            "joerivanarkel", 
            "#069420", 
            "mlh-gene", 
            "mlh-gene", 
            "0.0.1-beta"
        );
    }

    /// <summary> Receives a request to start the snake. </summary>
    /// <param name="model"> The request model containing the data of the BattleSnake game. </param>
    /// <returns> A RequestModel object containing the data of the BattleSnake game. </returns>
    [HttpPost("start")]
    public RequestModel Start(RequestModel model)
    {
        return model;
    }

    /// <summary> Receives a request to move the snake. </summary>
    /// <param name="model"> The request model containing the data of the BattleSnake game. </param>
    /// <returns> A MoveResponse object containing the direction the snake should move in.  </returns>
    [HttpPost("move")]
    public MoveResponse Move(RequestModel model)
    {
        MoveService moveService = new(model);
        return moveService.CalculateMove().Result;
    }

    /// <summary> Receives a request to end the snake. </summary>
    /// <param name="model"> The request model containing the data of the BattleSnake game. </param>
    /// <returns> A RequestModel object containing the data of the BattleSnake game. </returns>
    [HttpPost("end")]
    public RequestModel End(RequestModel model)
    {
        return model;
    }
}