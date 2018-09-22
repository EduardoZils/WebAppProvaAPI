using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppProvaAPI.Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppProvaAPI.Controllers
{
    public class DestinoController : Controller
    {


        private readonly WebAppProvaContext _context;
        /// <summary>
        /// Controller Reponsável por dar Manutenção na table Estado
        /// </summary>
        /// <param name="context"></param>
        public DestinoController(WebAppProvaContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Metodo que retorna todo os Estados
        /// </summary>
        /// <returns>Lista de Estados</returns>
        [HttpGet]
        public IEnumerable<Destino> GetDestino()
        {
            return _context.Destino;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDestino([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var destino = await _context.Destino.SingleOrDefaultAsync(m => m.Codigo == id);

            if (destino == null)
            {
                return NotFound();
            }

            return Ok(destino);
        }
    }
}
