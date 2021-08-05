using System;
using System.Collections.Generic;

#nullable disable

namespace Api_Parcial.Models
{
    public partial class TablaRobo
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
