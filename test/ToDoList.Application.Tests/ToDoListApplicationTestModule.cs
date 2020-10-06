using Volo.Abp.Modularity;

namespace ToDoList
{
    [DependsOn(
        typeof(ToDoListApplicationModule),
        typeof(ToDoListDomainTestModule)
        )]
    public class ToDoListApplicationTestModule : AbpModule
    {

    }
}