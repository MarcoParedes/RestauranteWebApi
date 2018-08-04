using Restaurante.Entities.Models;
using System;
using System.Collections.Generic;

namespace Restaurante.Entities
{
    public class ObtenerDetallePlatoResponse
    {
        public DetallePlatoModel detallePlato { get; set; }

        public ObtenerDetallePlatoResponse()
        {
            this.detallePlato = new DetallePlatoModel();
        }
    }
}
