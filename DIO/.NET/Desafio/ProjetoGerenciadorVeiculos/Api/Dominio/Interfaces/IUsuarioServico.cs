using ProjetoGerenciadorVeiculos.Dominio.Entidades;

namespace ProjetoGerenciadorVeiculos.Dominio.Interfaces;

public interface IUsuarioServico
{
    List<Usuario> Todos();
    Usuario? BuscarPorId(int id);
    Usuario Incluir(Usuario usuario);
    void Atualizar(Usuario usuario);
    void Apagar(Usuario usuario);
}
