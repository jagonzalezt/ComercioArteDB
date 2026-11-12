using Microsoft.EntityFrameworkCore;
using ApiComercioArtes.Data;

var builder = WebApplication.CreateBuilder(args);

// 1. Agregar la cadena de conexión al DbContext
builder.Services.AddDbContext<DbcontexSistema>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSQL")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();