using MinimalApi.Dominio.Entidades;
using MinimalApi.DTOS;

namespace MinimalApi.Dominio.Interfaces;

public interface IAdministradorServico
{
    Administrador? Login(LoginDTO loginDTO);
    Administrador Incluir(Administrador administrador);

    List<Administrador> Todos(int? pagina);
}