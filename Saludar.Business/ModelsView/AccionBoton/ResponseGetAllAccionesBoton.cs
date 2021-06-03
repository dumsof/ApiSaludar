using Saludar.EntitiesDto;
using Saludar.EntitiesDto.Mensaje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saludar.Business.ModelsView.AccionBoton
{
    public class ResponseGetAllAccionesBoton : Respuesta
    {
        public IEnumerable<AccionBotonEntityDto> AcionesBotones { get; set; }
    }
}
