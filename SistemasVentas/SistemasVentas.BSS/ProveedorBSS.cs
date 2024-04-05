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
        public DataTable ListarProveedoresBass()
        {
            return dal.ListarProveedoresDal();
        }

        public void InsertarProveedorBss(Proveedor proveedor)
        {
            dal.InsertarProveedorDal(proveedor);
        }

        public Proveedor ObtenerProveedorIdBss(int id)
        {
            return dal.ObtenerProveedorId(id);
        }

        public void EditarProveedorBss(Proveedor proveedor)
        {
            dal.EditarProveedorDal(proveedor);
        }

        public void EliminarProveedorBss(int id)
        {
            dal.EliminarProveedorDal(id);
        }
    }
}
