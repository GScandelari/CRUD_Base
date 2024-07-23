### README.md

# CRUD_Base

CRUD_Base é uma aplicação básica para o cadastro de pessoas, utilizando C# no backend com ASP.NET Core e Entity Framework, e um banco de dados SQL Server.

## Funcionalidades

- **Listar Pessoas**: Recupera uma lista de todas as pessoas cadastradas.
- **Obter Pessoa por ID**: Recupera os detalhes de uma pessoa específica pelo seu ID.
- **Criar Pessoa**: Adiciona uma nova pessoa ao cadastro.
- **Atualizar Pessoa**: Atualiza os dados de uma pessoa existente.
- **Excluir Pessoa**: Remove uma pessoa do cadastro.

## Estrutura do Projeto

- **Controllers**: Contém o controlador `PessoaController` que gerencia as operações CRUD.
- **Data**: Contém o contexto de banco de dados `CRUDContext`.
- **Models**: Contém a classe `Pessoa` que define a estrutura da entidade.
- **Migrations**: Contém as migrações geradas pelo Entity Framework.
- **Properties**: Configurações do projeto.
- **appsettings.json**: Arquivo de configuração do aplicativo.
- **Program.cs**: Arquivo principal para configurar e iniciar o aplicativo.

## Configuração do Banco de Dados

Certifique-se de que você tenha um servidor SQL Server em execução e atualize a string de conexão no arquivo `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=SEU_SERVIDOR;Database=CRUD_Base;Trusted_Connection=True;"
  }
}
```

## Executando o Projeto

### Pré-requisitos

- .NET 6 SDK ou superior
- SQL Server

### Passos

1. Clone o repositório:

```bash
git clone https://github.com/SEU_USUARIO/CRUD_Base.git
cd CRUD_Base
```

2. Adicione as migrações e atualize o banco de dados:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

3. Execute o projeto:

```bash
dotnet run
```

4. Acesse a documentação da API no navegador:

```
https://localhost:5001/swagger
```

## Endpoints da API

### Listar todas as pessoas

```
GET /api/pessoa
```

### Obter uma pessoa pelo ID

```
GET /api/pessoa/{id}
```

### Criar uma nova pessoa

```
POST /api/pessoa
Content-Type: application/json

{
  "nome": "João",
  "sobrenome": "Silva",
  "email": "joao.silva@example.com",
  "dataNascimento": "1990-01-01T00:00:00"
}
```

### Atualizar uma pessoa existente

```
PUT /api/pessoa/{id}
Content-Type: application/json

{
  "id": 1,
  "nome": "João",
  "sobrenome": "Silva",
  "email": "joao.silva@example.com",
  "dataNascimento": "1990-01-01T00:00:00"
}
```

### Remover uma pessoa pelo ID

```
DELETE /api/pessoa/{id}
```

## Contribuição

Sinta-se à vontade para fazer um fork do projeto e enviar pull requests. Qualquer contribuição é bem-vinda!

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).


### Adicional: Arquivo .gitignore

Para garantir que você não envie arquivos desnecessários para o GitHub, adicione um arquivo `.gitignore` no seu projeto com o seguinte conteúdo:

```gitignore
# Compiled files
bin/
obj/

# User-specific files
.vscode/
*.user
*.rsuser

# ASP.NET
appsettings.Development.json

# Entity Framework
Migrations/

# Rider
.idea/

# Visual Studio
.vs/
```
