using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace ToDoList.TodoListItem
{

    public class TodoList : AuditedAggregateRoot<Guid>
    {
        public string Tittle { get; set; }
        public string Description { get; set; }
        public int MyProperty { get; set; }
        public Guid TodoListId { get; set; }
    }
}
