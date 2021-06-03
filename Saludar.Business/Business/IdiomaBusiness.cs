namespace Saludar.Business.Business
{
    using Saludar.Business.IBusiness;
    using Saludar.Business.ModelsView.Idioma;
    using Saludar.DataAccess.IRepositories;

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

            return new ResponseGetAllIdioma
            {
                EstadoTransaccion = true,
                Idiomas = resultAllIdioma
            };
        }
    }
}