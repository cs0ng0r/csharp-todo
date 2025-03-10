﻿using System.ComponentModel.DataAnnotations;
namespace TodoApp.WebApi.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;        
        public bool IsCompleted { get; set; }
    }
}