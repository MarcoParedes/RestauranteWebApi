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
        public TipoPlatoResponse ObtenerTipoPlato()
        {
            using (var context = new RestauranteEntities())
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
