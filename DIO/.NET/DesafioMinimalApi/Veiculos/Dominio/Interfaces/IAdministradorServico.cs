using ProjetoMinimalApi.Dominio.Entidades;
using ProjetoMinimalApi.DTOs;

namespace ProjetoMinimalApi.Dominio.interfaces;

public interface IAdministradorServico
{
    Administrador? Login(LoginDTO loginDTO);
    Administrador Incluir(Administrador administrador);
    Administrador? BuscarPorId(int id);
    List<Administrador> Todos(int? pagina);
}
