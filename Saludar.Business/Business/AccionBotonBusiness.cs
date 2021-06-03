namespace Saludar.Business.Business
{
    using Saludar.Business.IBusiness;
    using Saludar.Business.ModelsView.AccionBoton;
    using Saludar.DataAccess.IRepositories;

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

            return new ResponseGetAllAccionesBoton
            {
                EstadoTransaccion = true,
                AcionesBotones = resultAllAccion
            };
        }
    }
}