using ProjetoMinimalApi.Dominio.Entidades;
using ProjetoMinimalApi.DTOs;
using Microsoft.EntityFrameworkCore;
using ProjetoMinimalApi.Infraestrutura.Db;


namespace ProjetoMinimalApi.Dominio.Interfaces;

public interface IVeiculoServico
{
    List<Veiculo> Todos(int pagina = 1, string? nome = null, string? marca = null);
    public Veiculo? BuscarPorId(int id);
    void Incluir(Veiculo veiculo);
    void Atualizar(Veiculo veiculo);
    void Apagar(Veiculo veiculo);
}
