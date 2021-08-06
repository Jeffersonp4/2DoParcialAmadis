using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api_Parcial.Models;
using Api_Parcial.Models.Response;
using Api_Parcial.Models.Request;

namespace Api_Parcial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TablaRoboesController : ControllerBase
    {
        private readonly db_parcialContext _context;

        public TablaRoboesController(db_parcialContext context)
        {
            _context = context;
        }

        // GET: api/TablaRoboes
        [HttpGet]
        public IActionResult GetRobos()
        {
            Response<List<TablaRobo>> respuesta = new Response<List<TablaRobo>>();

            try
            { 
                var lista = _context.TablaRobos.ToList();
                respuesta.exito = 1;
                respuesta.ls = lista;
            }
            catch (Exception ex)
            {

                respuesta.mensaje = ex.Message;
            }


            return Ok(respuesta);
        }

        // GET: api/TablaRoboes/5
        [HttpGet("{id}")]
        public IActionResult GetRobo(int id)
        {

            Response<TablaRobo> respuesta = new Response<TablaRobo>();
             

            try
            {


                var lista =  _context.TablaRobos.Find(id);
                respuesta.exito = 1;
                respuesta.ls = lista;
            }
            catch (Exception ex)
            {

                respuesta.mensaje = ex.Message;
            }


            return Ok(respuesta);
        }

        // PUT: api/TablaRoboes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutRobos(Robo_Request request)
        {
            Response<object> respuesta = new Response<object>();

            try
            {
                TablaRobo tabla = _context.TablaRobos.Find(request.Id);

                tabla.Cedula = request.Cedula;
                tabla.Nombre = request.Nombre;
                tabla.Fecha = request.Fecha;
                tabla.QueRobaron = request.QueRobaron;
                tabla.ValorDollar = request.ValorDollar;
                tabla.DondeOcurrio = request.DondeOcurrio;
                tabla.Latitud = request.Latitud;
                tabla.Logintud = request.Logintud;

                _context.Entry(tabla).State = EntityState.Modified;
                _context.SaveChanges();
                respuesta.ls = tabla;
                respuesta.exito = 1;
            }
            catch (Exception ex)
            {

                respuesta.mensaje = ex.Message;
            }


            return Ok(respuesta);

            

        }

        // POST: api/TablaRoboes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public IActionResult PostRobos(Robo_Request _Request)
        {
            Response<object> respuesta = new Response<object>();
            TablaRobo tabla = new TablaRobo();
            try
            {
                
                tabla.Cedula = _Request.Cedula;
                tabla.Nombre = _Request.Nombre;
                tabla.Fecha = _Request.Fecha;
                tabla.QueRobaron = _Request.QueRobaron;
                tabla.ValorDollar = _Request.ValorDollar;
                tabla.DondeOcurrio = _Request.DondeOcurrio;
                tabla.Latitud = _Request.Latitud;
                tabla.Logintud = _Request.Logintud;
                _context.TablaRobos.Add(tabla);
                _context.SaveChanges();
                respuesta.exito = 1;
                respuesta.ls = tabla;
            }
            catch (Exception ex)
            {

                respuesta.mensaje = ex.Message;

                return Ok(respuesta);

            }


            return Ok(respuesta);
        }

        // DELETE: api/TablaRoboes/5
        [HttpDelete("{id}")]
        public IActionResult DeleteRobo(int id)
        {
            Response<object> respuesta = new Response<object>();

            try
            {
                TablaRobo tabla = _context.TablaRobos.Find(id);

                _context.Remove(tabla);
                _context.SaveChanges();
                respuesta.exito = 1;
            }
            catch (Exception ex)
            {

                respuesta.mensaje = ex.Message;
            }


            return Ok(respuesta);
        }

        private bool RoboExists(int id)
        {
            return _context.TablaRobos.Any(e => e.Id == id);
        }
    }
}
