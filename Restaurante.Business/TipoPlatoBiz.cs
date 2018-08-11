using Restaurante.Data;
using Restaurante.Entities;
using Restaurante.Entities.Models;
using Restaurante.Logic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurante.Business
{
    public class TipoPlatoBiz : ITipoPlatoBiz
    {
        private IContextDbRestaurante _context;

        public TipoPlatoBiz() { }

        public TipoPlatoBiz(IContextDbRestaurante ctx)
        {
            _context = ctx;
        }

        private IContextDbRestaurante GetContext()
        {
            return _context ?? new RestauranteEntities();
        }

        public TipoPlatoResponse ObtenerTipoPlato()
        {
            using (var context = GetContext())
            {
                var query = context.TipoPlatoes
                                .Select(x => new
                                {
                                    x.Id,
                                    x.Imagen,
                                    x.Estado,
                                    x.Descripcion
                                });

                var response = new TipoPlatoResponse();
                response.TipoPlatoList = query
                    .Select(x => new TipoPlatoModel
                    {
                        id = x.Id,
                        descripcion = x.Descripcion,
                        imagen = x.Imagen,
                        estado = x.Estado ?? default(bool)
                    }).ToList();
                return response;
            }
        }

    }
}
