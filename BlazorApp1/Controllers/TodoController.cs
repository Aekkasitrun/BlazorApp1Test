using BudgetBook.Data;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController: ControllerBase 
    {
        private readonly ApplicationDbContext context;

        public TodoController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Todo todo)
        {
            context.Add(todo);
            Console.WriteLine("Todo in controller = " + todo.Description);
            await context.SaveChangesAsync();
            return todo.Id;
        }
    }
}
