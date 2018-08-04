using Restaurante.Entities;
using System;

namespace Restaurante.Logic
{
    public interface IPlatosBiz
    {
        ObtenerPlatosResponse ObtenerPlatoPorTipo(int idTipoPlato);
        ObtenerDetallePlatoResponse ObtenerDetallePlato(ObtenerDetallePlatoRequest request);
    }
}
