using System;

namespace Restaurante.Entities
{
    public class UsuarioRequest
    {
        public int id { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }
        public string nombreCompleto { get; set; }
        public string telefono { get; set; }
        public int edad { get; set; }
    }
}
