using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgas.Models
{
    public class SubCategoria
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public  int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
