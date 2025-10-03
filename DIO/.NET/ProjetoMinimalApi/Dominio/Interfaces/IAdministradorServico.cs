using ProjetoMinimalApi.Dominio.Entidades;
using ProjetoMinimalApi.DTOs;

namespace ProjetoMinimalApi.Dominio.interfaces;

public interface IAdministradorServico
{
    Administrador? Login(LoginDTO loginDTO);
}
