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
    public class ProveedorBss
    {
        ProveedorDal dal = new ProveedorDal();
        public DataTable ListarProveedorBss()
        {
            return dal.ListarProveedorDal();
        }
        public void InsertarProveedorBss(Proveedor proveedor)
        {
            dal.InsertarProveedorDal(proveedor);
        }
        public Proveedor ObtenerIdBss(int id)
        {
            return dal.ObtenerProveedorId(id);
        }
        public void EditarProveedorBss(Proveedor p)
        {
            dal.EditarProveedorDal(p);
        }
        public void EliminarProveedorBss(int id)
        {
            dal.EliminarProveedorDal(id);

        }
    }
}
