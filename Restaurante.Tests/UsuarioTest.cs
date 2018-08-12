using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restaurante.Data;
using Restaurante.Business;
using System.Data.Entity;
using Moq;
using System.Linq;
using Restaurante.Entities;

namespace Restaurante.Tests
{

    [TestClass]
    public class UsuarioTest
    {
        private Mock<IContextDbRestaurante> _contextMock;
        private UsuarioBiz _biz;

        [TestInitialize]
        public void Init()
        {
            _contextMock = new Mock<IContextDbRestaurante>();
            _biz = new UsuarioBiz(_contextMock.Object);
        }

        [TestMethod]
        public void IngresarTest()
        {
            var data = new List<Usuario>()
            {
                new Usuario { Correo = "marcop_93_04@hotmail.com", Clave = "sOnLaZjqkhZs2fMsS8eupA==" }
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Usuario>>();
            mockSet.As<IQueryable<Usuario>>().Setup(x => x.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Usuario>>().Setup(x => x.Expression).Returns(data.Expression);

            _contextMock.SetupGet(x => x.Usuarios).Returns(mockSet.Object);

            var request = new UsuarioRequest() {clave = "123", correo = "marcop_93_04@hotmail.com" };

            var response = _biz.Ingresar(request);

            Assert.IsTrue(response);
            _contextMock.VerifyAll();

        }
    }
}
