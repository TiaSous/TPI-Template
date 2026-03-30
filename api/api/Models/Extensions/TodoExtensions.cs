namespace api.Models.Extensions;

public static class TodoExtensions
{
    // TodoResponseDto
    public static TodoResponseDto ToDto(this TodoEntity todoEntity)
    {
        return new TodoResponseDto
        (
            
            todoEntity.Id,
            todoEntity.Title,
            todoEntity.Description,
            todoEntity.IsCompleted,
            todoEntity.CreatedAt,
            todoEntity.UserId
        );
    }

    // CreateTodoDto
    public static TodoEntity ToEntity(this CreateTodoDto dto)
    {
        return new TodoEntity()
        {
            Title = dto.Title,
            Description = dto.Description,
            IsCompleted = false,
            CreatedAt = DateTime.UtcNow,
        };
    }
}