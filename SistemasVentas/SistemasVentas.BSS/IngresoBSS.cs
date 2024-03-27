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
    public class IngresoBSS
    {
        IngresoDAL dal = new IngresoDAL();
        public DataTable ListarIngresoBss()
        {
            return dal.ListarIngresoDal();
        }
        public void InsertarIngresoBss(Ingreso ingreso)
        {
            dal.InsertarIngresoDAL(ingreso);
        }

        public Ingreso ObtenerIngresoIdBss(int id)
        {
            return dal.ObtenerIngresoIdDal(id);
        }
        public void EditarIngresoBss(Ingreso p)
        {
            dal.EditarIngresoDal(p);
        }
        public void EliminarIngresoBss(int id)
        {
            dal.EliminarIngresoDal(id);
        }
    }
}
