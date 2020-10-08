using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Volo.Abp.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Users;

namespace ToDoList.Web.Pages.TodoList
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly Services.ITodoListAppService _TodoListAppService;
        private readonly ICurrentUser _CurrentUser;
        [BindProperty]
        public List<TodolistDto.TodoListDto> todoList { get; set; }

        public IndexModel(Services.ITodoListAppService todoListAppService, ICurrentUser currentUser)
        {
            _TodoListAppService = todoListAppService;
            _CurrentUser = currentUser;
        }
        public void OnGet()
        {     
            todoList = _TodoListAppService.GetListById((Guid)_CurrentUser.Id);
        }
    }
}