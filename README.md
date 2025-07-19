# RedRouteAPI 🚀

Welcome to **RedRouteAPI** – a humble yet ambitious attempt to build an intelligent logistics and routing system for Mars… or maybe just Earth for now. This project is a playground for trying out modern Microsoft technologies with a clean architecture approach. It’s not a toy. It’s a proving ground. 🔬

## 🧠 What is RedRouteAPI?

RedRouteAPI is the backend brain of a larger system that simulates autonomous rover movement, cargo delivery, and route optimization in a Mars base scenario (or any planet of your choosing). It will include:

- Domain-driven design (DDD)
- Clean Architecture principles
- .NET 8 (or newer)
- MediatR, CQRS, and maybe a bit of AI routing
- Modern DevOps (CI/CD, testing, etc.)

> 💡 This is **not** production code (yet). It's for experimentation, showcasing skills, and preparing for bigger things.

## Technologies

- [.NET 8](https://dotnet.microsoft.com/)
- ASP.NET Core Web API
- MediatR, FluentValidation
- Entity Framework Core / PostgreSQL
- Azure-ready (but runs locally too)

## Features (Planned)

- Track and visualize rovers in real-time
- AI-based route optimization
- Chat-like command interface to ask about orders
- Modular architecture that can grow into a full product

## Build

Run `dotnet build -tl` to build the solution.

## Run

To run the web application:

```bash
cd .\src\Web\
dotnet watch run
```

Navigate to https://localhost:5001. The application will automatically reload if you change any of the source files.

## Code Styles & Formatting

The template includes [EditorConfig](https://editorconfig.org/) support to help maintain consistent coding styles for multiple developers working on the same project across various editors and IDEs. The **.editorconfig** file defines the coding styles applicable to this solution.

## Code Scaffolding

The template includes support to scaffold new commands and queries.

Start in the `.\src\Application\` folder.

Create a new command:

```
dotnet new ca-usecase --name CreateTodoList --feature-name TodoLists --usecase-type command --return-type int
```

Create a new query:

```
dotnet new ca-usecase -n GetTodos -fn TodoLists -ut query -rt TodosVm
```

If you encounter the error *"No templates or subcommands found matching: 'ca-usecase'."*, install the template and try again:

```bash
dotnet new install Clean.Architecture.Solution.Template::9.0.10
```

## Test

The solution contains unit, integration, functional, and acceptance tests.

To run the unit, integration, and functional tests (excluding acceptance tests):
```bash
dotnet test --filter "FullyQualifiedName!~AcceptanceTests"
```

To run the acceptance tests, first start the application:

```bash
cd .\src\Web\
dotnet run
```

Then, in a new console, run the tests:
```bash
cd .\src\Web\
dotnet test
```

## Contributions

This is currently a solo mission, but collaborators are welcome once we pass the first orbit. PRs must respect the architecture boundaries and include tests!

## License

MIT (but please don’t deploy this on actual Mars missions… yet.)

⸻

Made with ☕, C#, and way too much curiosity.