namespace Domain;

public class Task
{
    public int Id { get; set; } 
    public string Name { get; init; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }

    public int TaskListId { get; set; }

    public TaskList TaskList { get; set; } // Navigation property
}