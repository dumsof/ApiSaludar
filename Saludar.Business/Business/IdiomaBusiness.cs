namespace Saludar.Business.Business
{
    using Saludar.Business.IBusiness;
    using Saludar.Business.ModelsView.Idioma;
    using Saludar.DataAccess.IRepositories;
    using Saludar.EntitiesDto.Mensaje;

    public class IdiomaBusiness : IIdiomaBusiness
    {
        private readonly IIdiomaRepository repository;

        public IdiomaBusiness(IIdiomaRepository repository)
        {
            this.repository = repository;
        }

        public ResponseGetAllIdioma GetAllIdiomas()
        {
            var resultAllIdioma = this.repository.GetAllIdiomas();

            if (resultAllIdioma == null)
            {
                return new ResponseGetAllIdioma
                {
                    EstadoTransaccion = false,
                    Mensaje = new Mensaje
                    {
                        Identificador = -1,
                        Contenido = "No existe información",
                        Titulo = "No existen registros"
                    }
                };
            }

            return new ResponseGetAllIdioma
            {
                EstadoTransaccion = true,
                Idiomas = resultAllIdioma
            };
        }
    }
}