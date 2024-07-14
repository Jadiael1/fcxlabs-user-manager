# FCxLabs.UserManager

FCxLabs.UserManager é uma aplicação ASP.NET Core para gerenciamento de usuários, incluindo funcionalidades de autenticação, consulta de usuários e operações CRUD.


# Front-End
- [Front-FCxLabs-User-Manager](https://github.com/Jadiael1/front-fcxlabs-user-manager)


## Funcionalidades

- Autenticação de usuários
- Redefinição de credenciais
- Consulta avançada de usuários
- Operações CRUD (Create, Read, Update, Delete)
- Documentação da API com Swagger

## Estrutura do Projeto

- **Controllers**: Contém os controladores da API
  - `AuthController.cs`
  - `UserQueryController.cs`
  - `UsersController.cs`
- **Data**: Contém o contexto do banco de dados e a entidade User
  - `AppDbContext.cs`
  - `User.cs`
- **Properties**: Configurações do projeto
  - `launchSettings.json`
- **.vscode**: Configurações para o Visual Studio Code
  - `launch.json`
  - `tasks.json`
- **Configuration**: Arquivos de configuração
  - `appsettings.json`
  - `appsettings.Development.json`
- **Root Directory**: Arquivos principais
  - `Program.cs`
  - `Startup.cs`
  - `.gitignore`
  - `LICENSE`
  - `global.json`

## Pré-requisitos

- [.NET 5.0 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- [MySQL](https://www.mysql.com/)

## Configuração

1. Clone o repositório:
   ```sh
   git clone git@github.com:Jadiael1/fcxlabs-user-manager.git
   cd fcxlabs-user-manager
   ```

2. Configure os arquivo `appsettings.Development.json`, `appsettings.json`. Ex:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "server=127.0.0.1; port=3306; database=<db_name>; uid=<db_user>; password=<db_password>"
     },
     "Logging": {
       "LogLevel": {
         "Default": "Information",
         "Microsoft": "Warning",
         "Microsoft.Hosting.Lifetime": "Information"
       }
     },
     "AllowedHosts": "*"
   }
   ```

3. Execute as migrações do Entity Framework Core para criar o banco de dados:
   ```sh
   dotnet ef migrations add Initial
   dotnet ef database update
   ```

## Execução

Para iniciar a aplicação em modo de desenvolvimento, utilize o Visual Studio Code ou o terminal:

### Visual Studio Code

- Abra o projeto no Visual Studio Code
- Pressione `F5` para iniciar a depuração

### Terminal

- Execute a aplicação:
  ```sh
  dotnet run
  ```

A aplicação estará disponível em [http://localhost:9876](http://localhost:9876).

## Uso

### Swagger

A documentação da API está disponível através do Swagger. Após iniciar a aplicação, acesse:
[http://localhost:9876](http://localhost:9876)

## Configurações do Visual Studio Code

### `.vscode/launch.json`

```json
{
    "version": "0.2.0",
    "configurations": [
        {
            "name": "FCxLabs.UserManager (Development)",
            "type": "coreclr",
            "request": "launch",
            "preLaunchTask": "build",
            "program": "${workspaceFolder}/bin/Debug/net5.0/FCxLabs.UserManager.dll",
            "args": [],
            "cwd": "${workspaceFolder}",
            "stopAtEntry": false,
            "serverReadyAction": {
                "action": "openExternally",
                "pattern": "\\bNow listening on:\\s+(https?://\\S+)"
            },
            "env": {
                "ASPNETCORE_ENVIRONMENT": "Development",
                "ASPNETCORE_URLS": "http://localhost:9876",
                "DOTNET_PRINT_TELEMETRY_MESSAGE": "false"
            },
            "sourceFileMap": {
                "/Views": "${workspaceFolder}/Views"
            }
        }
    ]
}
```

### `.vscode/tasks.json`

```json
{
    "version": "2.0.0",
    "tasks": [
        {
            "label": "build",
            "command": "dotnet",
            "type": "process",
            "args": [
                "build",
                "${workspaceFolder}/FCxLabs.UserManager.csproj",
                "/property:GenerateFullPaths=true",
                "/consoleloggerparameters:NoSummary"
            ],
            "problemMatcher": "$msCompile"
        },
        {
            "label": "publish",
            "command": "dotnet",
            "type": "process",
            "args": [
                "publish",
                "${workspaceFolder}/FCxLabs.UserManager.csproj",
                "/property:GenerateFullPaths=true",
                "/consoleloggerparameters:NoSummary"
            ],
            "problemMatcher": "$msCompile"
        },
        {
            "label": "watch",
            "command": "dotnet",
            "type": "process",
            "args": [
                "watch",
                "run",
                "${workspaceFolder}/FCxLabs.UserManager.csproj",
                "/property:GenerateFullPaths=true",
                "/consoleloggerparameters:NoSummary"
            ],
            "problemMatcher": "$msCompile"
        }
    ]
}
```

## Contribuição

Sinta-se à vontade para contribuir com este projeto através de pull requests.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
