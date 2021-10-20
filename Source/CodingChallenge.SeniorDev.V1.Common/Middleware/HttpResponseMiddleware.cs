using CodingChallenge.SeniorDev.V1.Common.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.Common.Middleware
{
    public class HttpResponseMiddleware : IMiddleware
    {
        public ILogger<HttpResponseMiddleware> _logger { get; }
        public HttpResponseMiddleware(ILogger<HttpResponseMiddleware> logger)
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message); //logging
                if (e.GetType().Name == "DomainNotFoundException")
                {
                    context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                }
                else if (e.GetType().Name == "UnauthorizedException")
                {
                    context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                }
                else if (e.GetType().Name == "BadRequestException")
                {
                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                }
                else
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                }
                //
                await context.Response.WriteAsync(new ErrorDetails()
                {
                    StatusCode = context.Response.StatusCode,
                    Message = e.Message
                }.ToString());
            }
        }
    }
}
