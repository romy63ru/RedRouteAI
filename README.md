# RedRouteAPI 🚀

Welcome to **RedRouteAPI** – a humble yet ambitious attempt to build an intelligent logistics and routing system for Mars… or maybe just Earth for now. This project is a playground for trying out modern Microsoft technologies with a clean architecture approach. It’s not a toy. It’s a proving ground. 🔬

## 🧠 What is RedRouteAPI?

RedRouteAPI is the backend brain of a larger system that simulates autonomous rover movement, cargo delivery, and route optimization in a Mars base scenario (or any planet of your choosing). It will include:

- ✅ Domain-driven design (DDD)
- ✅ Clean Architecture principles
- ✅ .NET 8 (or newer)
- ✅ MediatR, CQRS, and maybe a bit of AI routing
- ✅ Modern DevOps (CI/CD, testing, etc.)

> 💡 This is **not** production code (yet). It's for experimentation, showcasing skills, and preparing for bigger things.

## 📦 Project Structure

RedRouteAI/
├── src/
│   ├── RedRoute.API/            # The main entry point (Web API)
│   ├── RedRoute.Application/    # Use cases, commands, handlers
│   ├── RedRoute.Domain/         # Core business logic and models
│   └── RedRoute.Infrastructure/ # DB access, external services
├── tests/
│   ├── RedRoute.API.Tests/
│   └── …
└── RedRouteAI.sln

## 🛠️ Technologies

- [.NET 8](https://dotnet.microsoft.com/)
- ASP.NET Core Web API
- MediatR, FluentValidation
- Entity Framework Core / PostgreSQL
- Azure-ready (but runs locally too)

## 🤖 Features (Planned)

- Track and visualize rovers in real-time
- AI-based route optimization
- Chat-like command interface to ask about orders
- Modular architecture that can grow into a full product

## 🚀 Getting Started

```bash
git clone https://github.com/your-username/RedRouteAI.git
cd RedRouteAI
dotnet build
dotnet run --project src/RedRoute.API

🧪 Running Tests

dotnet test

🙌 Contributions

This is currently a solo mission, but collaborators are welcome once we pass the first orbit. PRs must respect the architecture boundaries and include tests!

📄 License

MIT (but please don’t deploy this on actual Mars missions… yet.)

⸻

Made with ☕, C#, and way too much curiosity.
