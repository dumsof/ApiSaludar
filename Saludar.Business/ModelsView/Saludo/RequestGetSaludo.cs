namespace Saludar.Business.ModelsView.Saludo
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class RequestGetSaludo
    {
        [Required(ErrorMessage = "El campo {0} es requerido. por favor verifique.")]
        public Guid IdIdioma { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido. por favor verifique.")]
        public Guid IdAccion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido. por favor verifique.")]
        public string Nombre { get; set; }
    }
}