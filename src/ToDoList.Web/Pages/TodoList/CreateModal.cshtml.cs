using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Web;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using Volo.Abp.Users;

namespace ToDoList.Web.Pages.TodoList
{
    public class CreateModalModel : ToDoListPageModel
    {
        [BindProperty]
        public TodoListItemDto.CreateUpdateTodoListItemDto todoListItem { get; set; }
        private readonly Services.ITodoListItemAppService _todoListItemAppService;
        private readonly ICurrentUser _CurrentUser;
        [TempData]
       public Guid TodolistId { get; set; }

        public CreateModalModel(Services.ITodoListItemAppService todoListItemAppService, ICurrentUser currentUser)
        {
            _todoListItemAppService = todoListItemAppService;
            _CurrentUser = currentUser;
        }
        public void OnGet(Guid Id)
        {
            TodolistId = Id;
            TempData["todoId"] = Id;
            TempData.Keep();
            todoListItem = new TodoListItemDto.CreateUpdateTodoListItemDto();
            todoListItem.TodoListId = TodolistId;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            Guid ID = (Guid)TempData["todoId"];
            todoListItem.TodoListId = ID;
            await _todoListItemAppService.CreateAsync(todoListItem);
            return RedirectToPage("/TodoList/TodoList",new {Id=ID });
          //  return NoContent();
        }
    }
}