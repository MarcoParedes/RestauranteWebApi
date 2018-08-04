using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Restaurante.Entities.Models
{
    public class PlatoModel
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal? precio { get; set; }
        //[JsonIgnore]
        public TipoPlatoModel tipoPlato { get; set; }
        public string imagen { get; set; }
        public List<ComentarioModel> comentarios { get; set; }
    }
}
