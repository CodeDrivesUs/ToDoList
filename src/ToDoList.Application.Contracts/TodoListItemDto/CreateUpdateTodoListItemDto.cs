using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace ToDoList.TodoListItemDto
{
    public class CreateUpdateTodoListItemDto 
    {
        public string Tittle { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public Guid TodoListId { get; set; }
    }
}
