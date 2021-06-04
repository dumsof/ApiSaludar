namespace ApiSaludar.Pruebas.DataRepositorieMock
{
    using Saludar.Business.ModelsView.AccionBoton;
    using Saludar.EntitiesDto;
    using System;
    using System.Collections.Generic;

    public class DataAccionBotonRepository
    {
        internal static ResponseGetAllAccionesBoton ObtenerResponseGetAllAccionesBoton()
        {
            return new ResponseGetAllAccionesBoton
            {
                AcionesBotones = ObtenerGetAllAccionesBoton(),
                EstadoTransaccion = true
            };
        }

        internal static List<AccionBotonEntityDto> ObtenerGetAllAccionesBoton()
        {
            return new List<AccionBotonEntityDto>()
                {
                    new AccionBotonEntityDto { IdAccion = Guid.Parse("ca8e5efe-8186-43e4-b656-85723d3c6af0"), Ordenado = 1, DescripcionAccion = "Saludar" },
                    new AccionBotonEntityDto { IdAccion = Guid.Parse("2f3bdacd-887e-4fab-8530-8214379a8074"), Ordenado = 2, DescripcionAccion = "Nombre" },
                    new AccionBotonEntityDto { IdAccion = Guid.Parse("efebb1df-723e-4f5e-8b26-ec23ef0fa59b"), Ordenado = 3, DescripcionAccion = "Despedir" }
                };
        }

        internal static List<AccionBotonEntityDto> ObtenerGetAllAccionesBotonNull()
        {
            return null;
        }
    }
}