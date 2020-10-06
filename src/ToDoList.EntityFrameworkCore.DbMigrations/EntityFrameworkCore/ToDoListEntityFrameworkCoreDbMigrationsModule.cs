using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace ToDoList.EntityFrameworkCore
{
    [DependsOn(
        typeof(ToDoListEntityFrameworkCoreModule)
        )]
    public class ToDoListEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ToDoListMigrationsDbContext>();
        }
    }
}
