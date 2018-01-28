using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiDomoticaDotNet.Models;

namespace WebApiDomoticaDotNet.Repositorio
{
    public interface IDispotivo
    {
        IEnumerable<Dispositivo> ObterDispositivoAll();
        Dispositivo Add(Dispositivo novo);
        Evento LigarDipositivo(int pino);
        Evento DesligarDispositivo(int pino);

    }

}
