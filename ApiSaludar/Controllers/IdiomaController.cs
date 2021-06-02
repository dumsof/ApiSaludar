namespace ApiSaludar.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Saludar.Business.IBusiness;
    using Saludar.Business.ModelsView;
    using System.Net;

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IdiomaController : ControllerBase
    {
        private readonly IIdiomaBusiness business;

        public IdiomaController(IIdiomaBusiness business)
        {
            this.business = business;
        }

        /// <summary>
        /// Operación para obtener todos los idiomas registrados en el sistema.
        /// </summary>
        /// <response code="200">Operación realizada con éxito.</response>
        /// <response code="401">No existen permisos para utilizar el servicio.</response>
        /// <response code="404">No existen datos para la consulta realizada.</response>
        /// <response code="500">Error inesperado.</response>
        [HttpGet]
        [ProducesResponseType(typeof(ResponseGetAllIdioma), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ResponseGetAllIdioma), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ResponseGetAllIdioma), (int)HttpStatusCode.InternalServerError)]
        public IActionResult ObtenerTodosIdioma()
        {
            ResponseGetAllIdioma respuesta = this.business.GetAllIdiomas();

            return new OkObjectResult(respuesta);
        }
    }
}