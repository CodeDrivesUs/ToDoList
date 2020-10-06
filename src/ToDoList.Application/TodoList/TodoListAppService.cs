using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ToDoList.TodoList
{
    public class TodoListAppService : CrudAppService<
            TodoList, //The Book entity
            TodolistDto.TodoListDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            TodolistDto.CreateUpdateTodoListDto>, //Used to create/update a book
            Services.ITodoListAppService //implement the IBookAppService
    {
        public TodoListAppService(IRepository<TodoList, Guid> repository)
           : base(repository)
        {

        }
    }
}
