using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace Proyecto_2.Models
{
    public class Calculo
    {
        public int Id { get; set; }
        public string Operacion { get; set; }
        public string Resultado { get; set; }
        public DateTime Fecha { get; set; }
    }
}