using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ToDoList.TodolistDto
{
   public class CreateUpdateTodoListDto
    {
        [Required]
        [StringLength(100)]
        public string Tittle { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
