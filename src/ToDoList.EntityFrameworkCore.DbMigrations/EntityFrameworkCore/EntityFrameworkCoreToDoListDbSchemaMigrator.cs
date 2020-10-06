using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ToDoList.Data;
using Volo.Abp.DependencyInjection;

namespace ToDoList.EntityFrameworkCore
{
    public class EntityFrameworkCoreToDoListDbSchemaMigrator
        : IToDoListDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreToDoListDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ToDoListMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ToDoListMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}