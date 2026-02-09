using Microsoft.AspNetCore.Mvc;
using RandomThings.Models;
using RandomThings.Services;

namespace RandomThings.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        // GET: Colors
        [HttpGet]
        public ActionResult<List<Color>> GetColors() => ColorsService.GetAll();

        // GET: Colors/Random
        [HttpGet("random")]
        public ActionResult<Color> GetColor() => ColorsService.GetRandom();

        // GET: Colors/5
        [HttpGet("{id}")]
        public ActionResult<Color> Get(int id)
        {
            var color = ColorsService.Get(id);

            if (color == null)
                return NotFound();

            return color;
        }

        // // PUT: Colors/5
        // // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        // [HttpPut("{id}")]
        // public async Task<IActionResult> PutColor(int id, Color color)
        // {
        //     if (id != color.Id)
        //     {
        //         return BadRequest();
        //     }

        //     _context.Entry(color).State = EntityState.Modified;

        //     try
        //     {
        //         await _context.SaveChangesAsync();
        //     }
        //     catch (DbUpdateConcurrencyException)
        //     {
        //         if (!ColorExists(id))
        //         {
        //             return NotFound();
        //         }
        //         else
        //         {
        //             throw;
        //         }
        //     }

        //     return NoContent();
        // }

        // POST: Colors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public IActionResult Create(string name)
        {
            if (name == null)
                throw new ArgumentNullException($"Name: {name} cannot be null.");

            Color newColor = ColorsService.Add(name);
            return CreatedAtAction(nameof(Get), new { id = newColor.Id }, newColor);
        }

        // // DELETE: Colors/5
        // [HttpDelete("{id}")]
        // public async Task<IActionResult> DeleteColor(int id)
        // {
        //     var color = await _context.Color.FindAsync(id);
        //     if (color == null)
        //     {
        //         return NotFound();
        //     }

        //     _context.Color.Remove(color);
        //     await _context.SaveChangesAsync();

        //     return NoContent();
        // }

        // private bool ColorExists(int id)
        // {
        //     return _context.Color.Any(e => e.Id == id);
        // }
    }
}
