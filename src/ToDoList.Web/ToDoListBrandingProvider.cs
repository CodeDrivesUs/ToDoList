using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace ToDoList.Web
{
    [Dependency(ReplaceServices = true)]
    public class ToDoListBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ToDoList";
    }
}
