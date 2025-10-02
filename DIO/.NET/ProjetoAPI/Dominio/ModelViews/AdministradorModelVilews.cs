using MinimalApi.Dominio.Enuns;

namespace MinimalApi.Dominio.ModelViews;

public record AdministradorModelVilews
{
    public int Id { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Password { get; set; } = default!;
    public Perfil Perfil { get; set; } = default!;
   
}
