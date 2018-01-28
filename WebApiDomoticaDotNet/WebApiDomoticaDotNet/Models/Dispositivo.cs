using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace WebApiDomoticaDotNet.Models
{
    public class Dispositivo
    {
        public string Nome { get; set;}

        public string Pino { get; set; }

        public Boolean Estado { get; set; }

        public string Utilizador { get; set; }

    }
}