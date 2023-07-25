using BudgetBook.Data;

namespace BlazorApp1.Repository
{
    public interface ITodoRepository
    {
        Task CreateTodo(Todo todo);
    }
}
