using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Restaurante.Business;
using Restaurante.Data;
using Restaurante.Entities;

namespace Restaurante.Tests
{
    [TestClass]
    public class PlatosBizTest
    {
        private Mock<IContextDbRestaurante> mockContext;
        private PlatosBiz _mockBiz;

        [TestInitialize]
        public void Init()
        {
            mockContext = new Mock<IContextDbRestaurante>();
            _mockBiz = new PlatosBiz(mockContext.Object);
        }

        [TestMethod]
        public void ObtenerPlatoPorTipoTest()
        {
            //Arange
            var idTipoPlato = 3;

            var data = new List<Plato>()
            {
                new Plato {
                    Id = 1, Nombres = "Anticucho", Descripcion = "anticuchos de corazón", Imagen = "imagen", Precio = 50, Etiqueta = "nuevo", IdTipo = 3, Comentarios = null, Destacado = false, Favoritos = null, TipoPlato = null},
                new Plato { Id = 2, Nombres = "Pollo a la brasa", Descripcion = "con papas fritas", Imagen = "imagen 2", Precio = 80, Etiqueta = "", IdTipo = 3, Comentarios = null, Destacado = false, Favoritos = null, TipoPlato = null }
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Plato>>();
            mockSet.As<IQueryable<Plato>>().Setup(x => x.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Plato>>().Setup(x => x.Expression).Returns(data.Expression);
            //mockSet.As<IQueryable<Plato>>().Setup(x => x.ElementType).Returns(data.ElementType);
            //mockSet.As<IQueryable<Plato>>().Setup(x => x.GetEnumerator()).Returns(data.GetEnumerator());
            mockContext.SetupGet(x => x.Platos).Returns(mockSet.Object);

            //Actions
            var response = _mockBiz.ObtenerPlatoPorTipo(idTipoPlato);

            //Asserts
            Assert.IsNotNull(response);
            Assert.AreEqual(2, response.platosList.Count);
            Assert.AreEqual("Anticucho", response.platosList[0].nombre);
            mockSet.VerifyAll();
        }

        [TestMethod]
        public void ObtenerDetallePlatoTest()
        {
            var request = new ObtenerDetallePlatoRequest() { idPlato = 1 };

            var data = new List<Plato>() {
                new Plato
                {
                    Id = 1,
                    Nombres = "Anticucho",
                    Descripcion = "anticuchos de corazón",
                    Imagen = "imagen",
                    Precio = 50,
                    Etiqueta = "nuevo",
                    IdTipo = 3,
                    Destacado = false,
                    Favoritos = null,
                    TipoPlato = null
                }
            }.AsQueryable();

            var Comentarios = new List<Comentario> {
                    new Comentario {
                        Id = 1,
                        Fecha = DateTime.Now,
                        Comentario1 = "good dish!",
                        IdPlato = 1,
                        Puntaje = 5,
                        IdUsuario = 6
                    },
                    new Comentario {
                        Id = 2,
                        Fecha = DateTime.Now,
                        Comentario1 = "muy rico!",
                        IdPlato = 1,
                        Puntaje = 4,
                        IdUsuario = 8
                    }
                }.AsQueryable();

            var usuario = new List<Usuario>
            {
                new Usuario { Id = 6,
                NombreCompleto = "Marco Paredes",
                Correo = "marcop_93_04@hotmail.com" },
                new Usuario { Id = 8,
                NombreCompleto = "Micaela",
                Correo = "mica.12@hotmail.com" }
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Plato>>();
            mockSet.As<IQueryable<Plato>>().Setup(x => x.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Plato>>().Setup(x => x.Expression).Returns(data.Expression);
            mockContext.Setup(x => x.Platos).Returns(mockSet.Object);

            var mockSetComentarios = new Mock<DbSet<Comentario>>();
            mockSetComentarios.As<IQueryable<Comentario>>().Setup(x => x.Provider).Returns(Comentarios.Provider);
            mockSetComentarios.As<IQueryable<Comentario>>().Setup(x => x.Expression).Returns(Comentarios.Expression);
            mockContext.SetupGet(x => x.Comentarios).Returns(mockSetComentarios.Object);

            var mockSetUsuario = new Mock<DbSet<Usuario>>();
            mockSetUsuario.As<IQueryable<Comentario>>().Setup(x => x.Provider).Returns(usuario.Provider);
            mockSetUsuario.As<IQueryable<Comentario>>().Setup(x => x.Expression).Returns(usuario.Expression);
            mockContext.SetupGet(x => x.Usuarios).Returns(mockSetUsuario.Object);

            var response = _mockBiz.ObtenerDetallePlato(request);

            Assert.IsNotNull(response);
            Assert.AreEqual(1, response.detallePlato.plato.id);
            Assert.AreEqual(2, response.detallePlato.plato.comentarios.Count);
            mockContext.VerifyAll();

        }

    }
}
