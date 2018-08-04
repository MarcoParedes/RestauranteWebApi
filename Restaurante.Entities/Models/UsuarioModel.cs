using System;
using System.Runtime.Serialization;

namespace Restaurante.Entities.Models
{
    public class UsuarioModel
    {

        public int id { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }
        public int edad { get; set; }
        public string nombreCompleto { get; set; }

        public UsuarioModel()
        {
            this.id = 0;
            this.correo = string.Empty;
            this.clave = string.Empty;
            this.edad = 0;
            this.nombreCompleto = string.Empty;
        }

        public UsuarioModel(int id, string correo, string clave, int edad, string nombreCompleto)
        {
            this.id = id;
            this.correo = correo;
            this.clave = clave;
            this.edad = edad;
            this.nombreCompleto = nombreCompleto;
        }

    }
}
