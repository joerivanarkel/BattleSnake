

using Common.Snake;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/snake", () =>
{
    return new SnakeAppearance("1", "joerivanarkel", "#069420", "mlh-gene", "mlh-gene", "0.0.1-beta");
})
.WithName("GetSnake")
.WithOpenApi();


app.Run();
