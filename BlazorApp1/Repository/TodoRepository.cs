using BlazorApp1.Helpers;
using BlazorApp1.Pages.Todolist.Input;
using BudgetBook.Data;

namespace BlazorApp1.Repository
{
    public class TodoRepository: ITodoRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/todo";
        public TodoRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task CreateTodo(Todo todo)
        {
            var response = await httpService.Post(url, todo);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
