using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Parcial.Models.Response
{
    public class Response<T>
    {
        public int exito { get; set; }
        public string mensaje { get; set; }

        public T ls { get; set; }
        public Response()
        {
            this.exito = 0;
        }
    }
}
