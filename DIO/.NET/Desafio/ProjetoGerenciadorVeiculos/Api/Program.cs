using Microsoft.EntityFrameworkCore;
using ProjetoGerenciadorVeiculos.Infraestrutura.Db;
using ProjetoGerenciadorVeiculos.Dominio.Interfaces;
using ProjetoGerenciadorVeiculos.Dominio.Servicos;


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
app.MapGet("/usuarios", (IUsuarioServico servico) => servico.Todos());

app.Run();
