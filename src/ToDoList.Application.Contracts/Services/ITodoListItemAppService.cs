using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;


namespace ToDoList.Services
{
    public interface ITodoListItemAppService : ICrudAppService< //Defines CRUD methods
             TodoListItemDto.TodoListItemDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            TodoListItemDto.CreateUpdateTodoListItemDto> //Used to create/update a book
    {
    }
}
