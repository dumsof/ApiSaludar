namespace ApiSaludar.Extensions
{
    using ApiSaludar.Models;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Diagnostics;
    using Microsoft.AspNetCore.Http;
    using System.Net;

    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(errorApp => errorApp.Run(async context =>
            {
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
                var exception = exceptionHandlerPathFeature.Error;

                await context.Response.WriteAsync(new MensajeExeption
                {
                    Codigo = context.Response.StatusCode,
                    Mensaje = $"Error interno en el servidor : {exception.Message} ",
                    Exception = string.Empty
                }.ToString());
            }));
        }
    }
}