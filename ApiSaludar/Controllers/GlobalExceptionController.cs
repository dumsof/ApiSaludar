namespace ApiSaludar.Controllers
{
    using Microsoft.AspNetCore.Diagnostics;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using System.Net;

    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class GlobalExceptionController : ControllerBase
    {
        [HttpGet]
        [Route("/error")]
        public IActionResult HandleErrors()
        {
            var contextException = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var responseStatusCode = contextException.Error.GetType().Name switch
            {
                "NullReferenceException" => HttpStatusCode.BadRequest,
                _ => HttpStatusCode.ServiceUnavailable
            };

            return Problem(detail: contextException.Error.Message, statusCode: (int)responseStatusCode);
        }
    }
}