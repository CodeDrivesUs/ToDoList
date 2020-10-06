using ToDoList.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ToDoList.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class ToDoListPageModel : AbpPageModel
    {
        protected ToDoListPageModel()
        {
            LocalizationResourceType = typeof(ToDoListResource);
        }
    }
}