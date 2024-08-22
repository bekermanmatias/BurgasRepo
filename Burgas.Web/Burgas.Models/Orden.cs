using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgas.Models
{
    public class Orden
    {
        public int Id { get; set; }
        public string UsuarioAppId { get; set; }
        public UsuarioApp UsuarioApp { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrdenDate { get; set; }
    }
}
