using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgas.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int CategpriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int SubCategoriaId { get; set; }
        public SubCategoria SubCategoria { get; set; }

    }
}
