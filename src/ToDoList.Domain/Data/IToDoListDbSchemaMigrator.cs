using System.Threading.Tasks;

namespace ToDoList.Data
{
    public interface IToDoListDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
