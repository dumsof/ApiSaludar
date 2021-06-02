namespace Saludar.DataAccess.IRepositories
{
    using Saludar.EntitiesDto;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IIdiomaRepository
    {
        IEnumerable<IdiomaEntityDto> GetAllIdiomas();
    }
}