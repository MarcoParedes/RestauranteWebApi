using Restaurante.Business;
using Restaurante.Entities;
using Restaurante.Logic;
using Restaurante.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;

namespace Restaurante.WebApi.Controllers
{
    [RoutePrefix("api/v1/Plato")]
    public class PlatoController : ApiController
    {
        protected readonly IPlatosBiz _IPlatoBiz;
        public PlatoController(IPlatosBiz platoBiz)
        {
            _IPlatoBiz = platoBiz;
        }

        public PlatoController()
        {
            _IPlatoBiz = new PlatosBiz();
        }

        // GET: api/Plato
        //[Route("GetPlatos")]
        [HttpGet]
        [Route("{idTipoPlato}")]
        public ResponseMessage<ObtenerPlatosResponse> GetPlatos(int idTipoPlato)
        {
            //var data = Proxies.ProxyRestauranteInt.Plato.ObtenerPlatoPorTipo(idTipoPlato);
            var data = _IPlatoBiz.ObtenerPlatoPorTipo(idTipoPlato);
            return ReturnData<ObtenerPlatosResponse>.ReturnResponse(data);
        }

        [HttpGet]
        [Route("GetDetallePlato/{idPlato}")]
        //[Produces]
        public ResponseMessage<ObtenerDetallePlatoResponse> GetDetallePlato(int idPlato)
        {
            ObtenerDetallePlatoRequest request = new ObtenerDetallePlatoRequest() { idPlato = idPlato };
            //var data = Proxies.ProxyRestauranteInt.Plato.ObtenerDetallePlato(request);
            var data = _IPlatoBiz.ObtenerDetallePlato(request);
            return ReturnData<ObtenerDetallePlatoResponse>.ReturnResponse(data);
        }

        // GET: api/Plato/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Plato
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Plato/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Plato/5
        public void Delete(int id)
        {
        }
    }
}
