using api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("todo")]
public class TodoController(ITodoService _todoService) : ControllerBase
{

    /// <summary>
    /// Get all Todos
    /// </summary>
    /// <returns>All Todos</returns>
    [HttpGet]
    public async Task<IEnumerable<TodoResponseDto>> GetAll()
    {
        var response = await _todoService.GetTodos();
        return response;
    }

    /// <summary>
    /// Create a Todo
    /// </summary>
    /// <param name="dto">Todo</param>
    /// <returns>Created todo</returns>
    [HttpPost]
    public async Task<TodoResponseDto> CreateTodo(CreateTodoDto dto)
    {
        var response = await _todoService.CreateTodo(dto);
        return response;
    }
    
}