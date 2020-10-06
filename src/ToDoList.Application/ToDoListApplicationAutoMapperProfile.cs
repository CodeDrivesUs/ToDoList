using AutoMapper;

namespace ToDoList
{
    public class ToDoListApplicationAutoMapperProfile : Profile
    {
        public ToDoListApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<TodoList.TodoList, TodolistDto.TodoListDto>();
            CreateMap<TodolistDto.CreateUpdateTodoListDto, TodoList.TodoList>();
            CreateMap<TodoListItem.TodoListItem, TodoListItemDto.TodoListItemDto>();
            CreateMap<TodoListItemDto.CreateUpdateTodoListItemDto, TodoListItem.TodoListItem>();
        }
    }
}
