using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatinsAPI.Dtos
{
    public class GetPatinsDto
    {
        public GetPatinsDto()
        {
            HoraDaConsulta = DateTime.Now;
        }

        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome deve ser informado.")]
        [StringLength(30, ErrorMessage = "Nome deve ter no máximo 30 caracteres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Numero deve ser informado.")]
        [Range(20, 45, ErrorMessage = "Número deve estar entre 20 e 45.")]
        public int Numero { get; set; }
        [Required(ErrorMessage = "Modelo deve ser informado.")]
        [StringLength(30, ErrorMessage = "Modelo deve ter no máximo 30 caracteres.")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "Marca deve ser informada.")]
        [StringLength(20, ErrorMessage = "Marca deve ter no máximo 20 caracteres")]
        public string Marca { get; set; }
        public DateTime HoraDaConsulta { get; set; }
    }
}
