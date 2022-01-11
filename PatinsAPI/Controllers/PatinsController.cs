using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PatinsAPI.Models;
using PatinsAPI.Data;
using PatinsAPI.Dtos;
using AutoMapper;

namespace PatinsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatinsController : ControllerBase
    {
        private PatinsContext _context;
        private IMapper _mapper;
        public PatinsController(PatinsContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult PostPatins([FromBody] PostPatinsDto patinsDto)
        {
            Patins patins = _mapper.Map<Patins>(patinsDto);
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
            {
                GetPatinsByIdDto patinsDto = _mapper.Map<GetPatinsByIdDto>(patins);
                return Ok(patinsDto);
            }
            else
                return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult PutPatins(int id, [FromBody] PutPatinsDto patinsDto)
        {
            Patins patinsDb = _context.Patins.Where((patins) => patins.Id == id).FirstOrDefault();
            if (patinsDb != null)
            {
                _mapper.Map(patinsDto, patinsDb);
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
