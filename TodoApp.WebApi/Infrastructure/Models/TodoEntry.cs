using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace TodoApp.WebApi.Infrastructure.Models;

public class TodoEntry
{
    public int Id { get; set; }

    [Required] public string TodoTitle { get; set; } = "";
    public bool IsDone { get; set; }
}