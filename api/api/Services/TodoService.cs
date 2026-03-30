using api.Models.Extensions;
using api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

public class TodoService(AppDbContext _appDbContext) : ITodoService
{
     public async Task<IEnumerable<TodoResponseDto>> GetTodos()
    {
        var todoEntities = await _appDbContext.Todos.Include(b => b.User).ToListAsync();
        return todoEntities.Select(todoEntity => todoEntity.ToDto()).ToList();
    }

    public async Task<TodoResponseDto> CreateTodo(CreateTodoDto dto)
    {
        var entity = dto.ToEntity();

        _appDbContext.Todos.Add(entity);
        await _appDbContext.SaveChangesAsync();

        return entity.ToDto();
    }
}