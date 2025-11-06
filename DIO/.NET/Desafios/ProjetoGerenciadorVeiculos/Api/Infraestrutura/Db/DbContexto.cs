using Microsoft.EntityFrameworkCore;
using ProjetoGerenciadorVeiculos.Dominio.Entidades;

namespace ProjetoGerenciadorVeiculos.Infraestrutura.Db;

public class DbContexto : DbContext
{
    public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }

    public DbSet<Usuario> Usuarios { get; set; } = default!;
    public DbSet<Veiculo> Veiculos { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Usuario>().HasData(new Usuario
    {
        Id = 1,
        Nome = "Administrador",
        Email = "admin@teste.com",
        Senha = "123456",
        Perfil = ProjetoGerenciadorVeiculos.Dominio.Enums.Perfil.Admin
    });
}
}
