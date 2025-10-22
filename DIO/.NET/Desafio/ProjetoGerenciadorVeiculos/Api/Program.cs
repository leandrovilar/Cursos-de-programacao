using Microsoft.EntityFrameworkCore;
using ProjetoGerenciadorVeiculos.Infraestrutura.Db;
using ProjetoGerenciadorVeiculos.Dominio.Interfaces;
using ProjetoGerenciadorVeiculos.Dominio.Servicos;
using ProjetoGerenciadorVeiculos.Dominio.DTOs;
using ProjetoGerenciadorVeiculos.Dominio.Entidades;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<IUsuarioServico, UsuarioServico>();

// Configura banco de dados MySQL
builder.Services.AddDbContext<DbContexto>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("MySql"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MySql"))
    )
);

// Registra serviços
builder.Services.AddScoped<IUsuarioServico, UsuarioServico>();

// Configura Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger UI
app.UseSwagger();
app.UseSwaggerUI();

// Endpoint de teste
app.MapGet("/", () => "🚗 API Gerenciador de Veículos rodando com .NET 8!");

// Endpoint simples de usuários (teste)
//app.MapGet("/usuarios", (IUsuarioServico servico) => servico.Todos());

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

app.Run();
