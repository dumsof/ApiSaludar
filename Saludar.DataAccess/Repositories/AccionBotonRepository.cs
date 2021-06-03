namespace Saludar.DataAccess.Repositories
{
    using Saludar.DataAccess.IRepositories;
    using Saludar.EntitiesDto;
    using System.Collections.Generic;
    using System.Linq;

    public class AccionBotonRepository : IAccionBotonRepository
    {
        private readonly SaludarDbContext dbContext;

        public AccionBotonRepository(SaludarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<AccionBotonEntityDto> GetAllAccionesBoton()
        {
            var acciones = this.dbContext.Acciones.OrderBy(o=> o.Ordenado).ToList();
            return acciones;
        }
    }
}