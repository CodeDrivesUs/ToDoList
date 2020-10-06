using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ToDoList.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class ToDoListMigrationsDbContextFactory : IDesignTimeDbContextFactory<ToDoListMigrationsDbContext>
    {
        public ToDoListMigrationsDbContext CreateDbContext(string[] args)
        {
            ToDoListEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ToDoListMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new ToDoListMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ToDoList.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
