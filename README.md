# Cake.EntityFrameworkCore
A set of Cake aliases for Entity Framework Core (.NET Core or .NET5 ) code-first migration using the ef.dll.
Entity Framework Core does not provide an easy way to run migrations (database update) from a compile dll.

This addin is inspired by [Benjamin Day's](https://github.com/benday) script for [deploying ef core migrations](https://github.com/benday-inc/deploy-ef-core-migration) from a dll.

You can easily reference <code>Cake.EntityFrameworkCore</code> directly in your build script via a cake addin:

```csharp
#tool "nuget:?package=microsoft.entityframeworkcore.tools"
#addin "nuget:?package=Cake.EntityFrameworkCore"

EfCoreDatabaseUpdate(new EfCoreDatabaseUpdateSettings
{
    WorkingDirectory = @"c:/myproject",
    DbContextClassName = "MyDbContext",
    MigrationsNamespace = "My.Demo.Migrations",
    MigrationDll = "MyMigrations.dll",
    StartupDll = "MyWebUI.dll",
    Verbose = true,
    Version = true
});
```

## Discussion

If you have questions, search for an existing one, or create a new discussion on the Cake GitHub repository, using the `extension-q-a` category.

[![Join in the discussion on the Cake repository](https://img.shields.io/badge/GitHub-Discussions-green?logo=github)](https://github.com/cake-build/cake/discussions)

## License

[![License](http://img.shields.io/:license-mit-blue.svg)](http://cake-contrib.mit-license.org)

## References

* [DotNet Exec Command Reference](docs/dotnet-exec-reference.md)
* [ef core dotnet tool Reference](docs/ef-reference.md)