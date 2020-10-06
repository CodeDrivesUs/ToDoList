using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace ToDoList.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(ToDoListHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ToDoListConsoleApiClientModule : AbpModule
    {
        
    }
}
