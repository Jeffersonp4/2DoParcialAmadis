using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudParcial.Data
{
    public class Modelo_De_clase_como_LaAPi
    {
        public int Id { get; set; }
        public string cedula { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Que_Se_Robaron { get; set; }
        public int Valor_En { get; set; }
        public string Donde_ocurrio { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }
    }
}
