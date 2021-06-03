namespace Saludar.Business.IBusiness
{
    using Saludar.Business.ModelsView.Saludo;
    using Saludar.EntitiesDto;

    public interface ISaludoBusiness
    {
        ResponseGetSaludo GetSaludo(RequestGetSaludo request);
    }
}