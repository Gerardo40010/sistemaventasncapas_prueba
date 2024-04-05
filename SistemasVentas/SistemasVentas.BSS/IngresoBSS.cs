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
        public DataTable ListarIngresosBass()
        {
            return dal.ListarIngresosDal();
        }

        public void InsertarIngresoBss(Ingreso ingreso)
        {
            dal.InsertarIngresoDal(ingreso);
        }

        public Ingreso ObtenerIngresoIdBss(int id)
        {
            return dal.ObtenerIngresoId(id);
        }

        public void EditarIngresoBss(Ingreso ingreso)
        {
            dal.EditarIngresoDal(ingreso);
        }

        public void EliminarIngresoBss(int id)
        {
            dal.EliminarIngresoDal(id);
        }
    }
}
