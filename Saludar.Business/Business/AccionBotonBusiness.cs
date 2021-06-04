namespace Saludar.Business.Business
{
    using Saludar.Business.IBusiness;
    using Saludar.Business.ModelsView.AccionBoton;
    using Saludar.DataAccess.IRepositories;
    using Saludar.EntitiesDto.Mensaje;

    public class AccionBotonBusiness : IAccionBotonBusiness
    {
        private readonly IAccionBotonRepository repository;

        public AccionBotonBusiness(IAccionBotonRepository repository)
        {
            this.repository = repository;
        }

        public ResponseGetAllAccionesBoton GetAllAccionesBoton()
        {
            var resultAllAccion = this.repository.GetAllAccionesBoton();

            if (resultAllAccion == null)
            {
                return new ResponseGetAllAccionesBoton
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

            return new ResponseGetAllAccionesBoton
            {
                EstadoTransaccion = true,
                AcionesBotones = resultAllAccion
            };
        }
    }
}