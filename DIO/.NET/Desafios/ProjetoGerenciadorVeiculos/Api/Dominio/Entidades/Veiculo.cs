namespace ProjetoGerenciadorVeiculos.Dominio.Entidades;

public class Veiculo
{
    public int Id { get; set; }
    public string Marca { get; set; } = string.Empty;
    public string Modelo { get; set; } = string.Empty;
    public int Ano { get; set; }

    public int UsuarioId { get; set; }
    public Usuario? Usuario { get; set; }
}
