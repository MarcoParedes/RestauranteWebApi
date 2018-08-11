using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Restaurante.Business;
using Restaurante.Data;

namespace Restaurante.Tests
{
    [TestClass]
    public class TipoPlatoBizTest
    {
        private Mock<IContextDbRestaurante> mockContext;
        private TipoPlatoBiz _mockBiz;

        [TestInitialize]
        public void Init()
        {
            mockContext = new Mock<IContextDbRestaurante>();
            _mockBiz = new TipoPlatoBiz(mockContext.Object);
        }

        [TestMethod]
        public void ObtenerTipoPlatoTest()
        {
            var data = new List<TipoPlato>()
            {
                new TipoPlato { Id = 1, Descripcion = "postres", Estado = true, Imagen = "img1", Platos = null },
                new TipoPlato { Id = 2, Descripcion = "ensaladas", Estado = true, Imagen = "img2", Platos = null },
                new TipoPlato { Id = 3, Descripcion = "a la brasa", Estado = true, Imagen = "img3", Platos = null }
            }.AsQueryable();

            var mockSet = new Mock<DbSet<TipoPlato>>();
            mockSet.As<IQueryable<TipoPlato>>().Setup(x => x.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<TipoPlato>>().Setup(x => x.Expression).Returns(data.Expression);

            mockContext.SetupGet(x => x.TipoPlatoes).Returns(mockSet.Object);

            var response = _mockBiz.ObtenerTipoPlato();

            Assert.IsNotNull(response);
            Assert.AreEqual(3, response.TipoPlatoList.Count);
            mockContext.VerifyAll();

        }
    }
}
