using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoList.TodoListItemDto;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Linq;
using System.Linq;

namespace ToDoList.TodoListItem
{
    public class TodoListItemAppService : CrudAppService<
             TodoListItem, //The Book entity
            TodoListItemDto.TodoListItemDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateTodoListItemDto>, //Used to create/update a book
            Services.ITodoListItemAppService //implement the IBookAppService
    {
        private IRepository<TodoListItem, Guid> _listItemsRepository;
        public TodoListItemAppService(IRepository<TodoListItem, Guid> repository)
           : base(repository)
        {
            _listItemsRepository = repository;
        }
        public List<TodoListItemDto.TodoListItemDto> GetListByListId(Guid tolistId)
        {     
            return _listItemsRepository.Where(x=>x.TodoListId==tolistId).Select(x=> new TodoListItemDto.TodoListItemDto {
             LastModifierId=x.LastModifierId, TodoListId=x.TodoListId , CreationTime=x.CreationTime , CreatorId=x.CreatorId , Description=x.Description , Id=x.Id 
            }).ToList();
        }
   
    }
}
