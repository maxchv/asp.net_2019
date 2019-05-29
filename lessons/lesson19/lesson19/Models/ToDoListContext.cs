using lesson19.Models;
using Microsoft.EntityFrameworkCore;

namespace lesson19
{
    public class ToDoListContext: DbContext
    {
        public DbSet<ToDoItem> ToDoList { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("todolist");
        }
    }
}