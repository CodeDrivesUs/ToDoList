using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace ToDoList.TodoList
{
    public  class TodoList : AuditedAggregateRoot<Guid>
    {
        public string Tittle { get; set; }
        public Guid UserId { get; set; }
        public string Description { get;set; }
    }
}
