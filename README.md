<h1 align="center">Game Catalogue</h1>

Repositório de uma aplicação web desenvolvida para fins acadêmicos, o seu propósito de simular um catálogo pessoal de jogos aplicando conceitos do [Clean Architecture](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html).

Essa aplicação dispõe de um catálago com funcionalidades para inserir, buscar, atualizar e excluir registros em um relacionamento do tipo 1:N (um para muitos)
onde uma plataforma possui vários jogos, mas um jogo só pertence a uma plataforma dentro desse cenário, já para a criação do banco de dados foram usados o [Entity Framework Core](https://docs.microsoft.com/pt-br/ef/core/) e os recursos
do [Code First Migrations](https://docs.microsoft.com/pt-br/ef/ef6/modeling/code-first/migrations/) para essas implementações no
[SQL Server 2019](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads).

Foram adicionados recursos para autenticação e autorização de usuários na aplicação com o [ASP .NET Core Identity](https://docs.microsoft.com/pt-br/aspnet/core/security/authentication/identity?view=aspnetcore-5.0&tabs=visual-studio), onde é possível adicionar novos usuários para realizar seus respectivos acessos através de credenciais.

Em todas as Views foram utilizados componentes do [Bootstrap](https://getbootstrap.com/), com o objetivo de aplicar estilos [CSS](https://getbootstrap.com/) para uma melhor experiência do usuário na iteração com os elementos de telas na aplicação.

## :wrench: Recursos Utilizados

- [Visual Studio v16.9.5](https://visualstudio.microsoft.com/pt-br/)
- [ASP.NET Core MVC v5.0.203](https://dotnet.microsoft.com/download/dotnet/5.0)
- [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/getting-started/)
- [Entity Framework Core v5.0.7](https://docs.microsoft.com/pt-br/ef/core/)
- [SQL Server v18.8](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- [AutoMapper v10.1.1](https://automapper.org/)
- [Identity v2.2.0](https://docs.microsoft.com/pt-br/aspnet/core/security/authentication/identity?view=aspnetcore-5.0&tabs=visual-studio)
- [XUnit v2.4.1](https://xunit.net/)
- [FluentAssertions v5.10.3](https://fluentassertions.com/)
- [Bootstrap v4.3.1](https://getbootstrap.com/)

## :floppy_disk: Clonar Repositório

`git clone https://github.com/PauloAlves8039/dotnet-core-game-catalogue.git`

## Author

:boy: [Paulo Alves](https://github.com/PauloAlves8039)
