namespace ProjetoGerenciadorVeiculos.Dominio.DTOs;

public class VeiculoDTO
{
    public string Marca { get; set; } = string.Empty;
    public string Modelo { get; set;} = string.Empty;
    public int Ano { get; set; }
    public int UsuarioId { get; set; }
}