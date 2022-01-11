using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatinsAPI.Models
{
    public class Patins
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Numero { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
    }
}
