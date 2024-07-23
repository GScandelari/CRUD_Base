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

 
