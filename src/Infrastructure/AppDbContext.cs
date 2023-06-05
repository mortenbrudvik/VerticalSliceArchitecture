using Domain;
using Microsoft.EntityFrameworkCore;
using Task = System.Threading.Tasks.Task;

namespace Infrastructure;

public class AppDbContext: DbContext
{
    public DbSet<Room> Rooms { get; set; }
    public DbSet<TaskList> TaskLists { get; set; }
    public DbSet<Task> Tasks { get; set; }
}