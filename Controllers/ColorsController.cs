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
        public ActionResult<List<Color>> GetAll() => ColorsService.GetAll();

        // GET: Colors/Random
        [HttpGet("random")]
        public ActionResult<Color> GetRandom() => ColorsService.GetRandom();

        // GET: Colors/5
        [HttpGet("{id}")]
        public ActionResult<Color> Get(int id)
        {
            var color = ColorsService.Get(id);

            if (color == null)
                return NotFound();

            return color;
        }

        // POST: Colors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public IActionResult Create([FromBody] CreateColorRequest request)
        {
            string name = request.Name;
            if (name == null)
                throw new ArgumentNullException($"Name: {name} cannot be null.");

            Color newColor = ColorsService.Create(name);
            return CreatedAtAction(nameof(Get), new { id = newColor.Id }, newColor);
        }

        // // PUT: Colors/5
        // // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] CreateColorRequest request)
        {
            string name = request.Name;
            if (name == null)
                throw new ArgumentNullException($"Name: {name} cannot be null.");

            var color = ColorsService.Get(id);
            if (color is null)
                return NotFound();

            ColorsService.Update(color, name);
            return NoContent();
        }

        // // DELETE: Colors/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var color = ColorsService.Get(id);

            if (color is null)
                return NotFound();

            ColorsService.Delete(id);

            return NoContent();
        }
    }
}
