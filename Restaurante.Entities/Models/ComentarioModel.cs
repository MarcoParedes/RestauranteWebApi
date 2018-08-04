using System;

namespace Restaurante.Entities.Models
{
    public class ComentarioModel
    {
        public int idComentario { get; set; }
        public short? puntaje { get; set; }
        public string comentario { get; set; }
        public UsuarioModel usuario { get; set; }
        public DateTime? fecha { get; set; }
        public int? idPlato { get; set; }
    }
}
