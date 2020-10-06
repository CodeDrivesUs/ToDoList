using ToDoList.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ToDoList
{
    [DependsOn(
        typeof(ToDoListEntityFrameworkCoreTestModule)
        )]
    public class ToDoListDomainTestModule : AbpModule
    {

    }
}