/**
 *  Program.cs
 * 
 *  Author   Cristian Hume Henriquez
 *  Version  1.0.0
 *  Created  2022-11-27
 *  Modified 2022-11-28
 */
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();

