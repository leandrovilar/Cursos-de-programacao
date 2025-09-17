#region Using
using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Interfaces;
using MinimalApi.Dominio.ModelViews;
using MinimalApi.Dominio.Servicos;
using MinimalApi.DTOS;
using MinimalApi.Infraestrutura.Db;

#endregion

#region Buider
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IAdministradorServico, AdministradorServico>();
builder.Services.AddScoped<IVeiculoServico, VeiculoServico>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DbContexto>(options => options.UseMySql(
        builder.Configuration.GetConnectionString("mysql"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("mysql"))
    ));

var app = builder.Build();
#endregion

#region Home
app.MapGet("/", () => Results.Json(new Home())).WithTags("Home");
#endregion

#region Administradores
app.MapPost("Administradores/login", ([FromBody] LoginDTO loginDTO, IAdministradorServico administradorServico) =>
{
    if (administradorServico.Login(loginDTO) != null)
        return Results.Ok("Login com sucesso");
    else
        return Results.Unauthorized();
}).WithTags("Administradores");
#endregion

#region Veiculos
ErrosDeValidacao validaDTO(VeiculoDTO veiculoDTO){

var validacao = new ErrosDeValidacao{
    Mensagens = new List<string>()
};

if(string.IsNullOrEmpty(veiculoDTO.Nome))
validacao.Mensagens.Add("O nome não pode ser vazio");

if(string.IsNullOrEmpty(veiculoDTO.Marca))
validacao.Mensagens.Add("O Marca não pode ficar em branco");

if(veiculoDTO.Ano < 1950)
validacao.Mensagens.Add("Veiculo muito antico, aceito somente até 1950");

return validacao;
}

app.MapPost("/veiculos", ([FromBody] VeiculoDTO veiculoDTO, IVeiculoServico veiculoServico) =>
{
var validacao = validaDTO(veiculoDTO);
if (validacao.Mensagens.Count > 0)
    return Results.BadRequest(validacao);

    var veiculo = new Veiculo()
    {
        Nome = veiculoDTO.Nome,
        Marca = veiculoDTO.Marca,
        Ano = veiculoDTO.Ano
    };
    veiculoServico.Incluir(veiculo);
    return Results.Created($"/veiculo/{veiculo.Id}", veiculo);
}).WithTags("Veiculos");

//Inserir veiculo
app.MapGet("/veiculos/{id}", ([FromQuery] int id, IVeiculoServico veiculoServico) =>
{
    var veiculo = veiculoServico.BuscapPorId(id);
    if (veiculo == null) return Results.NotFound();
    return Results.Ok(veiculo);
}).WithTags("Veiculos");

//Atualizar veiculo
app.MapPut("/veiculos/{id}", ([FromRoute] int id, VeiculoDTO veiculoDTO, IVeiculoServico veiculoServico) =>
{
    var veiculo = veiculoServico.BuscapPorId(id);
    if (veiculo == null) return Results.NotFound();

    var validacao = validaDTO(veiculoDTO);
    if (validacao.Mensagens.Count > 0)
        return Results.BadRequest(validacao);

    veiculo.Nome = veiculoDTO.Nome;
    veiculo.Marca = veiculoDTO.Marca;
    veiculo.Ano = veiculoDTO.Ano;
    veiculoServico.Atualizar(veiculo);
    return Results.Ok(veiculo);
}).WithTags("Veiculos");;

//Deletar veiculo
app.MapDelete("/veiculos/{id}", ([FromRoute] int id, IVeiculoServico veiculoServico) =>
{
    var veiculo = veiculoServico.BuscapPorId(id);
    if (veiculo == null) return Results.NotFound();
    veiculoServico.Apagar(veiculo);
    return Results.NoContent();
}).WithTags("Veiculos");

#endregion

#region App
app.UseSwagger();
app.UseSwaggerUI();
app.Run();
#endregion