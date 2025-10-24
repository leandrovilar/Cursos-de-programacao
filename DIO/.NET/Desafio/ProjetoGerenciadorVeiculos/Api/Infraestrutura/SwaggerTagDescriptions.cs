using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

public class SwaggerTagDescriptions : IDocumentFilter
{
    public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
    {
        swaggerDoc.Tags = new List<OpenApiTag>
        {
            new OpenApiTag { Name = "Autenticação", Description = "🔑 Endpoints de login e validação de token." },
            new OpenApiTag { Name = "Usuários", Description = "👤 CRUD completo de usuários, controlado por perfis (Admin, Editor, Leitor)." },
            new OpenApiTag { Name = "Veículos", Description = "🚗 Endpoints de cadastro e consulta de veículos." },
            new OpenApiTag { Name = "Home", Description = "🏠 Página inicial e status da API." }
        };
    }
}
