namespace Saludar.DataAccess
{
    using Microsoft.EntityFrameworkCore;
    using Saludar.EntitiesDto;


    public class SaludarDbContext : DbContext
    {
        public SaludarDbContext(DbContextOptions<SaludarDbContext> options)
           : base(options)
        {
        }

        public DbSet<IdiomaEntityDto> Idiomas { get; set; }

        public DbSet<AccionBotonEntityDto> Acciones { get; set; }

        public DbSet<SaludoEntityDto> Saludos { get; set; }        

    }
}