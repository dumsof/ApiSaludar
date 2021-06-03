namespace Saludar.EntitiesDto
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class SaludoEntityDto
    {
        [Key]
        public Guid IdSaludo { get; set; }

        public Guid IdIdioma { get; set; }

        public Guid IdAccion{ get; set; }

        public string DescripcionSaludo { get; set; }
    }
}