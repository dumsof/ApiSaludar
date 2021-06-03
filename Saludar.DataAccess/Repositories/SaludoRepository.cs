﻿namespace Saludar.DataAccess.Repositories
{
    using Saludar.DataAccess.IRepositories;
    using Saludar.EntitiesDto;
    using System;
    using System.Linq;

    public class SaludoRepository : ISaludoRepository
    {
        private readonly SaludarDbContext dbContext;

        public SaludoRepository(SaludarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public SaludoEntityDto GetSaludo(Guid idIdioma)
        {
            var saludo = this.dbContext.Saludos.First(c => c.IdIdioma == idIdioma);
            return saludo;
        }
    }
}