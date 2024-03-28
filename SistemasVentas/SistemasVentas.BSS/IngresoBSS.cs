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
    public class IngresoBss
    {
        IngresoDal dal = new IngresoDal();
        public DataTable ListarIngresoBss()
        {
            return dal.ListarIngresoDal();
        }
        public void InsertarIngresoBss(Ingreso ingreso)
        {
            dal.InsertarIngresoDal(ingreso);
        }
        public Ingreso ObtenerIdBss(int id)
        {
            return dal.ObtenerIngresoId(id);
        }
        public void EditarIngresoBss(Ingreso i)
        {
            dal.EditarIngresoDal(i);
        }
        public void EliminarIngresoBss(int id)
        {
            dal.EliminarIngresoDal(id);

        }
    }
}
