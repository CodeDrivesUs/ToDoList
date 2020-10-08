using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ToDoList.Web.Pages.TodoList
{
    public class TodoListModel : PageModel
    {
        private readonly Services.ITodoListAppService _todoListAppService;
        private readonly Services.ITodoListItemAppService _todoListItemAppService;
        public TodoListModel(Services.ITodoListAppService todoListAppService, Services.ITodoListItemAppService todoListItemAppService)
        {
            _todoListAppService = todoListAppService;
            _todoListItemAppService = todoListItemAppService;
        }
         
        public  TodolistDto.TodoListDto todoListDto { get; set; }
        public List<TodoListItemDto.TodoListItemDto>  todoListItemDtos { get; set; }
        public void OnGet(Guid Id)
        {
            todoListDto = _todoListAppService.GetTodoList(Id);
            todoListItemDtos = _todoListItemAppService.GetListByListId(Id);
        }
    }
}