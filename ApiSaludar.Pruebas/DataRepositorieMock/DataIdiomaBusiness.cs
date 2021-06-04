namespace ApiSaludar.Pruebas.DataRepositorieMock
{
    using Saludar.EntitiesDto;
    using System;
    using System.Collections.Generic;

    public class DataIdiomaBusiness
    {
        internal static List<IdiomaEntityDto> ObtenerGetAllIdiomasRespositorio()
        {
            return new List<IdiomaEntityDto>()
                {
                    new IdiomaEntityDto { IdIdioma = Guid.Parse("6534e740-5a53-4f53-8ef1-a32994e04ed9"), Ordenado = 1, DescripcionIdioma = "Ingles" },
                    new IdiomaEntityDto { IdIdioma = Guid.Parse("7f70d53b-b924-4d57-a916-a49db2454cf6"), Ordenado = 2, DescripcionIdioma = "Español" }
                };
        }

        internal static List<IdiomaEntityDto> ObtenerGetAllIdiomasRespositorioNull()
        {
            return null;
        }
    }
}