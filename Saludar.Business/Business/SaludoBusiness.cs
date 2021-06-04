namespace Saludar.Business.Business
{
    using Saludar.Business.IBusiness;
    using Saludar.Business.ModelsView.Saludo;
    using Saludar.DataAccess.IRepositories;
    using Saludar.EntitiesDto.Mensaje;

    public class SaludoBusiness : ISaludoBusiness
    {
        private readonly ISaludoRepository repository;

        public SaludoBusiness(ISaludoRepository repository)
        {
            this.repository = repository;
        }

        public ResponseGetSaludo GetSaludo(RequestGetSaludo request)
        {
            var saludo = this.repository.GetSaludo(request.IdIdioma, request.IdAccion);

            if (saludo == null)
            {
                return new ResponseGetSaludo
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

            return new ResponseGetSaludo
            {
                EstadoTransaccion = true,
                Saludo = string.Format(saludo.DescripcionSaludo, request.Nombre)
            };
        }
    }
}