namespace Saludar.DataAccess.Repositories
{
    using Saludar.DataAccess.IRepositories;
    using Saludar.EntitiesDto;
    using System.Collections.Generic; 
    using System.Linq;

    public class IdiomaRepository : IIdiomaRepository
    {

        private readonly SaludarDbContext dbContext;

        public IdiomaRepository(SaludarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<IdiomaEntityDto> GetAllIdiomas()
        {
            var idioma = this.dbContext.Idiomas.ToList();
            return idioma;
        }
    }
}