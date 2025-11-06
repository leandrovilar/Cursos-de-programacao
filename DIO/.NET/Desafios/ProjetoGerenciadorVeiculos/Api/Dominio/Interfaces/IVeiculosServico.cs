using ProjetoGerenciadorVeiculos.Dominio.Entidades;

namespace ProjetoGerenciadorVeiculos.Dominio.Interfaces;

public interface IVeiculoServico
{
    List<Veiculo> Todos();
    Veiculo? BuscarPorId(int id);
    Veiculo Incluir(Veiculo veiculo);
    void Atualizar(Veiculo veiculo);
    void Apagar(Veiculo veiculo);

}