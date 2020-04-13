using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PasportDetails.Models;

namespace PasportDetails.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class PDetailsController : ControllerBase
    {
        private readonly PDetailsContex _context;
        public PDetailsController(PDetailsContex context)
        {
            _context = context;
        }

        // GET: api/PDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PDetails>>> GetPDetails()
        {
            return await _context.PDetails.ToListAsync();
        }

        // GET: api/PDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PDetails>> GetPDetails(int id)
        {
            var pDetails = await _context.PDetails.FindAsync(id);

            if (pDetails == null)
            {
                return NotFound();
            }

            return pDetails;
        }

        // PUT: api/PDetails/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPDetails(int id, PDetails pDetails)
        {
            if (id != pDetails.PId)
            {
                return BadRequest();
            }

            _context.Entry(pDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PDetailsExists(id))
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

        // POST: api/PDetails
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PDetails>> PostPDetails(PDetails pDetails)
        {
            _context.PDetails.Add(pDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPDetails", new { id = pDetails.PId }, pDetails);
        }

        // DELETE: api/PDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PDetails>> DeletePDetails(int id)
        {
            var pDetails = await _context.PDetails.FindAsync(id);
            if (pDetails == null)
            {
                return NotFound();
            }

            _context.PDetails.Remove(pDetails);
            await _context.SaveChangesAsync();

            return pDetails;
        }

        private bool PDetailsExists(int id)
        {
            return _context.PDetails.Any(e => e.PId == id);
        }
    }
}
