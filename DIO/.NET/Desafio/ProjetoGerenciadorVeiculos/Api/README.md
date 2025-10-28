# 🚗 Projeto Gerenciador de Veículos - .NET 8 Minimal API

API desenvolvida em **.NET 8** com o padrão **Minimal API**, integrando **autenticação JWT**, **controle de perfis de usuário (Admin, Editor e Leitor)**, **documentação interativa com Swagger**, e **testes automatizados** (unidade, persistência e requests).

---

## 📚 Sumário

- [Descrição](#descrição)
- [Tecnologias Utilizadas](#tecnologias-utilizadas)
- [Arquitetura do Projeto](#arquitetura-do-projeto)
- [Funcionalidades](#funcionalidades)
- [Perfis e Permissões](#perfis-e-permissões)
- [Como Executar o Projeto](#como-executar-o-projeto)
- [Endpoints Principais](#endpoints-principais)
- [Testes Automatizados](#testes-automatizados)
- [Deploy](#deploy)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Autor](#autor)

---

## 🧩 Descrição

O **Gerenciador de Veículos** é uma API REST desenvolvida como parte do **Desafio da DIO**, com foco em aplicar conceitos práticos de desenvolvimento backend em **.NET 8**:

- API navegavel usando **Minimal API**
- **Autenticação JWT** e **controle de acesso por perfis**
- CRUD completo para **Usuários** e **Veículos**
- **Validação de dados** e tratamento de erros
- **Testes automatizados** de unidade, persistência e requisição
- Documentação **Swagger UI**

---

## 🛠️ Tecnologias Utilizadas

- 🟣 **.NET 8**
- 💾 **Entity Framework Core**
- 🐬 **MySQL**
- 🔐 **JWT (JSON Web Token)**
- 🧪 **xUnit** + **WebApplicationFactory**
- 📘 **Swagger / Swashbuckle**
- 🐳 **Docker (opcional)**

---

## 🧱 Arquitetura do Projeto

ProjetoGerenciadorVeiculos/
│
├── Api/
│   ├── Program.cs
│   ├── appsettings.json
│   └── Properties/
│
├── Dominio/
│   ├── Entidades/
│   ├── DTOs/
│   ├── Interfaces/
│   ├── Servicos/
│   └── Enuns/
│
├── Infraestrutura/
│   └── Db/
│
├── Test/
│   ├── Domain/
│   ├── Services/
│   └── Requests/
│
└── ProjetoGerenciadorVeiculos.sln

````

## ⚙️ Funcionalidades

✅ **Autenticação JWT**
- Login de usuários com token de acesso.
- Controle de perfis (Admin, Editor, Leitor).

✅ **CRUD de Usuários**
- Cadastrar, listar, atualizar e excluir usuários com validação.

✅ **CRUD de Veículos**
- Cadastrar, listar, buscar, atualizar e excluir veículos.

✅ **Validações**
- Regras simples implementadas antes de salvar os dados no banco.

✅ **Documentação Swagger**
- Interface visual para testar os endpoints.

✅ **Testes automatizados**
- Unidade, persistência (InMemory) e requisição (endpoint real).

---

## 🔐 Perfis e Permissões

| Perfil   | Descrição | Acesso |
|-----------|------------|--------|
| **Admin** | Controle total do sistema | CRUD de usuários e veículos |
| **Editor** | Pode criar e editar veículos | CRUD parcial de veículos |
| **Leitor** | Pode apenas visualizar | GET de veículos |
| **Anônimo** | Não autenticado | Apenas rota `/` e `/login` |

---

## ▶️ Como Executar o Projeto

### 1. Clonar o repositório

git clone...

### 2. Entrar na pasta do projeto

cd gerenciador-veiculos

### 3. Configurar o banco MySQL

No arquivo `appsettings.json`, configure a conexão:

```json
"ConnectionStrings": {
  "MySql": "Server=localhost;Database=gerenciador_veiculos;User=root;Password=suasenha;"
}
```

### 4. Executar as migrações (opcional)

dotnet ef database update

### 5. Rodar a aplicação

dotnet run --project Api

Acesse:

https://localhost:5001/swagger

## 📘 Endpoints Principais

### 🔑 Autenticação

| Método | Rota     | Descrição                           |
| ------ | -------- | ----------------------------------- |
| POST   | `/login` | Realiza login e retorna o token JWT |

### 👤 Usuários

| Método | Rota             | Descrição               | Permissão     |
| ------ | ---------------- | ----------------------- | ------------- |
| GET    | `/usuarios`      | Lista todos os usuários | Admin         |
| GET    | `/usuarios/{id}` | Busca usuário por ID    | Admin, Editor |
| POST   | `/usuarios`      | Cria novo usuário       | Admin         |
| PUT    | `/usuarios/{id}` | Atualiza usuário        | Admin, Editor |
| DELETE | `/usuarios/{id}` | Remove usuário          | Admin         |

### 🚗 Veículos

| Método | Rota             | Descrição               | Permissão             |
| ------ | ---------------- | ----------------------- | --------------------- |
| GET    | `/veiculos`      | Lista todos os veículos | Leitor, Editor, Admin |
| GET    | `/veiculos/{id}` | Retorna veículo por ID  | Leitor, Editor, Admin |
| POST   | `/veiculos`      | Cadastra veículo        | Editor, Admin         |
| PUT    | `/veiculos/{id}` | Atualiza veículo        | Editor, Admin         |
| DELETE | `/veiculos/{id}` | Exclui veículo          | Admin                 |

---

## 🧪 Testes Automatizados

Os testes foram divididos em três níveis:

### 🧩 Testes de Unidade

Validam entidades e regras de negócio:

dotnet test --filter "Test.Domain"

### 💾 Testes de Persistência

Usam banco **InMemory** para testar o `DbContexto` e serviços:

dotnet test --filter "Test.Services"

### 🌐 Testes de Request

Usam `WebApplicationFactory` para testar endpoints reais:

dotnet test --filter "Test.Requests"

**Exemplo de saída esperada:**

```
Test run successful.
Total tests: 5
Passed: 5
Failed: 0
```

---

## ☁️ Deploy

### 📦 Build de Produção

dotnet publish -c Release -o ./publish

### 🐳 Docker (opcional)

Crie um arquivo `Dockerfile`:

```dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .
RUN dotnet publish Api.csproj -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Api.dll"]
```

Rode:

docker build -t gerenciador-veiculos .
docker run -d -p 8080:80 gerenciador-veiculos

Acesse:

http://localhost:8080/swagger

## 📂 Estrutura do Projeto

📦 ProjetoGerenciadorVeiculos
 ┣ 📁 Api
 ┃ ┗ 📜 Program.cs
 ┣ 📁 Dominio
 ┃ ┣ 📁 Entidades
 ┃ ┣ 📁 DTOs
 ┃ ┣ 📁 Interfaces
 ┃ ┣ 📁 Servicos
 ┃ ┗ 📁 Enuns
 ┣ 📁 Infraestrutura
 ┃ ┗ 📁 Db
 ┣ 📁 Test
 ┃ ┣ 📁 Domain
 ┃ ┣ 📁 Services
 ┃ ┗ 📁 Requests
 ┗ 📜 ProjetoGerenciadorVeiculos.sln
```

---

## 🏁 Desafio DIO

Este projeto foi desenvolvido como parte do **Desafio .NET Minimal API da Digital Innovation One**, aplicando boas práticas de desenvolvimento backend e controle de acesso com JWT.

Repositório original de referência:
🔗 [https://github.com/digitalinnovationone/minimal-api](https://github.com/digitalinnovationone/minimal-api)

---

## 👨‍💻 Autor

**Leandro Braga Vilar**
📍 Desenvolvedor Backend (.NET | C#)
📧 [leandrobragavilar@gmail.com](mailto:leandrovilar@gmail.com)
🔗 [LinkedIn](https://www.linkedin.com/in/leandrovilar)
💻 [GitHub](https://github.com/leandrovilar)

---