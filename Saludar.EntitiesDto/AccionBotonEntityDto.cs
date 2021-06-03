namespace Saludar.EntitiesDto
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class AccionBotonEntityDto
    {
        [Key]
        public Guid IdAccion { get; set; }

        public int Ordenado { get; set; }

        public string DescripcionAccion { get; set; }
    }
}