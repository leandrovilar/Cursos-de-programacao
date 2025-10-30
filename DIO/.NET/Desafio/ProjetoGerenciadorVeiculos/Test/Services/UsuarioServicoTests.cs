using Microsoft.EntityFrameworkCore;
using ProjetoGerenciadorVeiculos.Infraestrutura.Db;
using ProjetoGerenciadorVeiculos.Dominio.Servicos;
using ProjetoGerenciadorVeiculos.Dominio.Entidades;
using ProjetoGerenciadorVeiculos.Dominio.Enums;
using Xunit;
using Microsoft.Extensions.Configuration;


namespace Test.Services;

public class UsuarioServicoTests
{
    private DbContexto CriarContextoEmMemoria()
    {
        var options = new DbContextOptionsBuilder<DbContexto>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()) // banco único por teste
            .Options;

        return new DbContexto(options);
    }

    [Fact]
    public void DeveIncluirUsuarioNoBanco()
    {
        // Arrange
        var contexto = CriarContextoEmMemoria();
        var servico = new UsuarioServico(contexto);

        var usuario = new Usuario
        {
            Nome = "Editor",
            Email = "editor@teste.com",
            Senha = "123",
            Perfil = Perfil.Editor
        };

        // Act
        servico.Incluir(usuario);

        // Assert
        Assert.Equal(1, contexto.Usuarios.Count());
        Assert.Equal("Editor", contexto.Usuarios.First().Nome);
    }

    [Fact]
    public void DeveBuscarUsuarioPorId()
    {
        // Arrange
        var contexto = CriarContextoEmMemoria();
        var servico = new UsuarioServico(contexto);

        var usuario = new Usuario
        {
            Nome = "Leandro",
            Email = "leandro@teste.com",
            Senha = "abc",
            Perfil = Perfil.Leitor
        };

        servico.Incluir(usuario);

        // Act
        var encontrado = servico.BuscarPorId(usuario.Id);

        // Assert
        Assert.NotNull(encontrado);
        Assert.Equal("Leandro", encontrado!.Nome);
    }
}
