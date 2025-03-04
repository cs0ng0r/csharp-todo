using Microsoft.EntityFrameworkCore;
using TodoApp.WebApi.Infrastructure.Models;

namespace TodoApp.WebApi.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<TodoEntry> Todos { get; set; }
}