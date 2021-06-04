namespace ApiSaludar.Pruebas.Business
{
    using ApiSaludar.Pruebas.DataRepositorieMock;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using Saludar.Business.Business;
    using Saludar.DataAccess.IRepositories;

    [TestClass]
    public class AccionBotonBusinessTest
    {
        private Mock<IAccionBotonRepository> mockRepositorio;

        [TestInitialize]
        public void Initialize()
        {
            this.mockRepositorio = new Mock<IAccionBotonRepository>();
        }

        [TestMethod]
        public void ProbarQueElMetodoGetAllAcionesBotonObtieneUnaRespuestaCorrecta()
        {
            this.mockRepositorio.Setup(x => x.GetAllAccionesBoton()).Returns(DataAccionBotonRepository.ObtenerGetAllAccionesBoton());

            var business = new AccionBotonBusiness(this.mockRepositorio.Object);

            var result = business.GetAllAccionesBoton();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProbarElMetodoGetAllAcionesBotonObtieneUnaRespuestaNull()
        {
            this.mockRepositorio.Setup(x => x.GetAllAccionesBoton()).Returns(DataAccionBotonRepository.ObtenerGetAllAccionesBotonNull());

            var business = new AccionBotonBusiness(this.mockRepositorio.Object);

            var result = business.GetAllAccionesBoton();

            Assert.IsFalse(result.EstadoTransaccion);
        }
    }
}