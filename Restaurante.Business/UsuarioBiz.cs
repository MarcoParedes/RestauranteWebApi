using Restaurante.Data;
using Restaurante.Entities;
using Restaurante.Logic;
using System;
using System.Linq;

namespace Restaurante.Business
{
    public class UsuarioBiz : IUsuarioBiz
    {
        private readonly IContextDbRestaurante _context;

        public UsuarioBiz()
        {
            _context = new RestauranteEntities();
        }

        public UsuarioBiz(IContextDbRestaurante ctx)
        {
            _context = ctx;
        }

        public UsuarioResponse RegistrarUsuario(UsuarioRequest request)
        {
            UsuarioResponse response = null;

            Usuario usuario = new Usuario();
            usuario.NombreCompleto = request.nombreCompleto;
            usuario.Edad = request.edad;
            usuario.Correo = request.correo;
            var password = AES.GetInstance().Encrypt(request.clave);
            usuario.Clave = password;

            var exists = _context.Usuarios.Any(x => x.Correo == usuario.Correo);
            if (!exists)
            {
                _context.Usuarios.Add(usuario);
                int result = _context.SaveChanges();

                response = new UsuarioResponse()
                {
                    correo = usuario.Correo,
                    nombreCompleto = usuario.NombreCompleto
                };

                response = result == 1 ? response : null;
            }
            return response;
        }

        public bool Ingresar(UsuarioRequest request)
        {
            var password = AES.GetInstance().Encrypt(request.clave);
            var data = _context.Usuarios.SingleOrDefault(x => x.Correo == request.correo);
            bool exists = _context.Usuarios.Any(x => x.Correo == request.correo && x.Clave == password);
            return exists;
        }

    }
}
