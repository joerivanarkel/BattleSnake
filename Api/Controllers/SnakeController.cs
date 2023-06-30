using Business;
using Common;
using Common.Snake;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class SnakeController : ControllerBase
{
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

    public RequestModel Start(RequestModel model)
    {
        return model;
    }

    public MoveResponse Move(RequestModel model)
    {
        MoveService moveService = new MoveService(model);
        return moveService.Move().Result;
    }

    public RequestModel End(RequestModel model)
    {
        return model;
    }
}