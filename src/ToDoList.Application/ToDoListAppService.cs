using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Localization;
using Volo.Abp.Application.Services;

namespace ToDoList
{
    /* Inherit your application services from this class.
     */
    public abstract class ToDoListAppService : ApplicationService
    {
        protected ToDoListAppService()
        {
            LocalizationResource = typeof(ToDoListResource);
        }
    }
}
