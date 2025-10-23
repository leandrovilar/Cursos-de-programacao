#region using
using Microsoft.EntityFrameworkCore;
using ProjetoGerenciadorVeiculos.Infraestrutura.Db;
using ProjetoGerenciadorVeiculos.Dominio.Interfaces;
using ProjetoGerenciadorVeiculos.Dominio.Servicos;
using ProjetoGerenciadorVeiculos.Dominio.DTOs;
using ProjetoGerenciadorVeiculos.Dominio.Entidades;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.AspNetCore.Authorization;
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

//Autenticação JWT
var key = builder.Configuration["Jwt"] ?? "chave-super-secreta-padrao";

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key))
    };
});

builder.Services.AddAuthorization();

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

#region  Login
//Login
app.MapPost("/login", (LoginDTO login, DbContexto db) =>
{
    var usuario = db.Usuarios.FirstOrDefault(u =>
        u.Email == login.Email && u.Senha == login.Senha);

    if (usuario is null)
        return Results.Unauthorized();

    var key = builder.Configuration["Jwt"] ?? "chave-super-secreta-padrao";
    var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
    var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

    var claims = new[]
    {
        new Claim("Email", usuario.Email),
        new Claim("Id", usuario.Id.ToString()),
        new Claim(ClaimTypes.Role, usuario.Perfil.ToString())
    };

    var token = new JwtSecurityToken(
        claims: claims,
        expires: DateTime.Now.AddHours(3),
        signingCredentials: credentials
    );

    var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

    return Results.Ok(new
    {
        token = tokenString,
        usuario = new { usuario.Id, usuario.Nome, usuario.Email, usuario.Perfil }
    });
})
.WithTags("Autenticação")
.AllowAnonymous();
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
})
.RequireAuthorization(new AuthorizeAttribute { Roles = "Admin,Editor" })
.WithTags("Veículos");

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
})
.RequireAuthorization(new AuthorizeAttribute { Roles = "Admin" })
.WithTags("Veículos");
#endregion

app.UseAuthentication();
app.UseAuthorization();
app.Run();
