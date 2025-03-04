namespace todo_app.Models;

public class TodoEntry
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public bool IsCompleted { get; set; }
}
