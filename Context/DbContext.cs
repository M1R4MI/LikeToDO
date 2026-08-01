using LikeToDo.Models;
using Microsoft.EntityFrameworkCore;

namespace LikeToDo.Context
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions options) : base(options)
        {            
        }

        public DbSet<TaskItem> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}