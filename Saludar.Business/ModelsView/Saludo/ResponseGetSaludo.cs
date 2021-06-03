namespace Saludar.Business.ModelsView.Saludo
{
    using Saludar.EntitiesDto;
    using Saludar.EntitiesDto.Mensaje;

    public class ResponseGetSaludo : Respuesta
    {
        public string Saludo { get; set; }
    }
}