using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MiddlewareTest.Middleware
{
    public class MyFirstMiddleware
    {
        private readonly RequestDelegate _next;

        public MyFirstMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await context.Response.WriteAsync($"{nameof(MyFirstMiddleware)} in. \r\n");

            await _next(context);

            await context.Response.WriteAsync($"{nameof(MyFirstMiddleware)} out. \r\n");
        }
    }
}
