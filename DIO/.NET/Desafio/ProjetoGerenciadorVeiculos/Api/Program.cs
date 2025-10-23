#region using
using Microsoft.EntityFrameworkCore;
using ProjetoGerenciadorVeiculos.Infraestrutura.Db;
using ProjetoGerenciadorVeiculos.Dominio.Interfaces;
using ProjetoGerenciadorVeiculos.Dominio.Servicos;
using ProjetoGerenciadorVeiculos.Dominio.DTOs;
using ProjetoGerenciadorVeiculos.Dominio.Entidades;
#endregion

#region Builder
var builder = WebApplication.CreateBuilder(args);

// Configura banco de dados MySQL
builder.Services.AddDbContext<DbContexto>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("MySql"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MySql"))
    )
);

// Registra serviços
builder.Services.AddScoped<IUsuarioServico, UsuarioServico>();
builder.Services.AddScoped<IVeiculoServico, VeiculoServico>();

// Configura Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
#endregion

// Swagger UI
app.UseSwagger();
app.UseSwaggerUI();

// Endpoint de teste
app.MapGet("/", () => "🚗 API Gerenciador de Veículos rodando com .NET 8!");

#region Usuario
//Endpoint Usuarios
app.MapGet("/usuarios", (IUsuarioServico servico) =>
{
    return Results.Ok(servico.Todos());
});

app.MapGet("/usuarios/{id}", (int id, IUsuarioServico servico) =>
{
    var usuario = servico.BuscarPorId(id);
    return usuario is null ? Results.NotFound() : Results.Ok(usuario);
});

app.MapPost("/usuarios", (UsuarioDTO dto, IUsuarioServico servico) =>
{
    var usuario = new Usuario { Nome = dto.Nome, Email = dto.Email, Senha = dto.Senha };
    servico.Incluir(usuario);
    return Results.Created($"/usuarios/{usuario.Id}", usuario);
});

app.MapPut("/usuarios/{id}", (int id, UsuarioDTO dto, IUsuarioServico servico) =>
{
    var usuario = servico.BuscarPorId(id);
    if (usuario is null) return Results.NotFound();

    usuario.Nome = dto.Nome;
    usuario.Email = dto.Email;
    usuario.Senha = dto.Senha;
    servico.Atualizar(usuario);

    return Results.Ok(usuario);
});

app.MapDelete("/usuarios/{id}", (int id, IUsuarioServico servico) =>
{
    var usuario = servico.BuscarPorId(id);
    if (usuario is null) return Results.NotFound();

    servico.Apagar(usuario);
    return Results.NoContent();
});
#endregion

#region Veiculo
//Endpoint Veiculos
app.MapGet("/veiculos", (IVeiculoServico servico) =>
{
    return Results.Ok(servico.Todos());
});

app.MapGet("/veiculos/{id}", (int id, IVeiculoServico servico) =>
{
    var veiculo = servico.BuscarPorId(id);
    return veiculo is null ? Results.NotFound() : Results.Ok(veiculo);
});

app.MapPost("/veiculos", (VeiculoDTO dto, IVeiculoServico servico) =>
{
    var veiculo = new Veiculo
    {
        Marca = dto.Marca,
        Modelo = dto.Modelo,
        Ano = dto.Ano,
        UsuarioId = dto.UsuarioId
    };
    servico.Incluir(veiculo);
    return Results.Created($"/veiculos/{veiculo.Id}", veiculo);
});

app.MapPut("/veiculos/{id}", (int id, VeiculoDTO dto, IVeiculoServico servico) =>
{
    var veiculo = servico.BuscarPorId(id);
    if (veiculo is null) return Results.NotFound();

    veiculo.Marca = dto.Marca;
    veiculo.Modelo = dto.Modelo;
    veiculo.Ano = dto.Ano;
    veiculo.UsuarioId = dto.UsuarioId;

    servico.Atualizar(veiculo);
    return Results.Ok(veiculo);
});

app.MapDelete("/veiculos/{id}", (int id, IVeiculoServico servico) =>
{
    var veiculo = servico.BuscarPorId(id);
    if (veiculo is null) return Results.NotFound();

    servico.Apagar(veiculo);
    return Results.NoContent();
});
#endregion

app.Run();
