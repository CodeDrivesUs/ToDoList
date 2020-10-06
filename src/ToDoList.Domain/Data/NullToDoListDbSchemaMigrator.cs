using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ToDoList.Data
{
    /* This is used if database provider does't define
     * IToDoListDbSchemaMigrator implementation.
     */
    public class NullToDoListDbSchemaMigrator : IToDoListDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}