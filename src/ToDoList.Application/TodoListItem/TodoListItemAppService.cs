﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoList.TodoListItemDto;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ToDoList.TodoListItem
{
  public  class TodoListItemAppService : CrudAppService<
            ToDoList.TodoListItem.TodoListItem, //The Book entity
            TodoListItemDto.TodoListItemDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            TodoListItemDto.TodoListItemDto>, //Used to create/update a book
            Services.ITodoListItemAppService //implement the IBookAppService
    {
        public TodoListItemAppService(IRepository<TodoListItem, Guid> repository)
           : base(repository)
        {

        }

        public Task<TodoListItemDto.TodoListItemDto> CreateAsync(CreateUpdateTodoListItemDto input)
        {
            throw new NotImplementedException();
        }

        public Task<TodoListItemDto.TodoListItemDto> UpdateAsync(Guid id, CreateUpdateTodoListItemDto input)
        {
            throw new NotImplementedException();
        }
    }
}