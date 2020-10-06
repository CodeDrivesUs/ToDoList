using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Volo.Abp.Users;

namespace ToDoList.Web.Pages.TodoList
{
    public class CreateModel : ToDoListPageModel
    {
        [BindProperty]
        public TodolistDto.CreateUpdateTodoListDto todoList { get; set; }

        private readonly Services.ITodoListAppService  _TodoListAppService;
        private readonly ICurrentUser _CurrentUser;

        public CreateModel(Services.ITodoListAppService todoListAppService , ICurrentUser currentUser )
        {
            _TodoListAppService = todoListAppService;
            _CurrentUser = currentUser;
        }
        public void OnGet()
        {
            todoList = new TodolistDto.CreateUpdateTodoListDto();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            todoList.UserId = (Guid)_CurrentUser.Id;
            await _TodoListAppService.CreateAsync(todoList);

            return RedirectToPage("/TodoList/Index");
        }
    }
}