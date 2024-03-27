using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public int IdTipoProd { get; set; }
        public int IdMarca { get; set; }
        public string Nombre { get; set; }
        public string CodigoBarra { get; set; }
        public int Unidad { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
    }
}
