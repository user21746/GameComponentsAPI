using Microsoft.EntityFrameworkCore;
using GameComponentsAPI.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<GameComponentsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GameComponentsDB")));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
