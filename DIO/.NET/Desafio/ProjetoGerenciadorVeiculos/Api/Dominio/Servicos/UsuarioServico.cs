using ProjetoGerenciadorVeiculos.Dominio.Entidades;
using ProjetoGerenciadorVeiculos.Dominio.Interfaces;
using ProjetoGerenciadorVeiculos.Infraestrutura.Db;
using Microsoft.EntityFrameworkCore;

namespace ProjetoGerenciadorVeiculos.Dominio.Servicos;

public class UsuarioServico : IUsuarioServico
{
    private readonly DbContexto _contexto;
    public UsuarioServico(DbContexto contexto)
    {
        _contexto = contexto;
    }

    public List<Usuario> Todos()
        => _contexto.Usuarios.AsNoTracking().ToList();

    public Usuario? BuscarPorId(int id)
        => _contexto.Usuarios.Find(id);

    public Usuario Incluir(Usuario usuario)
    {
        _contexto.Usuarios.Add(usuario);
        _contexto.SaveChanges();
        return usuario;
    }

    public void Atualizar(Usuario usuario)
    {
        _contexto.Usuarios.Update(usuario);
        _contexto.SaveChanges();
    }

    public void Apagar(Usuario usuario)
    {
        _contexto.Usuarios.Remove(usuario);
        _contexto.SaveChanges();
    }
}
