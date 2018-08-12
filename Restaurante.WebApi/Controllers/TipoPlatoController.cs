using Restaurante.Business;
using Restaurante.Entities;
using Restaurante.Logic;
using Restaurante.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Restaurante.WebApi.Controllers
{
    [RoutePrefix("api/TipoPlato")]
    public class TipoPlatoController : ApiController
    {
        private ITipoPlatoBiz _bizTipoPlato;

        public TipoPlatoController()
        {
            _bizTipoPlato = new TipoPlatoBiz();
        }

        public TipoPlatoController(ITipoPlatoBiz biz)
        {
            _bizTipoPlato = biz;
        }

        // GET: api/TipoPlato/GetTipoPlato
        [HttpGet]
        [Route("GetTipoPlato")]
        public ResponseMessage<TipoPlatoResponse> Get()
        {
            var data = _bizTipoPlato.ObtenerTipoPlato();

            var response = new ResponseMessage<TipoPlatoResponse>
            {
                statusCode = 200,
                data = data,
                message = "ok"
            };

            return response;
        }

    }
}
