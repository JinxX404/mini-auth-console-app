# Authentication in C# (.NET Console App)

This is a simple and modular authentication and authorization system built using C# and .NET Core.

It supports:
- User registration and login
- Password hashing with SHA256
- Input validation (email, username, password strength)
- Data storage using SQL Server and Entity Framework Core
- Modular structure with services, helpers, and UI separation
- Reusable authentication logic for other apps

---

## Project Structure
```
ConsoleUI         → Handles all console interactions
Services          → AuthService logic (Login, Register)
Models            → User entity
Helpers           → Validation, hashing, console input
Migrations        → EF Core database migrations
AppDbContext.cs   → DB context for EF Core
Program.cs        → App entry point
```
