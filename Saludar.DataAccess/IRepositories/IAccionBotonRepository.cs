namespace Saludar.DataAccess.IRepositories
{
    using Saludar.EntitiesDto;
    using System.Collections.Generic;

    public interface IAccionBotonRepository
    {
        IEnumerable<AccionBotonEntityDto> GetAllAccionesBoton();
    }
}