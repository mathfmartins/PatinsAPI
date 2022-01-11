using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PatinsAPI.Models;
using PatinsAPI.Data;

namespace PatinsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatinsController : ControllerBase
    {
        private PatinsContext _context;
        public PatinsController(PatinsContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult PostPatins([FromBody] Patins patins)
        {
            _context.Patins.Add(patins);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetPatinsById), new { patins.Id }, patins);
        }

        [HttpGet]
        public IActionResult GetPatins()
        {
            return Ok(_context.Patins);
        }

        [HttpGet("{id}")]
        public IActionResult GetPatinsById(int id)
        {
            Patins patins = _context.Patins.Where((patins) => patins.Id == id).FirstOrDefault();
            if (patins != null)
                return Ok(patins);
            else
                return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult PutPatins(int id, [FromBody] Patins patins)
        {
            Patins patinsDb = _context.Patins.Where((patins) => patins.Id == id).FirstOrDefault();
            if (patinsDb != null)
            {
                //patinsDb.Id = patins.Id;
                patinsDb.Nome = patins.Nome;
                patinsDb.Modelo = patins.Modelo;
                patinsDb.Numero = patins.Numero;
                patinsDb.Marca = patins.Marca;
                _context.SaveChanges();
                return NoContent();
            }
            else
                return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePatins(int id)
        {
            var patins = _context.Patins.Where((patins) => patins.Id == id).FirstOrDefault();
            if (patins != null)
            {
                _context.Patins.Remove(patins);
                _context.SaveChanges();
                return NoContent();
            }
            else
                return NotFound();

        }
    }
}
