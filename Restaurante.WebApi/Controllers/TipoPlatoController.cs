using Restaurante.Entities;
using Restaurante.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Restaurante.WebApi.Controllers
{
    [RoutePrefix("api/TipoPlato")]
    public class TipoPlatoController : ApiController
    {
        // GET: api/TipoPlato/GetTipoPlato
        [HttpGet]
        [Route("GetTipoPlato")]
        public ResponseMessage<TipoPlatoResponse> Get()
        {
            var data = Proxies.ProxyRestauranteInt.TipoReclamo.ObtenerTipoPlato();

            var response = new ResponseMessage<TipoPlatoResponse>
            {
                statusCode = 200,
                data = data,
                message = "ok"
            };

            return response;
        }

        // GET: api/TipoPlato/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TipoPlato
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TipoPlato/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TipoPlato/5
        public void Delete(int id)
        {
        }
    }
}
