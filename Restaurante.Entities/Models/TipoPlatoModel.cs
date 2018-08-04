using System;

namespace Restaurante.Entities.Models
{
    public class TipoPlatoModel
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public string imagen { get; set; }
        public bool estado { get; set; }

        public TipoPlatoModel()
        {
            this.id = 0;
            this.descripcion = string.Empty;
            this.imagen = string.Empty;
            this.estado = false;
        }

        public TipoPlatoModel(int id, string descripcion, string imagen, bool estado)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.estado = estado;
        }

    }
}
