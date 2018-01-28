using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiDomoticaDotNet.Models;

namespace WebApiDomoticaDotNet.Repositorio
{
    public class DispositivoRepositorio : IDispotivo
    {
        private List<Dispositivo> Dipositivos = new List<Dispositivo>();

        private List<Evento> Eventos = new List<Evento>();

        public DispositivoRepositorio()
        {
            Add(new Dispositivo { Nome = "Lampada", Pino = "Não Referenciado", Estado = false  });
            Add(new Dispositivo { Nome = "Ventiladores", Pino = "Não Referenciado", Estado = false });
            Add(new Dispositivo { Nome = "Ar Condicionaro", Pino = "Não Referenciado", Estado = false });
            Add(new Dispositivo { Nome = "Televisor", Pino = "Não Referenciado", Estado = false });

        }

        public Dispositivo Add(Dispositivo novo)
        {
            if (novo == null)
            {
                throw new ArgumentNullException("Erro ao Adicionar Novo Dipositivo");
            }
           
            Dipositivos.Add(novo);
            return novo;
        }

        public Evento LigarDipositivo(int pino)
        {
            Evento novoEvento = new Evento();

            novoEvento.IdDispositivo = 1;
            novoEvento.Data = DateTime.Now;
            novoEvento.Mensagem = "Dispositivo Foi Ligado com Êxito";
            Eventos.Add(novoEvento);
            return novoEvento;
        }

        public Evento DesligarDispositivo(int pino)
        {
            Evento novoEvento = new Evento();

            novoEvento.IdDispositivo = 1;
            novoEvento.Data = DateTime.Now;
            novoEvento.Mensagem = "Dispositivo Foi Desligado com Êxito";
            Eventos.Add(novoEvento);

            return novoEvento;
        }

        public IEnumerable<Dispositivo> ObterDispositivoAll()
        {
              return Dipositivos;
        }
    }
}