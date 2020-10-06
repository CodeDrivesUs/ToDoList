using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using Volo.Abp.Users;

namespace ToDoList.Web.Pages.TodoList
{
    public class CreateModalModel : ToDoListPageModel
    {
        [BindProperty]
        public TodoListItemDto.TodoListItemDto todoListItem { get; set; }
        //private readonly Services.ITodoListItemAppService _todoListItemAppService;
        //private readonly ICurrentUser _CurrentUser;

        //public CreateModalModel(Services.ITodoListItemAppService todoListItemAppService, ICurrentUser currentUser)
        //{
        //    _todoListItemAppService = todoListItemAppService;
        //    _CurrentUser = currentUser;
        //}
        public void OnGet()
        {

        }
    }
}