using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using ProjetoMinimalApi.Dominio.ModelViews;
using ProjetoMinimalApi.DTOs;
using Test.Helpers;

namespace Test.Request;

[TestClass]
public class AdministradorRequestTest
{
    [ClassInitialize]
    public static void ClassInit(TestContext testContext)
    {
        Setup.ClassInit(testContext);
    }
    [ClassCleanup]
    public static void ClassCleanup()
    {
        Setup.ClassCleanup();
    }

    [TestMethod]
    public async Task TestarGetSetPropriedade()
    {
        //Arrange
          var loginDTO = new LoginDTO
        {
            Email = "administrador@teste.com",
            Senha = "123456"
        };
        var content = new StringContent(JsonSerializer.Serialize(loginDTO), Encoding.UTF8, "application/json");
        
        //Act
        var response = await Setup.client.PostAsync("/administrador/login", content);

        //Asserct
        Assert.AreEqual(200, (int)response.StatusCode);
        //Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

        var result = await response.Content.ReadAsStringAsync();
        var admLogado = JsonSerializer.Deserialize<AdministradorLogado>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });
        Assert.IsNotNull(admLogado?.Email ?? "");
        Assert.IsNotNull(admLogado?.Perfil ?? "");
        Assert.IsNotNull(admLogado?.Token ?? "");
       }
};
      