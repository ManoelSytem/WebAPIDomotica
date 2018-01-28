using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDomoticaDotNet.Models;
using WebApiDomoticaDotNet.Repositorio;

namespace WebApiDomoticaDotNet.Controllers
{
    public class DispositivoController : ApiController
    {
        static readonly DispositivoRepositorio repositorio = new DispositivoRepositorio();


        public IEnumerable<Dispositivo> GetAllProdutos()
        {
            return repositorio.ObterDispositivoAll();
        }

        [HttpPost]
        public Evento LigarDispositivo(int pino)
        {
            return repositorio.LigarDipositivo(pino);
        }

    }
}
