<h1 align="center">Game Catalogue</h1>

## :computer: Projeto

Repositório de uma aplicação web desenvolvida para fins acadêmicos, o seu propósito de simular um catálogo pessoal de jogos aplicando conceitos do [Clean Architecture](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html), esse projeto está sujeito a futuras implemtações de acordo com suas necessidades.

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
- [Recurso de imagem - Pexels](https://www.pexels.com/pt-br/foto/macbook-prateado-ao-lado-do-sony-ps4-dualshock-4-preto-i-phone-6-prateado-e-chaveiro-redondo-preto-na-mesa-de-madeira-marrom-682933/)

## :floppy_disk: Clonar Repositório

`git clone https://github.com/PauloAlves8039/dotnet-core-game-catalogue.git`

## :camera: Diagrama do Banco de Dados

<p align="center"> <img src="https://github.com/PauloAlves8039/dotnet-core-game-catalogue/blob/master/src/GameCatalogue.WebUI/wwwroot/images/diagrama-game-catalogy.png" 
   title="Diagrama do Banco de Dados" /></p>
Diagrama gerado no Microsoft SQL Server Management Studio, o seu objetivo é exibir a estrutura da base de dados criada no projeto.

## :camera: Tela de Home

<p align="center"> <img src="https://github.com/PauloAlves8039/dotnet-core-game-catalogue/blob/master/src/GameCatalogue.WebUI/wwwroot/images/home.png" /></p>
Página Home com uma simples apresentação do projeto.

## :camera: Tela de Login

<p align="center"> <img src="https://github.com/PauloAlves8039/dotnet-core-game-catalogue/blob/master/src/GameCatalogue.WebUI/wwwroot/images/login.png" /></p>
Responsável pela autenticação dos usuários, nessa implementação foram utilziados recursos do ASP .NET Core Identity.

## :camera: Lista de Plataformas

<p align="center"> <img src="https://github.com/PauloAlves8039/dotnet-core-game-catalogue/blob/master/src/GameCatalogue.WebUI/wwwroot/images/platforms.png" /></p>
Como resultado nessa tela é exibida uma lista com as plataformas cadastradas, podendo ter acesso a uma outra tela para adicionar uma nova plataforma, 
em sua tabela ficam disponíveis botões de ações para edição, exibição e exclusão registros.

## :camera: Lista de Jogos

<p align="center"> <img src="https://github.com/PauloAlves8039/dotnet-core-game-catalogue/blob/master/src/GameCatalogue.WebUI/wwwroot/images/games.png" /></p>
Seguindo a mesma premissa da tela de platafomas aqui é exibida uma lista de jogos em uma tabela, tendo botões disponíveis com as mesmas ações para manipulações de registros.

## :camera: Tela de Cadastro do Jogo

<p align="center"> <img src="https://github.com/PauloAlves8039/dotnet-core-game-catalogue/blob/master/src/GameCatalogue.WebUI/wwwroot/images/games-create.png" /></p>
Essa tela é responsável pela adição de jogos, no qual contém uma interface intuitiva para salvar registros.

## :camera: Tela de Detalhes do Jogo

<p align="center"> <img src="https://github.com/PauloAlves8039/dotnet-core-game-catalogue/blob/master/src/GameCatalogue.WebUI/wwwroot/images/games-details.png" /></p>
Essa tela é responsável pela exibição de informações de um jogo, dentro dessa visualização é possível conferir a plataforma no qual o jogo pertence.


## Author

:boy: [Paulo Alves](https://github.com/PauloAlves8039)
