namespace Saludar.DataAccess.IRepositories
{
    using Saludar.EntitiesDto;
    using System;

    public interface ISaludoRepository
    {
        SaludoEntityDto GetSaludo(Guid idIdioma);
    }
}