using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgas.Models
{
    public class Carrito
    {
        [Key]
        public int Id { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public string UsuarioAppId { get; set; }
        public UsuarioApp UsuarioApp { get; set; }
        [Required, MinLength(1)]
        public int Cantidad { get; set; }

    }
}
