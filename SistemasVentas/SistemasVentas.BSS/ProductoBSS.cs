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
    public class ProductoBSS
    {
        ProductoDAL dal = new ProductoDAL();
        public DataTable ListarProductoBss()
        {
            return dal.ListarProductoDal();
        }
        public void InsertarProductoBss(Producto producto)
        {
            dal.InsertarProductoDAL(producto);
        }

        public Producto ObtenerProductoIdBss(int id)
        {
            return dal.ObtenerProductoIdDal(id);
        }
        public void EditarProductoBss(Producto p)
        {
            dal.EditarProductoDal(p);
        }
        public void EliminarProductoBss(int id)
        {
            dal.EliminarProductoDal(id);
        }
    }
}
