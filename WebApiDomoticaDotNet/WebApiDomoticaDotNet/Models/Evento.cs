using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDomoticaDotNet.Models
{
    public class Evento
    {
        public int IdDispositivo { get; set; }

        public string Mensagem { get; set; }

        public DateTime Data   { get; set; }
    }
}