namespace Saludar.Business.ModelsView.Saludo
{
    using System;

    public class RequestGetSaludo
    {
        public Guid IdIdioma { get; set; }

        public Guid IdAccion { get; set; }

        public string Nombre { get; set; }
    }
}