# IRepository

A generic repository interface for .NET applications implementing the repository pattern.

## Features

- Generic `IRepository<TEntity>` interface for data access abstraction
- Async/await support with `CancellationToken`
- LINQ-based querying with `IQueryable<T>`
- Extension methods for pagination and common operations
- No-tracking queries for read-only scenarios

## Installation

```bash
dotnet add package UkadGroup.IRepository
```

Or via NuGet Package Manager:
```
Install-Package UkadGroup.IRepository
```

## Usage

Implement the interface for your data access layer:

```csharp
public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly DbContext _context;

    public IQueryable<TEntity> GetAll() => _context.Set<TEntity>();

    public async Task<TEntity> GetByIdAsync(int id, CancellationToken ct = default)
        => await _context.Set<TEntity>().FindAsync(new object[] { id }, ct);

    // ... implement other methods
}
```

Use with dependency injection:

```csharp
services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
```

## Interface Methods

| Method | Description |
|--------|-------------|
| `GetAll()` | Returns all entities as queryable |
| `GetAllAsNoTracking()` | Returns entities without change tracking |
| `GetByIdAsync()` | Finds entity by ID |
| `AddAsync()` | Adds new entity |
| `Update()` | Updates existing entity |
| `Delete()` | Removes entity |
| `SaveChangesAsync()` | Persists changes |

## Downloads

[![NuGet](https://img.shields.io/nuget/v/UkadGroup.IRepository.svg)](https://www.nuget.org/packages/UkadGroup.IRepository)

## License

MIT License - see [LICENSE](LICENSE) for details.
