using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api_Parcial.Models;
using Api_Parcial.Models.Response;

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
        public async Task<IActionResult> GetRobos()
        {
            Response<List<TablaRobo>> respuesta = new Response<List<TablaRobo>>();
            List<TablaRobo> lista = null;

            try
            {


                lista = await _context.TablaRobos.ToListAsync();

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
        public async Task<IActionResult> GetRobo(int id)
        {

            Response<TablaRobo> respuesta = new Response<TablaRobo>();
             TablaRobo lista = null;

            try
            {


                lista = await _context.TablaRobos.FindAsync(id);

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
        public async Task<IActionResult> PutRobos(TablaRobo Robo)
        {
            Response<object> respuesta = new Response<object>();

            try
            {
                var tabla = _context.TablaRobos.Find(Robo.Id);

                tabla.Cedula = Robo.Cedula;
                tabla.Nombre = Robo.Nombre;
                tabla.Fecha = Robo.Fecha;
                tabla.QueRobaron = Robo.QueRobaron;
                tabla.ValorDollar = Robo.ValorDollar;
                tabla.DondeOcurrio = Robo.DondeOcurrio;
                tabla.Latitud = Robo.Latitud;
                tabla.Logintud = Robo.Logintud;

                _context.Entry(tabla).State = EntityState.Modified;
                await _context.SaveChangesAsync();
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
        public async Task<ActionResult<TablaRobo>> PostRobos(TablaRobo robo)
        {
            Response<object> respuesta = new Response<object>();

            try
            {
                _context.TablaRobos.Add(robo);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                respuesta.mensaje = ex.Message;

                return Ok(respuesta);

            }


            return CreatedAtAction("GetRobo", new { id = robo.Id }, robo);
        }

        // DELETE: api/TablaRoboes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRobo(int id)
        {
            var paciente = await _context.TablaRobos.FindAsync(id);
            if (paciente == null)
            {
                return NotFound();
            }

            _context.TablaRobos.Remove(paciente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RoboExists(int id)
        {
            return _context.TablaRobos.Any(e => e.Id == id);
        }
    }
}
