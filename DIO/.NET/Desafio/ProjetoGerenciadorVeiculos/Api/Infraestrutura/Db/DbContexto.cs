using Microsoft.EntityFrameworkCore;
using ProjetoGerenciadorVeiculos.Dominio.Entidades;

namespace ProjetoGerenciadorVeiculos.Infraestrutura.Db;

public class DbContexto : DbContext
{
    public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }

    public DbSet<Usuario> Usuarios { get; set; } = default!;
    public DbSet<Veiculo> Veiculos { get; set; } = default!;
}
