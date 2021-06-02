namespace Saludar.Business.ModelsView
{
    using Saludar.EntitiesDto;
    using Saludar.EntitiesDto.Mensaje;
    using System.Collections.Generic;

    public class ResponseGetAllIdioma : Respuesta
    {
        public IEnumerable<IdiomaEntityDto> Idiomas { get; set; }
    }
}