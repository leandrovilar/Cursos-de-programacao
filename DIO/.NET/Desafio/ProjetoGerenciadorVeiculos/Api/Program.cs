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
using Microsoft.OpenApi.Models;
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
var key = builder.Configuration["Jwt"] ?? "chave-super-secreta-padrao-para-jwt-2025!";

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

// Swagger com botão Authorize
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API - Gerenciador de Veículos",
        Version = "v1",
        Description = "API desenvolvida em .NET 8 com autenticação JWT e controle de perfis."
    });

    // 🔐 Configuração do botão Authorize
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "Cole abaixo apenas o seu token JWT. O Swagger adicionará automaticamente o prefixo 'Bearer'.",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});
var app = builder.Build();
#endregion

// Swagger UI
app.UseSwagger();
app.UseSwaggerUI();

// Middleware de autenticação e autorização
app.UseAuthentication();
app.UseAuthorization();

// Endpoint de teste
app.MapGet("/", () => "🚗 API Gerenciador de Veículos rodando com .NET 8!");

#region  Login
//Login
app.MapPost("/login", (LoginDTO login, DbContexto db) =>
{
    var usuario = db.Usuarios.FirstOrDefault(u =>
        u.Email == login.Email && u.Senha == login.Senha);

    if (usuario is null)
        return Results.Unauthorized();

    var key = builder.Configuration["Jwt"] ?? "MinhaChaveSuperSegura123!";
    var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
    var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

    var claims = new[]
{
    new Claim(ClaimTypes.Name, usuario.Email),
    new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
    new Claim(ClaimTypes.Role, usuario.Perfil.ToString()),
    new Claim("role", usuario.Perfil.ToString())
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

#region Me
//Endpoint Me
app.MapGet("/me", (ClaimsPrincipal user) =>
{
    var email = user.FindFirst(ClaimTypes.Name)?.Value;
    var id = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
    var role = user.FindFirst(ClaimTypes.Role)?.Value;

    return Results.Ok(new
    {
        Id = id,
        Email = email,
        Perfil = role
    });
})
.RequireAuthorization()
.WithTags("Autenticação");
#endregion


#region Usuario
//Endpoint Usuarios

// ✅ Listar usuários — apenas Admin
app.MapGet("/usuarios", (IUsuarioServico servico) =>
{
    return Results.Ok(servico.Todos());
})
.RequireAuthorization(new AuthorizeAttribute { Roles = "Admin" })
.WithTags("Usuários");

// ✅ Buscar usuário por ID — Admin e Editor podem
app.MapGet("/usuarios/{id}", (int id, IUsuarioServico servico) =>
{
    var usuario = servico.BuscarPorId(id);
    return usuario is null ? Results.NotFound() : Results.Ok(usuario);
})
.RequireAuthorization(new AuthorizeAttribute { Roles = "Admin,Editor" })
.WithTags("Usuários");

// ✅ Criar novo usuário — apenas Admin
app.MapPost("/usuarios", (UsuarioDTO dto, IUsuarioServico servico) =>
{
    var usuario = new Usuario { Nome = dto.Nome, Email = dto.Email, Senha = dto.Senha, Perfil = dto.Perfil };
    servico.Incluir(usuario);
    return Results.Created($"/usuarios/{usuario.Id}", usuario);
})
.RequireAuthorization(new AuthorizeAttribute { Roles = "Admin" })
.WithTags("Usuários");

// ✅ Atualizar — Admin e Editor podem
app.MapPut("/usuarios/{id}", (int id, UsuarioDTO dto, IUsuarioServico servico) =>
{
    var usuario = servico.BuscarPorId(id);
    if (usuario is null) return Results.NotFound();

    usuario.Nome = dto.Nome;
    usuario.Email = dto.Email;
    usuario.Senha = dto.Senha;
    usuario.Perfil = dto.Perfil;

    servico.Atualizar(usuario);
    return Results.Ok(usuario);
})
.RequireAuthorization(new AuthorizeAttribute { Roles = "Admin,Editor" })
.WithTags("Usuários");

// ✅ Excluir usuário — somente Admin
app.MapDelete("/usuarios/{id}", (int id, IUsuarioServico servico) =>
{
    var usuario = servico.BuscarPorId(id);
    if (usuario is null) return Results.NotFound();

    servico.Apagar(usuario);
    return Results.NoContent();
})
.RequireAuthorization(new AuthorizeAttribute { Roles = "Admin" })
.WithTags("Usuários");
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

app.Run();