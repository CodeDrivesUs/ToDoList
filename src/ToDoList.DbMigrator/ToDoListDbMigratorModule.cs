using ToDoList.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ToDoList.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ToDoListEntityFrameworkCoreDbMigrationsModule),
        typeof(ToDoListApplicationContractsModule)
        )]
    public class ToDoListDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
