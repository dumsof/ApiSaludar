namespace ApiSaludar.Pruebas.Business
{
    using ApiSaludar.Pruebas.DataRepositorieMock;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using Saludar.Business.Business;
    using Saludar.DataAccess.IRepositories;

    [TestClass]
    public class IdiomaBusinessTest
    {
        private Mock<IIdiomaRepository> mockRepositorio;

        [TestInitialize]
        public void Initialize()
        {
            this.mockRepositorio = new Mock<IIdiomaRepository>();
        }

        [TestMethod]
        public void ProbarQueElMetodoGetAllAcionesBotonObtieneUnaRespuestaCorrecta()
        {
            this.mockRepositorio.Setup(x => x.GetAllIdiomas()).Returns(DataIdiomaBusiness.ObtenerGetAllIdiomasRespositorio());

            var business = new IdiomaBusiness(this.mockRepositorio.Object);

            var result = business.GetAllIdiomas();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProbarElMetodoGetAllAcionesBotonObtieneUnaRespuestaNull()
        {
            this.mockRepositorio.Setup(x => x.GetAllIdiomas()).Returns(DataIdiomaBusiness.ObtenerGetAllIdiomasRespositorioNull());

            var business = new IdiomaBusiness(this.mockRepositorio.Object);

            var result = business.GetAllIdiomas();

            Assert.IsFalse(result.EstadoTransaccion);
        }
    }
}