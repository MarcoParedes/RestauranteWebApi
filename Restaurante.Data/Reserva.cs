//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurante.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reserva
    {
        public int Id { get; set; }
        public Nullable<short> Invitados { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public Nullable<System.DateTime> FechaReserva { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<int> IdLocal { get; set; }
        public string Comentarios { get; set; }
    
        public virtual Locale Locale { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
