using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class TodoEntity
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public required string Title { get; set; }
    [MaxLength(500)]
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CreatedAt { get; set; }

    public int? UserId { get; set; }

    [ForeignKey(nameof(UserId))]
    public UserEntity User { get; set; }
    
}