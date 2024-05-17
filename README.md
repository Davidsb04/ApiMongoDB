# API CRUD com ASP.NET Core

Este repositório contém a API para um aplicativo CRUD (Create, Read, Update, Delete) desenvolvido com ASP.NET Core. A API permite operações CRUD em registros de clientes e utiliza o MongoDB como banco de dados.

## Requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) 6.0 ou superior
- [MongoDB](https://www.mongodb.com/) instalado e em execução

## Configuração e Execução

1. **Clone o repositório:**

    ```bash
    git clone https://github.com/seu-usuario/nome-do-repositorio-api.git
    cd nome-do-repositorio-api
    ```

2. **Restaure as dependências do NuGet:**

    ```bash
    dotnet restore
    ```

3. **Configure o MongoDB:**

    Certifique-se de que o MongoDB está em execução. A configuração padrão da conexão com o MongoDB está em `appsettings.json`. Caso necessário, ajuste a string de conexão.

4. **Execute a aplicação:**

    ```bash
    dotnet run
    ```

    A API estará disponível em `http://localhost:5265`.
