using System.ComponentModel.DataAnnotations;

namespace ToDoList.Domain.Entities;

public class TaskEntity
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Description { get; set; } = string.Empty;
    
    public bool isDone { get; set; } = false;

}