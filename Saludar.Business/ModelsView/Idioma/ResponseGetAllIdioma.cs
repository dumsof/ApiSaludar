namespace Saludar.Business.ModelsView.Idioma
{
    using Saludar.EntitiesDto;
    using Saludar.EntitiesDto.Mensaje;
    using System.Collections.Generic;

    public class ResponseGetAllIdioma : Respuesta
    {
        public IEnumerable<IdiomaEntityDto> Idiomas { get; set; }
    }
}