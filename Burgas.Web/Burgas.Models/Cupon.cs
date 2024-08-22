using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgas.Models
{
    public class Cupon
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public double Descuento { get; set; }
        public double MinimoMonto { get; set; }
        public byte[] ImagenCupon { get; set; }
        public bool EsActivo { get; set; }
    }
    public enum TipoCupon
    {
        Porcentaje=0,
        Valor=1
    }
}
