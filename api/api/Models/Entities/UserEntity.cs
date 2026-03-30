using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class UserEntity
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public required string  Username { get; set; }

    [Required]
    [EmailAddress]
    public string? Email { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public virtual ICollection<TodoEntity> Todos { get; set; } = new List<TodoEntity>();
}