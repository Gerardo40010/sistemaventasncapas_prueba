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
    public class RolBss
    {
        RolDAL dal = new RolDAL();
        public DataTable ListarRolBss()
        {
            return dal.ListarRolDal();
        }

        public void InsertarRolBss(Rol rol)
        {
            dal.InsertarRolDAL(rol);
        }

        public Rol ObtenerRolIdBss(int id)
        {
            return dal.ObtenerRolIdDal(id);
        }

        public void EditarRolBss(Rol r)
        {
            dal.EditarRolDal(r);
        }

        public void EliminarRolBss(int id)
        {
            dal.EliminarRolDal(id);
        }

    }
}
