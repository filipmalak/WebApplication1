using Microsoft.AspNetCore.Mvc;
using WebApplication1.DB;
using WebApplication1.Models;
using System.Linq;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/schronisko")]
    public class SchroniskoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Db.Schronisko);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var zwierze = Db.Schronisko.FirstOrDefault(st => st.Id == id);
            if (zwierze == null)
            {
                return NotFound();
            }
            return Ok(zwierze);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Zwierze zwierze)
        {
            Db.Schronisko.Add(zwierze);
            return CreatedAtAction(nameof(Get), new { id = zwierze.Id }, zwierze);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Zwierze data)
        {
            var zwierze = Db.Schronisko.FirstOrDefault(st => st.Id == id);
            if (zwierze == null)
            {
                return NotFound();
            }

            zwierze.Imie = data.Imie;
            zwierze.Kategoria = data.Kategoria;
            zwierze.Masa = data.Masa;
            zwierze.Kolor_siersci = data.Kolor_siersci;
            return Ok(zwierze);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var zwierze = Db.Schronisko.FirstOrDefault(st => st.Id == id);
            if (zwierze == null)
            {
                return NotFound();
            }

            Db.Schronisko.Remove(zwierze);
            return NoContent();
        }
    }
}