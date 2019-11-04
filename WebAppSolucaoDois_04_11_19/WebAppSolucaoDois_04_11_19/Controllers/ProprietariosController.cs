using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppSolucaoDois_04_11_19.Model;

namespace WebAppSolucaoDois_04_11_19.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProprietariosController : ControllerBase
    {
        private readonly Context _context;

        public ProprietariosController(Context context)
        {
            _context = context;
        }

        // GET: api/Proprietarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Proprietario>>> GetGetProprietarios()
        {
            return await _context.GetProprietarios.ToListAsync();
        }

        // GET: api/Proprietarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Proprietario>> GetProprietario(int id)
        {
            var proprietario = await _context.GetProprietarios.FindAsync(id);

            if (proprietario == null)
            {
                return NotFound();
            }

            return proprietario;
        }

        // PUT: api/Proprietarios/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProprietario(int id, Proprietario proprietario)
        {
            if (id != proprietario.Id)
            {
                return BadRequest();
            }

            _context.Entry(proprietario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProprietarioExists(id))
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

        // POST: api/Proprietarios
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Proprietario>> PostProprietario(Proprietario proprietario)
        {
            _context.GetProprietarios.Add(proprietario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProprietario", new { id = proprietario.Id }, proprietario);
        }

        // DELETE: api/Proprietarios/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Proprietario>> DeleteProprietario(int id)
        {
            var proprietario = await _context.GetProprietarios.FindAsync(id);
            if (proprietario == null)
            {
                return NotFound();
            }

            _context.GetProprietarios.Remove(proprietario);
            await _context.SaveChangesAsync();

            return proprietario;
        }

        private bool ProprietarioExists(int id)
        {
            return _context.GetProprietarios.Any(e => e.Id == id);
        }
    }
}
