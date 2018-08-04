using System;
using System.Collections.Generic;

namespace Restaurante.Entities.Models
{
    public class DetallePlatoModel
    {
        public PlatoModel plato { get; set; }
        //public List<ComentarioModel> comentarios { get; set; }

        public DetallePlatoModel() {
            this.plato = new PlatoModel();
            //this.comentarios = new List<ComentarioModel>();
        }
    }
}
