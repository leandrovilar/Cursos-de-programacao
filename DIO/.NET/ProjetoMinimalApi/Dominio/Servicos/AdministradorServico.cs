using Microsoft.EntityFrameworkCore;
using ProjetoMinimalApi.Dominio.Entidades;
using ProjetoMinimalApi.Dominio.interfaces;
using ProjetoMinimalApi.DTOs;
using ProjetoMinimalApi.Infraestrutura.Db;

namespace ProjetoMinimalApi.Dominio.Servicos;

public class AdministradorServico : IAdministradorServico
{
    private readonly DbContexto _contexto;
    public AdministradorServico(DbContexto contexto)
    {
        _contexto = contexto;
    }
    public Administrador? Login(LoginDTO loginDTO)
    {
        var adm = _contexto.Administradores.Where(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha).FirstOrDefault();
        return adm;
    }
}