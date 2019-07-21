using System;
using Microsoft.AspNetCore.Builder;

namespace CookBook.Web.Middlewares
{
    public static class CustomMiddlewareExtensions
    {
        public static IApplicationBuilder RegisterCustomMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ProtectedPages>();
            return app;
        }
    }
}
