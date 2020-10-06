using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Application.Dtos;

namespace ToDoList.TodolistDto
{
    public class TodoListDto : AuditedEntityDto<Guid>
    {
        public string Tittle { get; set; }
        public string Description { get; set; }
    }
}
