using SistemasVentas.DAL;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class ProductoBss
    {
        ProductoDal dal = new ProductoDal();
        public DataTable ListarProductosBass()
        {
            return dal.ListarProductosDal();
        }

        public void InsertarProductoBss(Producto producto)
        {
            dal.InsertarProductoDal(producto);
        }

        public Producto ObtenerProductoIdBss(int id)
        {
            return dal.ObtenerProductoId(id);
        }

        public void EditarProductoBss(Producto producto)
        {
            dal.EditarProductoDal(producto);
        }

        public void EliminarProductoBss(int id)
        {
            dal.EliminarProductoDal(id);
        }
    }
}
