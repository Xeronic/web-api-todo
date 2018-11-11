using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace Todo.Models
{
    public class TodosContext : DbContext
    {
        public TodosContext(DbContextOptions<TodosContext> options)
            : base(options)
        { }

        public DbSet<TodoList> TodoLists { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }
    }

    public class TodoList
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public List<TodoItem> TodoItems { get; set; }
    }

    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }

        public int TodoListId { get; set; }
        public TodoList TodoList { get; set; }
    }
}