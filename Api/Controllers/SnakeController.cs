using Common;
using Common.Board;
using Common.Snake;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("/snake")]
public class SnakeController: ControllerBase
{
    private readonly ILogger<SnakeController> _logger;

    public SnakeController(ILogger<SnakeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public SnakeAppearance Get()
    {
        // return new snakappearance
        return new SnakeAppearance("1", "joerivanarkel", "#069420", "mlh-gene", "mlh-gene", "0.0.1-beta");
    }

    [HttpPost]
    [Route("start")]
    public void Start(RequestModel request)
    {
        return;
    }

    [HttpPost]
    [Route("move")]
    public MoveResponse Move(RequestModel request)
    {
        return new MoveResponse("up", "Moving up!");
    }

    [HttpPost]
    [Route("end")]
    public void End(RequestModel request)
    {
        return;
    }
}
