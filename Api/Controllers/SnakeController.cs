namespace Api.Controllers;

public class SnakeController: ControllerBase
{
    private readonly ILogger<SnakeController> _logger;

    public SnakeController(ILogger<SnakeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Snake> Get()
    {
    }
}