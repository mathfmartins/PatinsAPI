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
        private static Patins _patins = new Patins();

        public IActionResult AddPatins()
    }
}
