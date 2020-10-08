using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ToDoList.Web.Pages.PartialViews
{
    public class _itemDetailsModel : PageModel
    {
       
        private readonly Services.ITodoListItemAppService _todoListItemAppService;
        public _itemDetailsModel( Services.ITodoListItemAppService todoListItemAppService)
        {
            _todoListItemAppService = todoListItemAppService;
        }
        public List<TodoListItemDto.TodoListItemDto> todoListItemDtos { get; set; }
        public void OnGet(Guid Id)
        {
            todoListItemDtos = _todoListItemAppService.GetListByListId(Id);
        }
    }
}