using Restaurante.Business;
using Restaurante.Entities;
using Restaurante.Logic;
using Restaurante.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Restaurante.WebApi.Controllers
{
    public class UsuarioController : ApiController
    {
        private IUsuarioBiz _usarioBiz;

        public UsuarioController()
        {
            _usarioBiz = new UsuarioBiz();
        }

        public UsuarioController(IUsuarioBiz biz)
        {
            _usarioBiz = biz;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/User/SignIn")]
        public ResponseMessage<UsuarioResponse> SignIn([FromBody] UsuarioRequest oUsuario)
        {
            try
            {
                var response = _usarioBiz.RegistrarUsuario(oUsuario);
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
        public ResponseMessage<string> LogIn([FromBody] UsuarioRequest request)
        {
            try
            {
                var result = _usarioBiz.Ingresar(request);
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
