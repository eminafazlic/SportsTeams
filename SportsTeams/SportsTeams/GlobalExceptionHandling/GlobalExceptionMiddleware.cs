using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Filters;

namespace SportsTeams.GlobalExceptionHandling
{
    public class GlobalExceptionMiddleware : ExceptionFilterAttribute
    {
        private readonly RequestDelegate _next;
        protected readonly ILogger<GlobalExceptionMiddleware> _logger;
        public GlobalExceptionMiddleware(RequestDelegate next, ILogger<GlobalExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"{context.Request.Method} ERROR -> " + e.Message + "\nPath: " + context.Request.Path + "\nMethod: " + context.Request.Method + "\nProtocol: " + context.Request.Protocol);
                await context.Response.WriteAsync($"{context.Request.Method} ERROR" + "\nPath: " + context.Request.Path + "\nMethod: " + context.Request.Method);
            }
        }
    } 
}
