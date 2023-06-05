For SQL Server:
```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
```

For In-Memory Database:
```bash
dotnet add package Microsoft.EntityFrameworkCore.InMemory
dotnet add package Microsoft.EntityFrameworkCore.Design
```

EF Core CLI
```bash
dotnet tool install --global dotnet-ef
```     

Migrations
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```
