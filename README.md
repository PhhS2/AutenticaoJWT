# Autenticação JWT com ASP.NET 10

Este repositório contém uma implementação de exemplo de autenticação e autorização utilizando **JSON Web Tokens (JWT)** no ecossistema .NET 10. O objetivo deste projeto é demonstrar as melhores práticas atuais para proteger APIs.

## Tecnologias e Funcionalidades

- **ASP.NET Core 10**: Versão mais recente da plataforma.
- **JWT Bearer**: Middleware oficial para validação de tokens.
- **C# Records**: Utilização de `records` para DTOs e Modelos, garantindo imutabilidade 
- **Role-Based Authorization**: Controlo de acesso baseado em funções de utilizador.

##  Estrutura do Código

- `Models/`: Definição do objeto `User` utilizando a sintaxe de *Positional Records*.
- `Service/`: Implementação do `TokenService` responsável por gerar o hash JWT.
- `Configuration.cs`: Armazenamento centralizado da chave privada (apenas para fins de estudo).
- `Program.cs`: Configuração dos serviços de autenticação e definição dos middlewares.

##  Como Executar

### Pré-requisitos
- [.NET 10 SDK](https://dotnet.microsoft.com/download) instalado.

### Passo a Passo
1. Clone o repositório:
   ```bash
   git clone [https://github.com/TEU-USUARIO/AutenticaoJWT.git](https://github.com/TEU-USUARIO/AutenticaoJWT.git)
   Navegue até a pasta do projeto (onde está o .csproj):

2. ```bash
   cd JwtBearer
   Instale o pacote necessário:

3. ```bash
   dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
   Execute a aplicação:

4. ```bash
   dotnet run


## AVISO

- este codigo foi feito como base de estudo nao se deve jamais usar em producao, pois sua chave privada nao pode ser passada no codigo, isto foi feito para fins educativos.
