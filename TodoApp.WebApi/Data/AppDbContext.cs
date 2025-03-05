using Microsoft.EntityFrameworkCore;
using TodoApp.WebApi.Models;

namespace TodoApp.WebApi.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}