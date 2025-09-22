using MinimalApi.Dominio.Enuns;

namespace MinimalApi.DTOS;

public class AdministradorDTO
{
    public string Email { get; set; } = default!;
    public string Password { get; set; } = default!;
    public Perfil? Perfil { get; set; } = default!;
}