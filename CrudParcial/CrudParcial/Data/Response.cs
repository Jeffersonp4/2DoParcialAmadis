using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudParcial.Data
{
    public class Response <T>
    {
        // Aqui va el mismo modelo de clase que esta en la api

        public int Exito { get; set; }
        public string Mensaje { get; set; }
        public T ls { get; set; }
    }
}
