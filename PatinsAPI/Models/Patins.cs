using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatinsAPI.Models
{
    public class Patins
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome deve ser informado.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Numero deve ser informado.")]
        public int Numero { get; set; }
        [Required(ErrorMessage = "Modelo deve ser informado.")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "Marca deve ser informada")]
        public string Marca { get; set; }
    }
}
