using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Linq;

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
        private readonly IRepository<TodoList, Guid> _repository;
        public TodoListAppService(IRepository<TodoList, Guid> repository)
           : base(repository)
        {
            _repository = repository;
        }
        public List<TodolistDto.TodoListDto> GetListById(Guid UserId)
        {
            return _repository.Where(x => x.UserId == UserId).Select(x => new TodolistDto.TodoListDto { UserId = x.UserId, CreationTime = x.CreationTime, CreatorId = x.CreatorId, Description = x.Description, Id = x.Id, LastModificationTime = x.LastModificationTime, LastModifierId = x.LastModifierId, Tittle = x.Tittle }).ToList();
        }
        public TodolistDto.TodoListDto GetTodoList(Guid Id)
        {
            return _repository.Where(x => x.Id == Id).Select(x => new TodolistDto.TodoListDto { UserId = x.UserId, CreationTime = x.CreationTime, CreatorId = x.CreatorId, Description = x.Description, Id = x.Id, LastModificationTime = x.LastModificationTime, LastModifierId = x.LastModifierId, Tittle = x.Tittle }).FirstOrDefault();
        }
    }
}
