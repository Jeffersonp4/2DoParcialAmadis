using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Parcial.Models.Request
{
    public class Robo_Request
    {
        public int Id { get; set; }
        public long Cedula { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string QueRobaron { get; set; }
        public long ValorDollar { get; set; }
        public string DondeOcurrio { get; set; }
        public float Latitud { get; set; }
        public float Logintud { get; set; }
    }
}
