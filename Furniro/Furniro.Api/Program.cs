using Furniro.Application.Common.Interfaces.Persistance.Abstaction;
using Furniro.Application.Common.Interfaces.Persistance;
using Furniro.Infrastructure.Peristance;
using Furniro.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Furniro.Application.Common;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddInfrastructure(connectionString);

builder.Services.AddApplication();

var app = builder.Build();

if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();