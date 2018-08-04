using Restaurante.Data;
using Restaurante.Entities;
using Restaurante.Logic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurante.Business
{
    public class UsuarioBiz : IUsuarioBiz
    {
        public UsuarioResponse RegistrarUsuario(UsuarioRequest request)
        {
            UsuarioResponse response = null;

            Usuario usuario = new Usuario();
            usuario.NombreCompleto = request.nombreCompleto;
            usuario.Edad = request.edad;
            usuario.Correo = request.correo;
            var password = AES.GetInstance().Encrypt(request.clave);
            usuario.Clave = password;

            using (var context = new RestauranteEntities())
            {
                var exists = context.Usuarios.Any(x => x.Correo == usuario.Correo);
                if (!exists)
                {
                    context.Usuarios.Add(usuario);
                    int result = context.SaveChanges();

                    response = new UsuarioResponse()
                    {
                        correo = usuario.Correo,
                        nombreCompleto = usuario.NombreCompleto
                    };

                    response = result == 1 ? response : null;
                }
                return response;
            }
        }

        public bool Ingresar(UsuarioRequest request)
        {
            var password = AES.GetInstance().Encrypt(request.clave);
            using (var context = new RestauranteEntities())
            {
                var data = context.Usuarios.SingleOrDefault(x => x.Correo == request.correo);
                var clave = AES.GetInstance().Decrypt(data.Clave);
                bool exists = context.Usuarios.Any(x => x.Correo == request.correo && x.Clave == password);
                return exists;
            }
        }

    }
}
