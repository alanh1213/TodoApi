using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
            //Constructor
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
