namespace Saludar.Business.Business
{
    using Saludar.Business.IBusiness;
    using Saludar.Business.ModelsView.Saludo;
    using Saludar.DataAccess.IRepositories;

    public class SaludoBusiness : ISaludoBusiness
    {
        private readonly ISaludoRepository repository;

        public SaludoBusiness(ISaludoRepository repository)
        {
            this.repository = repository;
        }

        public ResponseGetSaludo GetSaludo(RequestGetSaludo request)
        {
            var saludo = this.repository.GetSaludo(request.IdIdioma);

            return new ResponseGetSaludo
            {
                EstadoTransaccion = true,
                Saludo = string.Format(saludo.DescripcionSaludo, request.Nombre)
            };
        }
    }
}