using Restaurante.Business;
using Restaurante.Logic;
using System;

namespace Restaurante.WebApi.Proxies
{
    public class ProxyRestauranteInt
    {
        //private static ITipoPlatoBiz ITipoReclamoBiz;
        //public static ITipoPlatoBiz TipoReclamo
        //{
        //    get
        //    {
        //        ITipoReclamoBiz = new TipoPlatoBiz();
        //        return ITipoReclamoBiz;
        //    }
        //}

        private static IUsuarioBiz IUsuarioBiz;
        public static IUsuarioBiz Usuario
        {
            get
            {
                IUsuarioBiz = new UsuarioBiz();
                return IUsuarioBiz;
            }
        }

        private static IPlatosBiz IPlatoBiz;
        public static IPlatosBiz Plato
        {
            get
            {
                IPlatoBiz = new PlatosBiz();
                return IPlatoBiz;
            }
        }

    }
}