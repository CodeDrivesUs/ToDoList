using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace ToDoList.TodolistDto
{
   public class CreateUpdateTodoListDto : AuditedEntityDto<Guid>
    {
        [Required]
        [StringLength(100)]
        public string Tittle { get; set; }
        [Required]
        public string Description { get; set; }
        public Guid UserId { get; set; }
    }
}
