using Microsoft.Extensions.Configuration;
using ProjetoMinimalApi.Dominio.Entidades;
using ProjetoMinimalApi.Infraestrutura.Db;
using ProjetoMinimalApi.Dominio.Servicos;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Tests.Dominio.Servicos;

[TestClass]
public sealed class AdministradorServicoTest
{
    private DbContexto CriarContextoDeTeste()
    {
        var assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        var path = Path.GetFullPath(Path.Combine(assemblyPath ?? "", "..", "..", ".."));

        //Configurar o ConfigurationBuilder
        var builder = new ConfigurationBuilder()
        .SetBasePath(path ?? Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .AddEnvironmentVariables();

        var Configuration = builder.Build();

        return new DbContexto(Configuration);
    }
    [TestMethod]
    public void TestarSalvarAdministrador()
    {
        //Arrange
        var context = CriarContextoDeTeste();
        context.Database.ExecuteSqlRaw("DELETE FROM Administrador");

        var adm = new Administrador();
        adm.Email = "administrador@teste.com";
        adm.Senha = "123456";
        adm.Perfil = "Adm";

        var administradorServico = new AdministradorServico(context);

        //Act
        administradorServico.Incluir(adm);

        //Assert
        Assert.AreEqual(1, administradorServico.Todos(1).Count());
    }
    
};
      