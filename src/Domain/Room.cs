namespace Domain;

public class Room
{
    public int Id { get; set; } // Primary key
    public string Name { get; set; }
    
    // Navigation property
    public ICollection<TaskList> TaskLists { get; set; } = new List<TaskList>();
}