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

        public TipoPlatoBiz()
        {
            _context = new RestauranteEntities();
        }

        public TipoPlatoBiz(IContextDbRestaurante ctx)
        {
            _context = ctx;
        }

        public TipoPlatoResponse ObtenerTipoPlato()
        {
            var query = _context.TipoPlatoes
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
