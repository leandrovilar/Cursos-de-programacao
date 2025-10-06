using ProjetoMinimalApi.Infraestrutura.Db;
using ProjetoMinimalApi.DTOs;
using Microsoft.EntityFrameworkCore;
using ProjetoMinimalApi.Dominio.Servicos;
using ProjetoMinimalApi.Dominio.interfaces;
using Microsoft.AspNetCore.Mvc;
using ProjetoMinimalApi.Dominio.ModelViews;

#region Builder
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IAdministradorServico, AdministradorServico>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DbContexto>(options =>
{
    options.UseMySql(
        builder.Configuration.GetConnectionString("mysql"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("mysql"))
        );
});

var app = builder.Build();
#endregion

#region Home
app.MapGet("/", () => Results.Json(new Home()));
#endregion

#region Administradores
app.MapPost("administradores/login", ([FromBody] LoginDTO loginDTO, IAdministradorServico administradorServico) =>
{
    if (administradorServico.Login(loginDTO) != null)
        return Results.Ok("Login com sucesso");
    else
        return Results.Unauthorized();
});
#endregion

#region Veiculos

#endregion

#region App
app.UseSwagger();
app.UseSwaggerUI();
app.Run();
#endregion