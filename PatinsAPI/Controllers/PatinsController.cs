using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PatinsAPI.Models;

namespace PatinsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatinsController : ControllerBase
    {
        private static IList<Patins> _patins = new List<Patins>();

        [HttpPost]
        public IActionResult PostPatins([FromBody] Patins patins)
        {
            _patins.Add(patins);
            return CreatedAtAction(nameof(GetPatinsById), new { patins.Id }, patins);
        }

        [HttpGet]
        public IActionResult GetPatins()
        {
            return Ok(_patins);
        }

        [HttpGet("{id}")]
        public IActionResult GetPatinsById(int id)
        {
            var patins = _patins.Where((patins) => patins.Id == id).FirstOrDefault();
            if (patins != null)
                return Ok(patins);
            else
                return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult PutPatins(int id, [FromBody] Patins patins)
        {
            var patinsDb = _patins.Where((patins) => patins.Id == id).FirstOrDefault();
            if (patinsDb != null)
            {
                patinsDb.Id = patins.Id;
                patinsDb.Nome = patins.Nome;
                patinsDb.Modelo = patins.Modelo;
                patinsDb.Numero = patins.Numero;
                patinsDb.Marca = patins.Marca;
                return NoContent();
            }
            else
                return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePatins(int id)
        {
            var patins = _patins.Where((patins) => patins.Id == id).FirstOrDefault();
            if (patins != null)
            {
                _patins.Remove(patins);
                return NoContent();
            }
            else
                return NotFound();

        }
    }
}
