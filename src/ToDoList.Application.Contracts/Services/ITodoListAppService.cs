using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ToDoList.Services
{
    public interface ITodoListAppService : ICrudAppService< //Defines CRUD methods
            TodolistDto.TodoListDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            TodolistDto.CreateUpdateTodoListDto> //Used to create/update a book
    {
    }
}
