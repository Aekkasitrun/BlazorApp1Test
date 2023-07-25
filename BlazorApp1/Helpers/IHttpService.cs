using BudgetBook.Data;
using System.Threading.Tasks;

namespace BlazorApp1.Helpers
{
    public interface IHttpService
    {
        Task<HttpResponseWrapper<object>> Post<T>(string url, T data);
    }
}
