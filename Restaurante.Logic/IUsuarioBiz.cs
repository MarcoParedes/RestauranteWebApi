using Restaurante.Entities;
using System;
using System.Collections.Generic;

namespace Restaurante.Logic
{
    public interface IUsuarioBiz
    {
        UsuarioResponse RegistrarUsuario(UsuarioRequest request);
        bool Ingresar(UsuarioRequest request);
    }
}
