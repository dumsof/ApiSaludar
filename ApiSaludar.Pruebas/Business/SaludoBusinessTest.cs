namespace ApiSaludar.Pruebas.Business
{
    using ApiSaludar.Pruebas.DataRepositorieMock;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using Saludar.Business.Business;
    using Saludar.DataAccess.IRepositories;
    using System;

    [TestClass]
    public class SaludoBusinessTest
    {
        private Mock<ISaludoRepository> mockRepositorio;

        [TestInitialize]
        public void Initialize()
        {
            this.mockRepositorio = new Mock<ISaludoRepository>();
        }

        [TestMethod]
        public void ProbarQueElMetodoGetSaludoObtieneUnaRespuestaCorrecta()
        {
            this.mockRepositorio.Setup(x => x.GetSaludo(It.IsAny<Guid>(), It.IsAny<Guid>())).Returns(DataSaludoRepository.ObtenerGetSaludoRepositorio());

            var business = new SaludoBusiness(this.mockRepositorio.Object);

            var result = business.GetSaludo(DataSaludoRepository.GetRequestGetSaludo());

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProbarQueElMetodoGetSaludoObtieneUnaRespuestaCorrectaNull()
        {
            this.mockRepositorio.Setup(x => x.GetSaludo(It.IsAny<Guid>(), It.IsAny<Guid>())).Returns(DataSaludoRepository.ObtenerGetSaludoRepositorioNull());

            var business = new SaludoBusiness(this.mockRepositorio.Object);

            var result = business.GetSaludo(DataSaludoRepository.GetRequestGetSaludo());

            Assert.IsFalse(result.EstadoTransaccion);
        }
    }
}