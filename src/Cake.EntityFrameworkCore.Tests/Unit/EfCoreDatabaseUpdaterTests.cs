using Xunit;

namespace Cake.EntityFrameworkCore.Tests.Database
{
    public sealed class EfCoreDatabaseUpdaterTests
    {
        public sealed class TheUpdateMethod
        {
            [Fact]
            public void Should_Throw_If_Settings_Are_Null()
            {
                // Given
                var fixture = new EfCoreDatabaseUpdaterFixture();
                fixture.Settings = null;

                // When
                var result = Record.Exception(() => fixture.Run());

                // Then
                result.IsArgumentNullException("settings");
            }

            [Theory]
            [InlineData("database update --data-dir \"c:/Temp/DataDirectory\"")]
            public void Should_Update(string expected)
            {
                // Given
                var fixture = new EfCoreDatabaseUpdaterFixture();

                fixture.Settings.WorkingDirectory = "c:/myproject";
                fixture.Settings.DbContextClassName = "MyDbContext";
                fixture.Settings.MigrationsNamespace = "My.Demo.Migrations";
                fixture.Settings.MigrationDll = "MyNamespace.Migrations.dll";
                fixture.Settings.StartupDll = "MyNamespace.WebUI.dll";
                fixture.Settings.Verbose = true;
                fixture.Settings.Verbosity = Common.Tools.DotNetCore.DotNetCoreVerbosity.Diagnostic;
                fixture.Settings.Version = true;

                // When
                var result = fixture.Run();

                // Then
                Assert.Equal(expected, result.Args);
            }
        }
    }
}
