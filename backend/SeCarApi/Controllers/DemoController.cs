using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SeCarApi.DAL.Context;
using SeCarApi.DAL.Entity;
using SeCarApi.Models;

namespace SeCarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DemoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Demo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Demo>>> GetDemoModel()
        {
            return await _context.DemoModels.ToListAsync();
        }

        // GET: api/Demo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Demo>> GetDemoModel(long id)
        {
            var demoModel = await _context.DemoModels.FindAsync(id);

            if (demoModel == null)
            {
                return NotFound();
            }

            return demoModel;
        }

        // PUT: api/Demo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDemoModel(long id, Demo demoModel)
        {
            if (id != demoModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(demoModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DemoModelExists(id))
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

        // POST: api/Demo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DemoModel>> PostDemoModel(Demo demoModel)
        {
            _context.DemoModels.Add(demoModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDemoModel), new { id = demoModel.Id }, demoModel);
        }

        // DELETE: api/Demo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDemoModel(long id)
        {
            var demoModel = await _context.DemoModels.FindAsync(id);
            if (demoModel == null)
            {
                return NotFound();
            }

            _context.DemoModels.Remove(demoModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DemoModelExists(long id)
        {
            return _context.DemoModels.Any(e => e.Id == id);
        }
    }
}
