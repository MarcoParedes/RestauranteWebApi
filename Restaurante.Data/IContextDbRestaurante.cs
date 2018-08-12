using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Restaurante.Data
{
    public interface IContextDbRestaurante : IDisposable
    {
        DbSet<Comentario> Comentarios { get; set; }
        DbSet<Favorito> Favoritos { get; set; }
        DbSet<Feedback> Feedbacks { get; set; }
        DbSet<Lidere> Lideres { get; set; }
        DbSet<Locale> Locales { get; set; }
        DbSet<Plato> Platos { get; set; }
        DbSet<Reserva> Reservas { get; set; }
        DbSet<sysdiagram> sysdiagrams { get; set; }
        DbSet<TipoPlato> TipoPlatoes { get; set; }
        DbSet<Usuario> Usuarios { get; set; }
        DbSet<WebToken> WebTokens { get; set; }

        int SaveChanges();
    }
}
