namespace ApiSaludar.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Saludar.Business.IBusiness;
    using Saludar.Business.ModelsView.Saludo;
    using System.Net;

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SaludoController : ControllerBase
    {
        private readonly ISaludoBusiness business;

        public SaludoController(ISaludoBusiness business)
        {
            this.business = business;
        }

        /// <summary>
        /// Operación para obtener el saludo segun el idioma y la accion o tipo de saludo, nombre, despedida.
        /// </summary>
        /// <response code="200">Operación realizada con éxito.</response>
        /// <response code="401">No existen permisos para utilizar el servicio.</response>
        /// <response code="404">No existen datos para la consulta realizada.</response>
        /// <response code="500">Error inesperado.</response>
        [HttpPost]
        [ProducesResponseType(typeof(ResponseGetSaludo), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseGetSaludo), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ResponseGetSaludo), (int)HttpStatusCode.InternalServerError)]
        public IActionResult ObtenerSaludoIdioma([FromBody] RequestGetSaludo request)
        {
            ResponseGetSaludo respuesta = this.business.GetSaludo(request);

            return new OkObjectResult(respuesta);
        }
    }
}