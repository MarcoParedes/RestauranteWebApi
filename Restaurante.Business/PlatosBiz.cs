using Restaurante.Data;
using Restaurante.Entities;
using Restaurante.Entities.Models;
using Restaurante.Logic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurante.Business
{
    public class PlatosBiz : IPlatosBiz
    {
        protected readonly IContextDbRestaurante _context;

        public PlatosBiz()
        {
        }

        public PlatosBiz(IContextDbRestaurante ctx)
        {
            _context = ctx;
        }

        private IContextDbRestaurante GetContext()
        {
            return _context ?? new RestauranteEntities();
        }

        public ObtenerPlatosResponse ObtenerPlatoPorTipo(int idTipoPlato)
        {
            using (var context = GetContext())
            {
                var platos = context.Platos
                        .Where(x => x.IdTipo == idTipoPlato)
                        .Select(x => new
                        {
                            x.Id,
                            x.Nombres,
                            x.Descripcion,
                            x.Imagen,
                            x.Precio,
                            x.Etiqueta
                        }).ToList();

                var response = new ObtenerPlatosResponse();
                response.platosList = platos
                    .Select(x => new PlatoModel
                    {
                        id = x.Id,
                        nombre = x.Nombres,
                        descripcion = x.Descripcion,
                        precio = x.Precio,
                        imagen = x.Imagen
                    }).ToList();

                return response;
            }
        }

        public ObtenerDetallePlatoResponse ObtenerDetallePlato(ObtenerDetallePlatoRequest request)
        {
            using (var context = GetContext())
            {
                var plato = context.Platos
                    .Where(x => x.Id == request.idPlato)
                    .Select(x => new
                    {
                        x.Id,
                        x.Nombres,
                        x.Descripcion,
                        x.Imagen,
                        x.Precio,
                        x.Etiqueta,
                        comentarios = context.Comentarios
                            .Join(context.Usuarios,
                            comment => comment.IdUsuario,
                            user => user.Id,
                            (comment, user) => new
                            {
                                comment.Id,
                                comment.IdPlato,
                                comment.Puntaje,
                                comentario = comment.Comentario1,
                                comment.Fecha,
                                usuario = new
                                {
                                    IdUsuario = user.Id,
                                    user.NombreCompleto,
                                    user.Correo
                                }
                            })
                            .Where(d => d.IdPlato == request.idPlato).ToList()
                    }).SingleOrDefault();

                if (plato != null)
                {
                    var response = new ObtenerDetallePlatoResponse()
                    {
                        detallePlato = {
                            plato = {
                                id = plato.Id,
                                nombre = plato.Nombres,
                                descripcion = plato.Descripcion,
                                imagen = plato.Imagen,
                                precio = plato.Precio,
                                comentarios = plato.comentarios.Select(x => new ComentarioModel
                                {
                                    idComentario = x.Id,
                                    idPlato = x.IdPlato,
                                    usuario = new UsuarioModel
                                    {
                                        id = x.usuario.IdUsuario,
                                        correo = x.usuario.Correo,
                                        nombreCompleto = x.usuario.NombreCompleto
                                    },
                                    comentario = x.comentario,
                                    fecha = x.Fecha,
                                    puntaje = x.Puntaje
                                }).ToList()
                            }
                        }
                    };
                    return response;
                }
                return null;
            }

        }


    }
}
