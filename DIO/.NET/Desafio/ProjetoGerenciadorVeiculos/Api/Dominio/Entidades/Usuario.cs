using ProjetoGerenciadorVeiculos.Dominio.Entidades;
using ProjetoGerenciadorVeiculos.Dominio.Enums;

namespace ProjetoGerenciadorVeiculos.Dominio.Entidades;

public class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
    public Perfil Perfil { get; set; } = Perfil.Leitor; // Padrão

}