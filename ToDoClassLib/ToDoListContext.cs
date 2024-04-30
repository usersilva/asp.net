using Microsoft.EntityFrameworkCore;
using ToDoClassLib.Entities;

namespace ToDoClassLib
{
  public class ToDoListContext : DbContext
  {

    public DbSet<User> Users { get; set; }
    public DbSet<TaskApp> Tasks { get; set; }

    public ToDoListContext(DbContextOptions options) : base(options) { }
  }
}
