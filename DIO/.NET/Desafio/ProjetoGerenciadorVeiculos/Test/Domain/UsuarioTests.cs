using ProjetoGerenciadorVeiculos.Dominio.Entidades;
using ProjetoGerenciadorVeiculos.Dominio.Enums;
using Xunit;

namespace Test.Domain;

public class UsuarioTests
{
    [Fact]
    public void DeveCriarUsuarioCorretamente()
    {
        // Arrange (monta o cenário)
        var usuario = new Usuario
        {
            Id = 1,
            Nome = "Administrador",
            Email = "admin@teste.com",
            Senha = "123456",
            Perfil = Perfil.Admin // assumindo que Perfil é um enum Admin / Editor / Leitor
        };

        // Assert (confirma se ficou como esperado)
        Assert.Equal(1, usuario.Id);
        Assert.Equal("Administrador", usuario.Nome);
        Assert.Equal("admin@teste.com", usuario.Email);
        Assert.Equal("123456", usuario.Senha);
        Assert.Equal(Perfil.Admin, usuario.Perfil);
    }
}
