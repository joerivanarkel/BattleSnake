using Api.Controllers;
using Common;
using Common.Requests;
using Common.Snake;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();


var snakeController = new SnakeController();

app.MapGet("/snake", () =>
{
    return snakeController.GetAppearance();
});

app.MapPost("/snake/start", (RequestModel model) =>
{
    return snakeController.Start(model);
});

app.MapPost("/snake/move", (RequestModel model) =>
{
    return snakeController.Move(model);
});

app.MapPost("/snake/end", (RequestModel model) =>
{
    return snakeController.End(model);
});


app.Run();
