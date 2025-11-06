# 🚗 Projeto Gerenciador de Veículos — Minimal API (.NET 8)

API desenvolvida em **.NET 8** utilizando o padrão **Minimal API**, com autenticação via **JWT**, controle de **Perfis de Usuário (Admin, Editor e Leitor)** e persistência em banco de dados **MySQL**.  
Este projeto foi desenvolvido como parte do **Desafio da Digital Innovation One (DIO)**.

---

## 🧱 Estrutura do Projeto

```

ProjetoGerenciadorVeiculos/
│
├── Api/
│   ├── Program.cs
│   ├── appsettings.json
│   ├── Infraestrutura/
│   │   └── DbContexto.cs
│   ├── Dominio/
│   │   ├── Entidades/
│   │   ├── DTOs/
│   │   ├── Interfaces/
│   │   └── Servicos/
│   └── Properties/
│
└── README.md

````

## ⚙️ Tecnologias Utilizadas

- **.NET 8 (C#)**
- **Entity Framework Core (Pomelo MySQL)**
- **Swagger / Swashbuckle**
- **Autenticação JWT (Json Web Token)**
- **Injeção de Dependência**
- **Minimal API**
- **Autorização por Roles (Admin, Editor, Leitor)**

---

## 🔐 Perfis de Usuário

| Perfil | Permissões |
|---------|-------------|
| **Admin** | Acesso total (CRUD completo em Usuários e Veículos) |
| **Editor** | Pode visualizar e editar, mas não excluir usuários |
| **Leitor** | Pode visualizar veículos e informações públicas |
| **Anônimo** | Pode acessar apenas rotas públicas (como `/` e `/login`) |

---

## 🧾 Funcionalidades Principais

### 🧍 Usuários (`/usuarios`)
- `GET /usuarios` → Lista todos os usuários (**Admin**)
- `GET /usuarios/{id}` → Busca usuário por ID (**Admin, Editor**)
- `POST /usuarios` → Cria novo usuário (**Admin**)
- `PUT /usuarios/{id}` → Atualiza usuário (**Admin, Editor**)
- `DELETE /usuarios/{id}` → Exclui usuário (**Admin**)

### 🚘 Veículos (`/veiculos`)
- `GET /veiculos` → Lista todos os veículos (**todos logados**)
- `GET /veiculos/{id}` → Busca veículo por ID (**todos logados**)
- `POST /veiculos` → Cadastra novo veículo (**Admin, Editor**)
- `PUT /veiculos/{id}` → Atualiza veículo (**Admin, Editor**)
- `DELETE /veiculos/{id}` → Remove veículo (**Admin**)

### 🔑 Autenticação (`/login`)
- Login com **email e senha**.
- Retorna **token JWT** válido por 3 horas.
- O token define automaticamente o perfil do usuário (Admin, Editor ou Leitor).

---

## 📘 Documentação da API (Swagger)

Após rodar o projeto, acesse a interface do Swagger:

👉 [http://localhost:5000/swagger](http://localhost:5000/swagger)

No botão **“Authorize”**, cole apenas seu token JWT.  
O Swagger adicionará automaticamente o prefixo **Bearer** no cabeçalho de autorização.

---

## ⚙️ Configuração do Projeto

### 1️⃣ Clone o Repositório
```bash
git clone github.com/leandrovilar/Cursos-de-programacao/tree/main/DIO/.NET/Desafio/ProjetoGerenciadorVeiculos
cd projeto-gerenciador-veiculos/Api
````

### 2️⃣ Configure o Banco de Dados

No arquivo `appsettings.json`, defina sua conexão MySQL:

```json
{
  "ConnectionStrings": {
    "MySql": "Server=localhost;Database=GerenciadorVeiculos;Uid=root;Pwd=suasenha;"
  },
  "Jwt": "chave-super-secreta-padrao-para-jwt-2025!"
}
```

### 3️⃣ Rode as Migrations

```bash
dotnet ef database update
```

### 4️⃣ Execute a API

```bash
dotnet run
```

Acesse o Swagger:
👉 [http://localhost:5000/swagger](http://localhost:5000/swagger)

---

## 🧩 Estrutura das Pastas

| Pasta                 | Função                                               |
| --------------------- | ---------------------------------------------------- |
| **Dominio/Entidades** | Modelos do sistema (Usuário, Veículo)                |
| **Dominio/DTOs**      | Objetos de transporte de dados                       |
| **Dominio/Servicos**  | Lógica de negócio e validações                       |
| **Infraestrutura/Db** | Configuração do banco e contexto do Entity Framework |
| **Program.cs**        | Configuração principal da API e das rotas            |

---

## 🧑‍💻 Exemplo de Login e Token

**Requisição:**

```json
POST /login
{
  "email": "admin@teste.com",
  "senha": "123456"
}
```

**Resposta:**

```json
{
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6...",
  "usuario": {
    "id": 1,
    "nome": "Administrador",
    "email": "admin@teste.com",
    "perfil": "Admin"
  }
}
```

Depois, use o token nas demais requisições autenticadas.

---

## 🌐 Deploy

Pode ser publicado via:

```bash
dotnet publish -c Release
```

E hospedado em:

* **Azure App Service**
* **Render**
* **Railway**
* **AWS Elastic Beanstalk**
* Ou rodando localmente com Docker.

---

## 🏁 Conclusão

Este projeto foi desenvolvido como parte do **Desafio DIO - Minimal API com .NET 8**.
Ele demonstra o uso prático de **autenticação JWT**, **roles de autorização**, **Entity Framework** e **Swagger**, seguindo boas práticas de desenvolvimento com **C# moderno**.

---

## 👨‍💻 Autor

**Leandro Braga Vilar**
Desenvolvedor Back-end C# | Estudante DIO
📧 Email: [leandrovilar@gmail.com](mailto:seuemail@exemplo.com)
🌐 GitHub: [github.com/leandrovilar](https://github.com/leandrovilar)
💼 LinkedIn: [linkedin.com/in/seulinkedin](https://linkedin.com/in/leandrovilar)
