using ProjetoGerenciadorVeiculos.Dominio.Entidades;
using ProjetoGerenciadorVeiculos.Dominio.Interfaces;
using ProjetoGerenciadorVeiculos.Infraestrutura.Db;
using Microsoft.EntityFrameworkCore;

public class VeiculoServico : IVeiculoServico
{
    private readonly DbContexto _contexto;

    public VeiculoServico(DbContexto contexto)
    {
        _contexto = contexto;
    }
    public List<Veiculo> Todos() => _contexto.Veiculos.Include(v => v.Usuario).AsNoTracking().ToList();

    public Veiculo? BuscarPorId(int id) => _contexto.Veiculos.Include(v => v.Usuario).FirstOrDefault(v => v.Id == id);

        public Veiculo Incluir(Veiculo veiculo)
    {
        _contexto.Veiculos.Add(veiculo);
        _contexto.SaveChanges();
        return veiculo;
    }
    public void Atualizar(Veiculo veiculo)
    {
        _contexto.Veiculos.Update(veiculo);
        _contexto.SaveChanges();
    }
    public void Apagar(Veiculo veiculo)
    {
        _contexto.Veiculos.Remove(veiculo);
        _contexto.SaveChanges();       
    }
}