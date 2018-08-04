using Restaurante.Entities;
using Restaurante.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Restaurante.WebApi.Controllers
{
    public class UsuarioController : ApiController
    {
        [HttpPost]
        [AllowAnonymous]
        [Route("api/User/SignIn")]
        public ResponseMessage<UsuarioResponse> SignIn(UsuarioRequest oUsuario)
        {
            try
            {
                var response = Proxies.ProxyRestauranteInt.Usuario.RegistrarUsuario(oUsuario);
                string mensaje = response != null ?
                                            "Registrado correctamente." :
                                            "El usuario no fue registrado, intente de nuevo.";

                var res = new ResponseMessage<UsuarioResponse>();
                res.message = mensaje;
                res.statusCode = response != null ? 200 : 404;
                res.data = response;
                return res;
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/User/LogIn")]
        public ResponseMessage<string> LogIn(UsuarioRequest request)
        {
            try
            {
                var result = Proxies.ProxyRestauranteInt.Usuario.Ingresar(request);
                string mensaje = result ? "Datos correctos." : "Datos invalidos.";
                var res = new ResponseMessage<string>()
                {
                    message = mensaje,
                    statusCode = result ? 200 : 404,
                    data = "ok"
                };
                return res;
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

    }
}
