using ProjetoGerenciadorVeiculos.Dominio.Enums;

namespace ProjetoGerenciadorVeiculos.Dominio.DTOs;

public class UsuarioDTO
{
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
     public Perfil Perfil { get; set; } = Perfil.Leitor;
}
