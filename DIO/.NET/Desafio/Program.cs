using Microsoft.EntityFrameworkCore;
using ProjetoGerenciadorVeiculos.Infraestrutura.Db;
using ProjetoGerenciadorVeiculos.Dominio.Entidades;

var builder = WebApplication.CreateBuilder(args);

// Configurar conexão MySQL
builder.Services.AddDbContext<DbContexto>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("MySql"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MySql"))
    )
);

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "🚗 API de Gerenciamento de Veículos rodando com .NET 8!");

// Endpoint de teste inicial
app.MapGet("/usuarios", async (DbContexto db) => await db.Usuarios.ToListAsync());

app.Run();