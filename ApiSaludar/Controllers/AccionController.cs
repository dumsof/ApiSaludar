namespace ApiSaludar.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Saludar.Business.IBusiness;
    using Saludar.Business.ModelsView.AccionBoton;
    using System.Net;

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccionController : ControllerBase
    {
        private readonly IAccionBotonBusiness business;

        public AccionController(IAccionBotonBusiness business)
        {
            this.business = business;
        }

        /// <summary>
        /// Operación para obtenre las acciones o eventos que realizan los botones al saludar.
        /// </summary>
        /// <response code="200">Operación realizada con éxito.</response>
        /// <response code="401">No existen permisos para utilizar el servicio.</response>
        /// <response code="404">No existen datos para la consulta realizada.</response>
        /// <response code="500">Error inesperado.</response>
        [HttpGet]
        [ProducesResponseType(typeof(ResponseGetAllAccionesBoton), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseGetAllAccionesBoton), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ResponseGetAllAccionesBoton), (int)HttpStatusCode.InternalServerError)]
        public IActionResult ObtenerTodasAccionesBoton()
        {
            ResponseGetAllAccionesBoton respuesta = this.business.GetAllAccionesBoton();

            return new OkObjectResult(respuesta);
        }
    }
}