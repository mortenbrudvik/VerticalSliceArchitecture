namespace Domain;

public class TaskList
{
    public int Id { get; set; } // Primary key
    public string Name { get; set; }

    // Foreign key
    public int RoomId { get; set; }

    // Navigation properties
    public Room Room { get; set; }
    public ICollection<Task> Tasks { get; set; } = new List<Task>();
}