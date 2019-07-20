using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using CookBook.Entities.Users;
using CookBook.Services.Session;
using Microsoft.AspNetCore.Http;

namespace CookBook.Web.Middlewares
{
    public class ProtectedPages
    {
        private readonly RequestDelegate _next;
        private readonly List<string> ProtectedRouteList = new List<String>()
        {
            "/Home"
        };


        public ProtectedPages(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var route = ProtectedRouteList.FirstOrDefault(routePath => routePath.Equals(context.Request.Path));
            if (route != null)
            {
                try
                {
                    var User = context.Session.GetObject<User>("currentUser");
                    if (User == null)
                        context.Response.Redirect("/");
                }
                catch (Exception)
                {
                    context.Response.Redirect("/");
                }
            }
            else
            {
                await _next(context);
            }
        }
    }
}