using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppProvaAPI.Model;

namespace WebAppProvaAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Default")]
    public class DefaultController : Controller
    {

        private readonly WebAppProvaContext _context;
        /// <summary>
        /// Controller Reponsável por dar Manutenção na table 
        /// </summary>
        /// <param name="context"></param>
        public DefaultController(WebAppProvaContext context)
        {
            _context = context;
        }

        //---------------------------------------------------------------------------Destinos------------------------------------------------

        /// <summary>
        /// Metodo que retorna todo os Destino
        /// </summary>
        /// <returns>Lista de Destinos</returns>
        [HttpGet]
        public IEnumerable<Destino> GetDestinos()
        {
            return _context.Destinos;
        }

        // GET: api/Custo/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDestinos([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var destino = await _context.Destinos.SingleOrDefaultAsync(m => m.Codigo == id);

            if (destino == null)
            {
                return NotFound();
            }

            return Ok(destino);
        }

        // PUT: api/Custo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDestinos([FromRoute] int id, [FromBody] Destino destino)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != destino.Codigo)
            {
                return BadRequest();
            }

            _context.Entry(destino).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DestinoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> PostDestino([FromBody] Destino destino)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Destinos.Add(destino);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstado", new { id = destino.Codigo }, destino);
        }

        // DELETE: api/Custo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDestino([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var destino = await _context.Destinos.SingleOrDefaultAsync(m => m.Codigo == id);
            if (destino == null)
            {
                return NotFound();
            }

            _context.Destinos.Remove(destino);
            await _context.SaveChangesAsync();

            return Ok(destino);
        }

        private bool DestinoExists(int id)
        {
            return _context.Custos.Any(e => e.Codigo == id);
        }
    }
}