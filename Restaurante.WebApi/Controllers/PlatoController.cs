using Restaurante.Business;
using Restaurante.Entities;
using Restaurante.Logic;
using Restaurante.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

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
        [HttpGet]
        [Route("{idTipoPlato}")]
        public ResponseMessage<ObtenerPlatosResponse> GetPlatos(int idTipoPlato)
        {
            var data = _IPlatoBiz.ObtenerPlatoPorTipo(idTipoPlato);
            return ReturnData<ObtenerPlatosResponse>.ReturnResponse(data);
        }

        [HttpGet]
        [Route("GetDetallePlato/{idPlato}")]
        public ResponseMessage<ObtenerDetallePlatoResponse> GetDetallePlato(int idPlato)
        {
            ObtenerDetallePlatoRequest request = new ObtenerDetallePlatoRequest() { idPlato = idPlato };
            var data = _IPlatoBiz.ObtenerDetallePlato(request);
            return ReturnData<ObtenerDetallePlatoResponse>.ReturnResponse(data);
        }

    }
}
