namespace api.Services.Interfaces;

public interface ITodoService
{
    Task<IEnumerable<TodoResponseDto>> GetTodos();
    Task<TodoResponseDto> CreateTodo(CreateTodoDto dto);
}