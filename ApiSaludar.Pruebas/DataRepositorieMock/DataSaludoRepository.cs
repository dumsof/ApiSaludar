namespace ApiSaludar.Pruebas.DataRepositorieMock
{
    using Saludar.Business.ModelsView.Saludo;
    using Saludar.EntitiesDto;
    using System;

    public class DataSaludoRepository
    {
        internal static ResponseGetSaludo ObtenerResponseGetSaludo()
        {
            return new ResponseGetSaludo
            {
                EstadoTransaccion = true,
                Saludo = "My nombre es {0}",
            };
        }

        internal static SaludoEntityDto ObtenerGetSaludoRepositorio()
        {
            return new SaludoEntityDto
            {
                DescripcionSaludo = "Mi nombre es {0}"
            };
        }

        internal static RequestGetSaludo GetRequestGetSaludo()
        {
            return new RequestGetSaludo
            {
                Nombre = "Darwin",
                IdAccion = Guid.NewGuid(),
                IdIdioma = Guid.NewGuid()
            };
        }

        internal static SaludoEntityDto ObtenerGetSaludoRepositorioNull()
        {
            return null;
        }
    }
}