using ToDoList.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ToDoListController : AbpController
    {
        protected ToDoListController()
        {
            LocalizationResource = typeof(ToDoListResource);
        }
    }
}